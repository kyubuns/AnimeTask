using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
#if ENABLE_UNITASK
using Task = UniRx.Async.UniTask;
#else
using System.Threading.Tasks;
#endif

namespace AnimeTask
{
    public static class Anime
    {
        private static IScheduler defaultScheduler = new TimeScheduler();
        private static AnimeRunner animeRunner;
        public static IScheduler DefaultScheduler
        {
            get { return defaultScheduler; }
            set { defaultScheduler = value; }
        }

        public static Task Play<T>(IAnimator<T> animator, ITranslator<T> translator, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Play(animator, translator, DefaultScheduler, cancellationToken);
        }

        public static async Task Play<T>(IAnimator<T> animator, ITranslator<T> translator, IScheduler scheduler, CancellationToken cancellationToken = default(CancellationToken))
        {
            var awaitable = new AwaitableEnumerator();
            animator.Start();
            StartCoroutine(PlayCoroutine(animator, translator, awaitable, scheduler, cancellationToken));
            await awaitable;
        }

        public static Task PlayTo<T>(IAnimatorWithStartValue<T> animator, IValueTranslator<T> translator, CancellationToken cancellationToken = default(CancellationToken))
        {
            return PlayTo(animator, translator, DefaultScheduler, cancellationToken);
        }

        public static async Task PlayTo<T>(IAnimatorWithStartValue<T> animator, IValueTranslator<T> translator, IScheduler scheduler, CancellationToken cancellationToken = default(CancellationToken))
        {
            var awaitable = new AwaitableEnumerator();
            animator.Start(translator.Current);
            StartCoroutine(PlayCoroutine(new DummyAnimator<T>(animator), translator, awaitable, scheduler, cancellationToken));
            await awaitable;
        }

        public static Task Delay(float duration)
        {
            return Delay(duration, DefaultScheduler);
        }

        public static async Task Delay(float duration, IScheduler scheduler)
        {
            var awaitable = new AwaitableEnumerator();
            StartCoroutine(DelayCoroutine(duration, awaitable, scheduler));
            await awaitable;
        }

        private static void StartCoroutine(IEnumerator coroutine)
        {
            if (animeRunner == null)
            {
                var go = new GameObject("AnimeRunner");
                animeRunner = go.AddComponent<AnimeRunner>();
            }
            animeRunner.StartCoroutine(coroutine);
        }

        private static IEnumerator PlayCoroutine<T>(IAnimator<T> animator, ITranslator<T> translator, AwaitableEnumerator awaitable, IScheduler scheduler, CancellationToken cancellationToken)
        {
            var startTime = scheduler.Now;
            while (true)
            {
                if (cancellationToken.IsCancellationRequested) break;
                var t = animator.Update(scheduler.Now - startTime);
                translator.Update(t.Item1);
                if (t.Item2) break;
                yield return null;
            }
            awaitable.Finished();
        }

        private static IEnumerator DelayCoroutine(float duration, AwaitableEnumerator awaitable, IScheduler scheduler)
        {
            var startTime = scheduler.Now;
            yield return new WaitWhile(() => scheduler.Now - startTime < duration);
            awaitable.Finished();
        }
    }

    public class DummyAnimator<T> : IAnimator<T>
    {
        private readonly IAnimatorWithStartValue<T> animator;

        public DummyAnimator(IAnimatorWithStartValue<T> animator)
        {
            this.animator = animator;
        }

        public void Start()
        {
        }

        public Tuple<T, bool> Update(float time)
        {
            return animator.Update(time);
        }
    }

    public class AwaitableEnumerator : INotifyCompletion
    {
        private Action continuationAction;
        public bool IsCompleted { get; private set; }
        public void GetResult() {}

        public void OnCompleted(Action continuation)
        {
            continuationAction = continuation;
        }

        public void Finished()
        {
            IsCompleted = true;
            continuationAction();
        }
    }

    public static class AwaitableEnumeratorExtensions
    {
        public static AwaitableEnumerator GetAwaiter(this AwaitableEnumerator awaitable)
        {
            return awaitable;
        }
    }
}

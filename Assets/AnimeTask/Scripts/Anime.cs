using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace AnimeTask
{
    public static class Anime
    {
        private static AnimeRunner animeRunner;

        public static async Task Play<T>(IAnimator<T> animator, ITranslator<T> translator)
        {
            if (animeRunner == null)
            {
                var go = new GameObject("AnimeRunner");
                animeRunner = go.AddComponent<AnimeRunner>();
            }
            var awaitable = new AwaitableEnumerator();
            animator.Start();
            animeRunner.StartCoroutine(Coroutine(animator, translator, awaitable));
            await awaitable;
        }

        public static async Task PlayTo<T>(IAnimatorWithStartValue<T> animator, IValueTranslator<T> translator)
        {
            if (animeRunner == null)
            {
                var go = new GameObject("AnimeRunner");
                animeRunner = go.AddComponent<AnimeRunner>();
            }
            var awaitable = new AwaitableEnumerator();
            animator.Start(translator.Current);
            animeRunner.StartCoroutine(Coroutine(new DummyAnimator<T>(animator), translator, awaitable));
            await awaitable;
        }

        private static IEnumerator Coroutine<T>(IAnimator<T> animator, ITranslator<T> translator, AwaitableEnumerator awaitable)
        {
            while (true)
            {
                var t = animator.Update();
                translator.Update(t.Item1);
                if (t.Item2) break;
                yield return null;
            }
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

        public Tuple<T, bool> Update()
        {
            return animator.Update();
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

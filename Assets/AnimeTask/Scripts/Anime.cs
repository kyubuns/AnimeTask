using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace AnimeTask
{
    public static class Anime
    {
        public static IScheduler DefaultScheduler { get; set; } = new TimeScheduler();

        public static UniTask Play<T>(IAnimator<T> animator, ITranslator<T> translator, CancellationToken cancellationToken = default)
        {
            return Play(animator, translator, DefaultScheduler, cancellationToken);
        }

        public static async UniTask Play<T>(IAnimator<T> animator, ITranslator<T> translator, IScheduler scheduler, CancellationToken cancellationToken = default)
        {
            animator.Start();
            await PlayInternal(animator, translator, scheduler, cancellationToken);
        }

        public static UniTask PlayTo<T>(IAnimatorWithStartValue<T> animator, IValueTranslator<T> translator, CancellationToken cancellationToken = default)
        {
            return PlayTo(animator, translator, DefaultScheduler, cancellationToken);
        }

        public static async UniTask PlayTo<T>(IAnimatorWithStartValue<T> animator, IValueTranslator<T> translator, IScheduler scheduler, CancellationToken cancellationToken = default)
        {
            animator.Start(translator.Current);
            await PlayInternal(new DummyAnimator<T>(animator), translator, scheduler, cancellationToken);
        }

        public static UniTask Delay(float duration, CancellationToken cancellationToken = default)
        {
            return Delay(duration, DefaultScheduler, cancellationToken);
        }

        public static async UniTask Delay(float duration, IScheduler scheduler, CancellationToken cancellationToken = default)
        {
            await DelayInternal(duration, scheduler, cancellationToken);
        }

        private static async UniTask PlayInternal<T>(IAnimator<T> animator, ITranslator<T> translator, IScheduler scheduler, CancellationToken cancellationToken)
        {
            var startTime = scheduler.Now;
            while (!cancellationToken.IsCancellationRequested && Application.isPlaying)
            {
                var (t, finished) = animator.Update(scheduler.Now - startTime);
                translator.Update(t);
                if (finished) break;
                await UniTask.Yield(PlayerLoopTiming.Update, cancellationToken);
            }
        }

        private static async UniTask DelayInternal(float duration, IScheduler scheduler, CancellationToken cancellationToken)
        {
            var startTime = scheduler.Now;
            await UniTask.WaitWhile(() => scheduler.Now - startTime < duration, cancellationToken: cancellationToken);
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
}

using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace AnimeTask
{
    public static class Anime
    {
        public static IScheduler DefaultScheduler { get; set; } = new TimeScheduler();

        public static UniTask Play<T>(IAnimator<T> animator, ITranslator<T> translator, IScheduler scheduler = default, CancellationToken cancellationToken = default, SkipToken skipToken = default)
        {
            return PlayInternal(animator, translator, scheduler, cancellationToken, skipToken);
        }

        public static UniTask PlayTo<T>(IAnimatorWithStartValue<T> animatorWithStartValue, IValueTranslator<T> translator, IScheduler scheduler = default, CancellationToken cancellationToken = default, SkipToken skipToken = default)
        {
            var animator = animatorWithStartValue.Start(translator.Current);
            return PlayInternal(animator, translator, scheduler, cancellationToken, skipToken);
        }

        private static async UniTask PlayInternal<T>(IAnimator<T> animator, ITranslator<T> translator, IScheduler scheduler, CancellationToken cancellationToken, SkipToken skipToken)
        {
            if (scheduler == default) scheduler = DefaultScheduler;

            var startTime = scheduler.Now;
            while (!cancellationToken.IsCancellationRequested && !skipToken.IsSkipRequested && Application.isPlaying)
            {
                var time = scheduler.Now - startTime;
                var (t, used) = animator.Update(time);
                translator.Update(t);
                if (used < time) break;
                await UniTask.Yield(PlayerLoopTiming.Update, cancellationToken);
            }

            cancellationToken.ThrowIfCancellationRequested();

            if (skipToken.IsSkipRequested)
            {
                var (t, _) = animator.Update(float.MaxValue);
                translator.Update(t);
            }
        }

        public static UniTask Delay(float duration, IScheduler scheduler = default, CancellationToken cancellationToken = default)
        {
            return DelayInternal(duration, scheduler, cancellationToken);
        }

        private static async UniTask DelayInternal(float duration, IScheduler scheduler, CancellationToken cancellationToken)
        {
            if (scheduler == default) scheduler = DefaultScheduler;

            var startTime = scheduler.Now;
            while (!cancellationToken.IsCancellationRequested && Application.isPlaying)
            {
                var time = scheduler.Now - startTime;
                if (duration < time) break;
                await UniTask.Yield(PlayerLoopTiming.Update, cancellationToken);
            }
            cancellationToken.ThrowIfCancellationRequested();
        }
    }

    public struct SkipToken
    {
        private readonly SkipTokenSource source;
        private readonly bool skipped;

        public SkipToken(bool skipped)
        {
            source = null;
            this.skipped = skipped;
        }

        public SkipToken(SkipTokenSource source)
        {
            this.source = source;
            skipped = false;
        }

        public bool IsSkipRequested => source?.IsSkipRequested ?? skipped;

        public static SkipToken None => new SkipToken(false);
    }

    public class SkipTokenSource : IDisposable
    {
        public SkipTokenSource()
        {
            IsSkipRequested = false;
            Token = new SkipToken(this);
        }

        public void Skip()
        {
            IsSkipRequested = true;
        }

        public bool IsSkipRequested { get; private set; }

        public SkipToken Token { get; }

        public void Dispose()
        {
            Skip();
        }
    }
}

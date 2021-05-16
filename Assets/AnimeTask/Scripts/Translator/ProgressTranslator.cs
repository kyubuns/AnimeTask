using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        [MustUseReturnValue] public static UniTask ToProgress<T>(this IAnimator<T> animator, IProgress<T> progress, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default) => Anime.Play(animator, new ProgressTranslator<T>(progress), scheduler, cancellationToken, skipToken);
    }

    public class ProgressTranslator<T> : ITranslator<T>
    {
        private readonly IProgress<T> progress;

        public ProgressTranslator(IProgress<T> progress)
        {
            this.progress = progress;
        }

        public void Update(T value)
        {
            progress.Report(value);
        }
    }
}
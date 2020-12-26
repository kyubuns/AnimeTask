using System;
using System.Threading;
using Cysharp.Threading.Tasks;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static ProgressTranslator<T> Progress<T>(IProgress<T> progress) => new ProgressTranslator<T>(progress);
        public static UniTask ToProgress<T>(this IAnimator<T> animator, IProgress<T> progress, CancellationToken cancellationToken = default) => Anime.Play(animator, Progress(progress), cancellationToken);
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
using System;
using System.Threading;
using Cysharp.Threading.Tasks;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static UniTask ToAction<T>(this IAnimator<T> animator, Action<T> action, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, new ActionTranslator<T>(action), scheduler, cancellationToken);
    }

    public class ActionTranslator<T> : ITranslator<T>
    {
        private readonly Action<T> action;

        public ActionTranslator(Action<T> action)
        {
            this.action = action;
        }

        public void Update(T value)
        {
            action(value);
        }
    }
}

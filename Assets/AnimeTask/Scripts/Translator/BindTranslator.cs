using System;
using System.Threading;
using Cysharp.Threading.Tasks;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static UniTask ToBind<T>(this IAnimator<T> animator, Func<T> getter, Action<T> setter, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, new BindTranslator<T>(getter, setter), scheduler, cancellationToken);
        public static UniTask ToBind<T>(this IAnimatorWithStartValue<T> animator, Func<T> getter, Action<T> setter, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, new BindTranslator<T>(getter, setter), scheduler, cancellationToken);
    }

    public class BindTranslator<T> : IValueTranslator<T>
    {
        private readonly Func<T> getter;
        private readonly Action<T> setter;

        public T Current => getter();

        public BindTranslator(Func<T> getter, Action<T> setter)
        {
            this.getter = getter;
            this.setter = setter;
        }

        public void Update(T value)
        {
            setter(value);
        }
    }
}
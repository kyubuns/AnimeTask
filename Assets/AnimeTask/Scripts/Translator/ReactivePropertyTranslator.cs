#if ANIMETASK_UNIRX_SUPPORT
using System.Threading;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using UniRx;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        [MustUseReturnValue] public static UniTask ToReactiveProperty<T>(this IAnimator<T> animator, ReactiveProperty<T> reactiveProperty, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default) => Anime.Play(animator, new ReactivePropertyTranslator<T>(reactiveProperty), scheduler, cancellationToken, skipToken);
        [MustUseReturnValue] public static UniTask ToReactiveProperty<T>(this IAnimatorWithStartValue<T> animator, ReactiveProperty<T> reactiveProperty, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, new ReactivePropertyTranslator<T>(reactiveProperty), scheduler, cancellationToken, skipToken);
    }

    public class ReactivePropertyTranslator<T> : IValueTranslator<T>
    {
        public T Current => reactiveProperty.Value;
        private readonly ReactiveProperty<T> reactiveProperty;

        public ReactivePropertyTranslator(ReactiveProperty<T> reactiveProperty)
        {
            this.reactiveProperty = reactiveProperty;
        }

        public void Update(T value)
        {
            reactiveProperty.Value = value;
        }
    }
}
#endif
using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using Object = UnityEngine.Object;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        [MustUseReturnValue]
        public static UniTask ToBind<T>(this IAnimator<T> animator, Func<T> getter, Action<T> setter, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            return Anime.Play(animator, new BindTranslator<T>(getter, setter), scheduler, cancellationToken, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToBind<T>(this IAnimatorWithStartValue<T> animator, Func<T> getter, Action<T> setter, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            return Anime.PlayTo(animator, new BindTranslator<T>(getter, setter), scheduler, cancellationToken, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToBind<T>(this IAnimator<T> animator, Func<T> getter, Action<T> setter, Object unityObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            return Anime.Play(animator, new BindTranslatorWithObject<T>(getter, setter, unityObject), scheduler, cancellationToken, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToBind<T>(this IAnimatorWithStartValue<T> animator, Func<T> getter, Action<T> setter, Object unityObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            return Anime.PlayTo(animator, new BindTranslatorWithObject<T>(getter, setter, unityObject), scheduler, cancellationToken, skipToken);
        }
    }

    public class BindTranslator<T> : IValueTranslator<T>
    {
        public bool Alive => true;

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

    public class BindTranslatorWithObject<T> : IValueTranslator<T>
    {
        public bool Alive => unityObject != null;

        private readonly Func<T> getter;
        private readonly Action<T> setter;
        private readonly Object unityObject;

        public T Current => getter();

        public BindTranslatorWithObject(Func<T> getter, Action<T> setter, Object unityObject)
        {
            this.getter = getter;
            this.setter = setter;
            this.unityObject = unityObject;
        }

        public void Update(T value)
        {
            setter(value);
        }
    }
}
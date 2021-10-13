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
        public static UniTask ToAction<T>(this IAnimator<T> animator, Action<T> action, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            return Anime.Play(animator, new ActionTranslator<T>(action), scheduler, cancellationToken, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAction<T>(this IAnimator<T> animator, Action<T> action, Object unityObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            return Anime.Play(animator, new ActionTranslatorWithObject<T>(action, unityObject), scheduler, cancellationToken, skipToken);
        }
    }

    public class ActionTranslator<T> : ITranslator<T>
    {
        public bool Alive => true;

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

    public class ActionTranslatorWithObject<T> : ITranslator<T>
    {
        public bool Alive => unityObject != null;

        private readonly Action<T> action;
        private readonly Object unityObject;

        public ActionTranslatorWithObject(Action<T> action, Object unityObject)
        {
            this.action = action;
            this.unityObject = unityObject;
        }

        public void Update(T value)
        {
            action(value);
        }
    }
}

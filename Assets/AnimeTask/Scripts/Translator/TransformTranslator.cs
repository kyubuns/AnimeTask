using System.Threading;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        [MustUseReturnValue]
        public static UniTask ToLocalPosition(this IAnimator<Vector3> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new LocalPositionTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalPosition(this IAnimator<Vector3> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new LocalPositionTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalPosition(this IAnimator<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new LocalPositionTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalPosition(this IAnimator<Vector2> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new LocalPositionTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToLocalPosition(this IAnimatorWithStartValue<Vector3> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new LocalPositionTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToLocalPosition(this IAnimatorWithStartValue<Vector3> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new LocalPositionTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToLocalPosition(this IAnimatorWithStartValue<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new LocalPositionTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToLocalPosition(this IAnimatorWithStartValue<Vector2> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new LocalPositionTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToLocalPositionX(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new LocalPositionXTranslator(gameObject.transform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToLocalPositionX(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new LocalPositionXTranslator(component.transform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalPositionX(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new LocalPositionXTranslator(gameObject.transform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalPositionX(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new LocalPositionXTranslator(component.transform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToLocalPositionY(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new LocalPositionXTranslator(gameObject.transform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalPositionY(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new LocalPositionXTranslator(component.transform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalPositionY(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new LocalPositionXTranslator(gameObject.transform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalPositionY(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new LocalPositionXTranslator(component.transform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToLocalPositionZ(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new LocalPositionXTranslator(gameObject.transform, 2), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalPositionZ(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new LocalPositionXTranslator(component.transform, 2), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalPositionZ(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new LocalPositionXTranslator(gameObject.transform, 2), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalPositionZ(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new LocalPositionXTranslator(component.transform, 2), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToGlobalPosition(this IAnimator<Vector3> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new GlobalPositionTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPosition(this IAnimator<Vector3> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new GlobalPositionTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPosition(this IAnimator<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new GlobalPositionTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPosition(this IAnimator<Vector2> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new GlobalPositionTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPosition(this IAnimatorWithStartValue<Vector3> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new GlobalPositionTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPosition(this IAnimatorWithStartValue<Vector3> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new GlobalPositionTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPosition(this IAnimatorWithStartValue<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new GlobalPositionTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPosition(this IAnimatorWithStartValue<Vector2> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new GlobalPositionTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToGlobalPositionX(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new GlobalPositionXTranslator(gameObject.transform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPositionX(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new GlobalPositionXTranslator(component.transform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPositionX(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new GlobalPositionXTranslator(gameObject.transform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPositionX(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new GlobalPositionXTranslator(component.transform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToGlobalPositionY(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new GlobalPositionXTranslator(gameObject.transform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPositionY(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new GlobalPositionXTranslator(component.transform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPositionY(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new GlobalPositionXTranslator(gameObject.transform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPositionY(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new GlobalPositionXTranslator(component.transform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToGlobalPositionZ(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new GlobalPositionXTranslator(gameObject.transform, 2), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPositionZ(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new GlobalPositionXTranslator(component.transform, 2), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPositionZ(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new GlobalPositionXTranslator(gameObject.transform, 2), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalPositionZ(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new GlobalPositionXTranslator(component.transform, 2), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToLocalScale(this IAnimator<Vector3> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new LocalScaleTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScale(this IAnimator<Vector3> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new LocalScaleTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScale(this IAnimator<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new LocalScaleTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScale(this IAnimator<Vector2> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new LocalScaleTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScale(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new LocalScaleTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScale(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new LocalScaleTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScale(this IAnimatorWithStartValue<Vector3> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new LocalScaleTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScale(this IAnimatorWithStartValue<Vector3> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new LocalScaleTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScale(this IAnimatorWithStartValue<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new LocalScaleTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScale(this IAnimatorWithStartValue<Vector2> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new LocalScaleTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScale(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new LocalScaleTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScale(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new LocalScaleTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToLocalScaleX(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new LocalScaleXTranslator(gameObject.transform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScaleX(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new LocalScaleXTranslator(component.transform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScaleX(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new LocalScaleXTranslator(gameObject.transform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScaleX(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new LocalScaleXTranslator(component.transform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToLocalScaleY(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new LocalScaleXTranslator(gameObject.transform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScaleY(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new LocalScaleXTranslator(component.transform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScaleY(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new LocalScaleXTranslator(gameObject.transform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScaleY(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new LocalScaleXTranslator(component.transform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToLocalScaleZ(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new LocalScaleXTranslator(gameObject.transform, 2), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScaleZ(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new LocalScaleXTranslator(component.transform, 2), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScaleZ(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new LocalScaleXTranslator(gameObject.transform, 2), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalScaleZ(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new LocalScaleXTranslator(component.transform, 2), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToLocalRotation(this IAnimator<Quaternion> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new LocalRotationTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalRotation(this IAnimator<Quaternion> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new LocalRotationTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalRotation(this IAnimatorWithStartValue<Quaternion> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new LocalRotationTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToLocalRotation(this IAnimatorWithStartValue<Quaternion> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new LocalRotationTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalRotation(this IAnimator<Quaternion> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new GlobalRotationTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalRotation(this IAnimator<Quaternion> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.Play(animator, new GlobalRotationTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalRotation(this IAnimatorWithStartValue<Quaternion> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new GlobalRotationTranslator(gameObject.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
        
        [MustUseReturnValue]
        public static UniTask ToGlobalRotation(this IAnimatorWithStartValue<Quaternion> animator, Component component, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(component);
            return Anime.PlayTo(animator, new GlobalRotationTranslator(component.transform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(component.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
    }

    public class LocalPositionTranslator : IValueTranslator<Vector3>, IValueTranslator<Vector2>
    {
        public bool Alive => transform != null;
        public Vector3 Current => transform.localPosition;

        Vector2 IValueTranslator<Vector2>.Current => Current;
        Vector3 IValueTranslator<Vector3>.Current => Current;

        private readonly Transform transform;

        public LocalPositionTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(Vector3 value)
        {
            transform.localPosition = value;
        }

        public void Update(Vector2 value)
        {
            transform.localPosition = value;
        }
    }

    public class LocalPositionXTranslator : IValueTranslator<float>
    {
        public bool Alive => transform != null;
        public float Current => transform.localPosition[Index];

        public int Index { get; }

        private readonly Transform transform;

        public LocalPositionXTranslator(Transform transform, int index)
        {
            Index = index;
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.localPosition;
            p[Index] = value;
            transform.localPosition = p;
        }
    }

    public class GlobalPositionTranslator : IValueTranslator<Vector3>, IValueTranslator<Vector2>
    {
        public bool Alive => transform != null;
        public Vector3 Current => transform.position;

        Vector2 IValueTranslator<Vector2>.Current => Current;
        Vector3 IValueTranslator<Vector3>.Current => Current;

        private readonly Transform transform;

        public GlobalPositionTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(Vector3 value)
        {
            transform.position = value;
        }


        public void Update(Vector2 value)
        {
            transform.position = value;
        }
    }

    public class GlobalPositionXTranslator : IValueTranslator<float>
    {
        public bool Alive => transform != null;
        public float Current => transform.position[Index];

        public int Index { get; }

        private readonly Transform transform;

        public GlobalPositionXTranslator(Transform transform, int index)
        {
            Index = index;
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.position;
            p[Index] = value;
            transform.position = p;
        }
    }

    public class LocalScaleTranslator : IValueTranslator<Vector3>, IValueTranslator<Vector2>, IValueTranslator<float>
    {
        public bool Alive => transform != null;
        public Vector3 Current => transform.localScale;

        Vector3 IValueTranslator<Vector3>.Current => Current;
        Vector2 IValueTranslator<Vector2>.Current => Current;
        float IValueTranslator<float>.Current => (Current.x + Current.y + Current.z) / 3f;

        private readonly Transform transform;

        public LocalScaleTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(Vector3 value)
        {
            transform.localScale = value;
        }

        public void Update(Vector2 value)
        {
            transform.localScale = value;
        }

        public void Update(float value)
        {
            transform.localScale = Vector3.one * value;
        }
    }

    public class LocalScaleXTranslator : IValueTranslator<float>
    {
        public bool Alive => transform != null;
        public float Current => transform.localScale[Index];

        public int Index { get; }

        private readonly Transform transform;

        public LocalScaleXTranslator(Transform transform, int index)
        {
            Index = index;
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.localScale;
            p[Index] = value;
            transform.localScale = p;
        }
    }

    public class LocalRotationTranslator : IValueTranslator<Quaternion>
    {
        public bool Alive => transform != null;
        public Quaternion Current => transform.localRotation;

        private readonly Transform transform;

        public LocalRotationTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(Quaternion value)
        {
            transform.localRotation = value;
        }
    }

    public class GlobalRotationTranslator : IValueTranslator<Quaternion>
    {
        public bool Alive => transform != null;
        public Quaternion Current => transform.rotation;

        private readonly Transform transform;

        public GlobalRotationTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(Quaternion value)
        {
            transform.rotation = value;
        }
    }
}

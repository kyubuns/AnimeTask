#if ANIMETASK_UGUI_SUPPORT
using System.Threading;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        [MustUseReturnValue]
        public static UniTask ToAnchoredPosition(this IAnimator<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new AnchoredPositionTranslator(gameObject.GetComponent<RectTransform>()), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPosition(this IAnimator<Vector2> animator, RectTransform rectTransform, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(rectTransform);
            return Anime.Play(animator, new AnchoredPositionTranslator(rectTransform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(rectTransform.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPosition(this IAnimator<Vector2> animator, Graphic graphic, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(graphic);
            return Anime.Play(animator, new AnchoredPositionTranslator(graphic.rectTransform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPosition(this IAnimatorWithStartValue<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new AnchoredPositionTranslator(gameObject.GetComponent<RectTransform>()), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPosition(this IAnimatorWithStartValue<Vector2> animator, RectTransform rectTransform, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(rectTransform);
            return Anime.PlayTo(animator, new AnchoredPositionTranslator(rectTransform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(rectTransform.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPosition(this IAnimatorWithStartValue<Vector2> animator, Graphic graphic, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(graphic);
            return Anime.PlayTo(animator, new AnchoredPositionTranslator(graphic.rectTransform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPositionX(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new AnchoredPositionXTranslator(gameObject.GetComponent<RectTransform>(), 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPositionX(this IAnimator<float> animator, RectTransform rectTransform, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(rectTransform);
            return Anime.Play(animator, new AnchoredPositionXTranslator(rectTransform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(rectTransform.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPositionX(this IAnimator<float> animator, Graphic graphic, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(graphic);
            return Anime.Play(animator, new AnchoredPositionXTranslator(graphic.rectTransform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPositionX(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new AnchoredPositionXTranslator(gameObject.GetComponent<RectTransform>(), 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPositionX(this IAnimatorWithStartValue<float> animator, RectTransform rectTransform, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(rectTransform);
            return Anime.PlayTo(animator, new AnchoredPositionXTranslator(rectTransform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(rectTransform.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPositionX(this IAnimatorWithStartValue<float> animator, Graphic graphic, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(graphic);
            return Anime.PlayTo(animator, new AnchoredPositionXTranslator(graphic.rectTransform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPositionY(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new AnchoredPositionXTranslator(gameObject.GetComponent<RectTransform>(), 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPositionY(this IAnimator<float> animator, RectTransform rectTransform, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(rectTransform);
            return Anime.Play(animator, new AnchoredPositionXTranslator(rectTransform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(rectTransform.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPositionY(this IAnimator<float> animator, Graphic graphic, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(graphic);
            return Anime.Play(animator, new AnchoredPositionXTranslator(graphic.rectTransform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPositionY(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new AnchoredPositionXTranslator(gameObject.GetComponent<RectTransform>(), 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPositionY(this IAnimatorWithStartValue<float> animator, RectTransform rectTransform, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(rectTransform);
            return Anime.PlayTo(animator, new AnchoredPositionXTranslator(rectTransform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(rectTransform.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToAnchoredPositionY(this IAnimatorWithStartValue<float> animator, Graphic graphic, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(graphic);
            return Anime.PlayTo(animator, new AnchoredPositionXTranslator(graphic.rectTransform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDelta(this IAnimator<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new SizeDeltaTranslator(gameObject.GetComponent<RectTransform>()), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDelta(this IAnimator<Vector2> animator, RectTransform rectTransform, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(rectTransform);
            return Anime.Play(animator, new SizeDeltaTranslator(rectTransform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(rectTransform.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDelta(this IAnimator<Vector2> animator, Graphic graphic, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(graphic);
            return Anime.Play(animator, new SizeDeltaTranslator(graphic.rectTransform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDelta(this IAnimatorWithStartValue<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new SizeDeltaTranslator(gameObject.GetComponent<RectTransform>()), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDelta(this IAnimatorWithStartValue<Vector2> animator, RectTransform rectTransform, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(rectTransform);
            return Anime.PlayTo(animator, new SizeDeltaTranslator(rectTransform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(rectTransform.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDelta(this IAnimatorWithStartValue<Vector2> animator, Graphic graphic, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(graphic);
            return Anime.PlayTo(animator, new SizeDeltaTranslator(graphic.rectTransform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDeltaX(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new SizeDeltaXTranslator(gameObject.GetComponent<RectTransform>(), 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDeltaX(this IAnimator<float> animator, RectTransform rectTransform, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(rectTransform);
            return Anime.Play(animator, new SizeDeltaXTranslator(rectTransform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(rectTransform.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDeltaX(this IAnimator<float> animator, Graphic graphic, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(graphic);
            return Anime.Play(animator, new SizeDeltaXTranslator(graphic.rectTransform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDeltaX(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new SizeDeltaXTranslator(gameObject.GetComponent<RectTransform>(), 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDeltaX(this IAnimatorWithStartValue<float> animator, RectTransform rectTransform, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(rectTransform);
            return Anime.PlayTo(animator, new SizeDeltaXTranslator(rectTransform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(rectTransform.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDeltaX(this IAnimatorWithStartValue<float> animator, Graphic graphic, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(graphic);
            return Anime.PlayTo(animator, new SizeDeltaXTranslator(graphic.rectTransform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDeltaY(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.Play(animator, new SizeDeltaXTranslator(gameObject.GetComponent<RectTransform>(), 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDeltaY(this IAnimator<float> animator, RectTransform rectTransform, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(rectTransform);
            return Anime.Play(animator, new SizeDeltaXTranslator(rectTransform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(rectTransform.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDeltaY(this IAnimator<float> animator, Graphic graphic, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(graphic);
            return Anime.Play(animator, new SizeDeltaXTranslator(graphic.rectTransform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDeltaY(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(gameObject);
            return Anime.PlayTo(animator, new SizeDeltaXTranslator(gameObject.GetComponent<RectTransform>(), 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDeltaY(this IAnimatorWithStartValue<float> animator, RectTransform rectTransform, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(rectTransform);
            return Anime.PlayTo(animator, new SizeDeltaXTranslator(rectTransform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(rectTransform.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }

        [MustUseReturnValue]
        public static UniTask ToSizeDeltaY(this IAnimatorWithStartValue<float> animator, Graphic graphic, CancellationToken cancellationToken = default, SkipToken skipToken = default, IScheduler scheduler = default)
        {
            CheckAlive(graphic);
            return Anime.PlayTo(animator, new SizeDeltaXTranslator(graphic.rectTransform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token, skipToken);
        }
    }

    public class AnchoredPositionTranslator : IValueTranslator<Vector2>
    {
        public bool Alive => transform != null;
        public Vector2 Current => transform.anchoredPosition;

        private readonly RectTransform transform;

        public AnchoredPositionTranslator(RectTransform transform)
        {
            this.transform = transform;
        }

        public void Update(Vector2 value)
        {
            transform.anchoredPosition = value;
        }
    }

    public class AnchoredPositionXTranslator : IValueTranslator<float>
    {
        public bool Alive => transform != null;
        public float Current => transform.localPosition[Index];

        public int Index { get; }

        private readonly RectTransform transform;

        public AnchoredPositionXTranslator(RectTransform transform, int index)
        {
            Index = index;
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.anchoredPosition;
            p[Index] = value;
            transform.anchoredPosition = p;
        }
    }

    public class SizeDeltaTranslator : IValueTranslator<Vector2>
    {
        public bool Alive => transform != null;
        public Vector2 Current => transform.sizeDelta;

        private readonly RectTransform transform;

        public SizeDeltaTranslator(RectTransform transform)
        {
            this.transform = transform;
        }

        public void Update(Vector2 value)
        {
            transform.sizeDelta = value;
        }
    }

    public class SizeDeltaXTranslator : IValueTranslator<float>
    {
        public bool Alive => transform != null;
        public float Current => transform.sizeDelta[Index];

        public int Index { get; }

        private readonly RectTransform transform;

        public SizeDeltaXTranslator(RectTransform transform, int index)
        {
            Index = index;
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.sizeDelta;
            p[Index] = value;
            transform.sizeDelta = p;
        }
    }
}
#endif

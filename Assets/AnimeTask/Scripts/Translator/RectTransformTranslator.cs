using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static UniTask ToAnchoredPosition(this IAnimator<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, new AnchoredPositionTranslator(gameObject.GetComponent<RectTransform>()), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token);
        public static UniTask ToAnchoredPosition(this IAnimator<Vector2> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, new AnchoredPositionTranslator(graphic.rectTransform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token);
        public static UniTask ToAnchoredPosition(this IAnimatorWithStartValue<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, new AnchoredPositionTranslator(gameObject.GetComponent<RectTransform>()), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token);
        public static UniTask ToAnchoredPosition(this IAnimatorWithStartValue<Vector2> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, new AnchoredPositionTranslator(graphic.rectTransform), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token);

        public static UniTask ToAnchoredPositionX(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, new AnchoredPositionXTranslator(gameObject.GetComponent<RectTransform>(), 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token);
        public static UniTask ToAnchoredPositionX(this IAnimator<float> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, new AnchoredPositionXTranslator(graphic.rectTransform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token);
        public static UniTask ToAnchoredPositionX(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, new AnchoredPositionXTranslator(gameObject.GetComponent<RectTransform>(), 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token);
        public static UniTask ToAnchoredPositionX(this IAnimatorWithStartValue<float> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, new AnchoredPositionXTranslator(graphic.rectTransform, 0), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token);

        public static UniTask ToAnchoredPositionY(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, new AnchoredPositionXTranslator(gameObject.GetComponent<RectTransform>(), 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token);
        public static UniTask ToAnchoredPositionY(this IAnimator<float> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, new AnchoredPositionXTranslator(graphic.rectTransform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token);
        public static UniTask ToAnchoredPositionY(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, new AnchoredPositionXTranslator(gameObject.GetComponent<RectTransform>(), 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(gameObject.GetCancellationTokenOnDestroy(), cancellationToken).Token);
        public static UniTask ToAnchoredPositionY(this IAnimatorWithStartValue<float> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, new AnchoredPositionXTranslator(graphic.rectTransform, 1), scheduler, CancellationTokenSource.CreateLinkedTokenSource(graphic.GetCancellationTokenOnDestroy(), cancellationToken).Token);
    }

    public class AnchoredPositionTranslator : IValueTranslator<Vector2>
    {
        private readonly RectTransform transform;
        public Vector2 Current => transform.anchoredPosition;

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
        public int Index { get; }

        private readonly RectTransform transform;
        public float Current => transform.localPosition[Index];

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
}
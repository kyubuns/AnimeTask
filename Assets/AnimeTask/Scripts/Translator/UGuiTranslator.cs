using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static TextTranslator Text(Text text, string format) => new TextTranslator(text, format);
        public static UniTask ToText(this IAnimator<float> animator, Text text, string format, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, Text(text, format), scheduler, cancellationToken);

        public static ColorTranslator Color(Graphic graphic) => new ColorTranslator(graphic);
        public static UniTask ToColor(this IAnimator<Color> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, Color(graphic), scheduler, cancellationToken);
        public static UniTask ToColor(this IAnimatorWithStartValue<Color> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, Color(graphic), scheduler, cancellationToken);

        public static ColorXTranslator ColorR(Graphic graphic) => new ColorXTranslator(graphic, 0);
        public static UniTask ToColorR(this IAnimator<float> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, ColorR(graphic), scheduler, cancellationToken);
        public static UniTask ToColorR(this IAnimatorWithStartValue<float> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, ColorR(graphic), scheduler, cancellationToken);

        public static ColorXTranslator ColorG(Graphic graphic) => new ColorXTranslator(graphic, 1);
        public static UniTask ToColorG(this IAnimator<float> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, ColorG(graphic), scheduler, cancellationToken);
        public static UniTask ToColorG(this IAnimatorWithStartValue<float> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, ColorG(graphic), scheduler, cancellationToken);

        public static ColorXTranslator ColorB(Graphic graphic) => new ColorXTranslator(graphic, 2);
        public static UniTask ToColorB(this IAnimator<float> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, ColorB(graphic), scheduler, cancellationToken);
        public static UniTask ToColorB(this IAnimatorWithStartValue<float> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, ColorB(graphic), scheduler, cancellationToken);

        public static ColorXTranslator ColorA(Graphic graphic) => new ColorXTranslator(graphic, 3);
        public static UniTask ToColorA(this IAnimator<float> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.Play(animator, ColorA(graphic), scheduler, cancellationToken);
        public static UniTask ToColorA(this IAnimatorWithStartValue<float> animator, Graphic graphic, CancellationToken cancellationToken = default, IScheduler scheduler = default) => Anime.PlayTo(animator, ColorA(graphic), scheduler, cancellationToken);
    }

    public class TextTranslator : ITranslator<float>
    {
        private readonly Text text;
        private readonly string format;

        public TextTranslator(Text text, string format)
        {
            this.text = text;
            this.format = format;
        }

        public void Update(float value)
        {
            text.text = string.Format(format, value);
        }
    }

    public class ColorTranslator : IValueTranslator<Color>
    {
        public Color Current => graphic.color;
        private readonly Graphic graphic;

        public ColorTranslator(Graphic graphic)
        {
            this.graphic = graphic;
        }

        public void Update(Color value)
        {
            graphic.color = value;
        }
    }

    public class ColorXTranslator : IValueTranslator<float>
    {
        public int Index { get; }
        public float Current => graphic.color[Index];
        private readonly Graphic graphic;

        public ColorXTranslator(Graphic graphic, int index)
        {
            Index = index;
            this.graphic = graphic;
        }

        public void Update(float value)
        {
            var c = graphic.color;
            c[Index] = value;
            graphic.color = c;
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static TextTranslator Text(Text text, string format) => new TextTranslator(text, format);
        public static ColorTranslator Color(Graphic graphic) => new ColorTranslator(graphic);
        public static ColorXTranslator ColorR(Graphic graphic) => new ColorXTranslator(graphic, 0);
        public static ColorXTranslator ColorG(Graphic graphic) => new ColorXTranslator(graphic, 1);
        public static ColorXTranslator ColorB(Graphic graphic) => new ColorXTranslator(graphic, 2);
        public static ColorXTranslator ColorA(Graphic graphic) => new ColorXTranslator(graphic, 3);
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

using UnityEngine;
using UnityEngine.UI;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static TextTranslator Text(Text text, string format) => new TextTranslator(text, format);
        public static ColorTranslator Color(Graphic graphic) => new ColorTranslator(graphic);
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
}

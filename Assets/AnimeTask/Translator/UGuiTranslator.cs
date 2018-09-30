using UnityEngine.UI;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static TextTranslator Text(Text text, string format) => new TextTranslator(text, format);
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
}

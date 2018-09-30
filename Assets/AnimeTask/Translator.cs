using UnityEngine;
using UnityEngine.UI;

namespace AnimeTask
{
    public interface ITranslator<in T>
    {
        void Update(T value);
    }

    public static class TranslateTo
    {
        public static LocalPositionTranslator LocalPosition(Transform transform) => new LocalPositionTranslator(transform);
        public static TextTranslator Text(Text text, string format) => new TextTranslator(text, format);
    }

    public class LocalPositionTranslator : ITranslator<Vector3>
    {
        private readonly Transform transform;

        public LocalPositionTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(Vector3 value)
        {
            transform.localPosition = value;
        }
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

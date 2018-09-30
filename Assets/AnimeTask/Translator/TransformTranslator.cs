using UnityEngine;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static LocalPositionTranslator LocalPosition(Transform transform) => new LocalPositionTranslator(transform);
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
}

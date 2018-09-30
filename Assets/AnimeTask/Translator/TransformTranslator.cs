using UnityEngine;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static LocalPositionTranslator LocalPosition(Transform transform) => new LocalPositionTranslator(transform);
        public static LocalPositionXTranslator LocalPositionX(Transform transform) => new LocalPositionXTranslator(transform);
        public static LocalPositionYTranslator LocalPositionY(Transform transform) => new LocalPositionYTranslator(transform);
        public static LocalPositionZTranslator LocalPositionZ(Transform transform) => new LocalPositionZTranslator(transform);
        public static GlobalPositionTranslator GlobalPosition(Transform transform) => new GlobalPositionTranslator(transform);
        public static GlobalPositionXTranslator GlobalPositionX(Transform transform) => new GlobalPositionXTranslator(transform);
        public static GlobalPositionYTranslator GlobalPositionY(Transform transform) => new GlobalPositionYTranslator(transform);
        public static GlobalPositionZTranslator GlobalPositionZ(Transform transform) => new GlobalPositionZTranslator(transform);
        public static LocalScaleTranslator LocalScale(Transform transform) => new LocalScaleTranslator(transform);
        public static LocalScaleXTranslator LocalScaleX(Transform transform) => new LocalScaleXTranslator(transform);
        public static LocalScaleYTranslator LocalScaleY(Transform transform) => new LocalScaleYTranslator(transform);
        public static LocalScaleZTranslator LocalScaleZ(Transform transform) => new LocalScaleZTranslator(transform);
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

    public class LocalPositionXTranslator : ITranslator<float>
    {
        private readonly Transform transform;

        public LocalPositionXTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.localPosition;
            p.x = value;
            transform.localPosition = p;
        }
    }

    public class LocalPositionYTranslator : ITranslator<float>
    {
        private readonly Transform transform;

        public LocalPositionYTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.localPosition;
            p.y = value;
            transform.localPosition = p;
        }
    }

    public class LocalPositionZTranslator : ITranslator<float>
    {
        private readonly Transform transform;

        public LocalPositionZTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.localPosition;
            p.z = value;
            transform.localPosition = p;
        }
    }

    public class GlobalPositionTranslator : ITranslator<Vector3>
    {
        private readonly Transform transform;

        public GlobalPositionTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(Vector3 value)
        {
            transform.position = value;
        }
    }

    public class GlobalPositionXTranslator : ITranslator<float>
    {
        private readonly Transform transform;

        public GlobalPositionXTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.position;
            p.x = value;
            transform.position = p;
        }
    }

    public class GlobalPositionYTranslator : ITranslator<float>
    {
        private readonly Transform transform;

        public GlobalPositionYTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.position;
            p.y = value;
            transform.position = p;
        }
    }

    public class GlobalPositionZTranslator : ITranslator<float>
    {
        private readonly Transform transform;

        public GlobalPositionZTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.position;
            p.z = value;
            transform.position = p;
        }
    }

    public class LocalScaleTranslator : ITranslator<Vector3>
    {
        private readonly Transform transform;

        public LocalScaleTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(Vector3 value)
        {
            transform.localScale = value;
        }
    }

    public class LocalScaleXTranslator : ITranslator<float>
    {
        private readonly Transform transform;

        public LocalScaleXTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.localScale;
            p.x = value;
            transform.localScale = p;
        }
    }

    public class LocalScaleYTranslator : ITranslator<float>
    {
        private readonly Transform transform;

        public LocalScaleYTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.localScale;
            p.y = value;
            transform.localScale = p;
        }
    }

    public class LocalScaleZTranslator : ITranslator<float>
    {
        private readonly Transform transform;

        public LocalScaleZTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.localScale;
            p.z = value;
            transform.localScale = p;
        }
    }
}

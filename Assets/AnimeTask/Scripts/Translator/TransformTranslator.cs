using UnityEngine;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static LocalPositionTranslator LocalPosition(Transform transform) => new LocalPositionTranslator(transform);
        public static LocalPositionTranslator LocalPosition(GameObject gameObject) => new LocalPositionTranslator(gameObject.transform);
        public static LocalPositionXTranslator LocalPositionX(Transform transform) => new LocalPositionXTranslator(transform);
        public static LocalPositionXTranslator LocalPositionX(GameObject gameObject) => new LocalPositionXTranslator(gameObject.transform);
        public static LocalPositionYTranslator LocalPositionY(Transform transform) => new LocalPositionYTranslator(transform);
        public static LocalPositionYTranslator LocalPositionY(GameObject gameObject) => new LocalPositionYTranslator(gameObject.transform);
        public static LocalPositionZTranslator LocalPositionZ(Transform transform) => new LocalPositionZTranslator(transform);
        public static LocalPositionZTranslator LocalPositionZ(GameObject gameObject) => new LocalPositionZTranslator(gameObject.transform);
        public static GlobalPositionTranslator GlobalPosition(Transform transform) => new GlobalPositionTranslator(transform);
        public static GlobalPositionTranslator GlobalPosition(GameObject gameObject) => new GlobalPositionTranslator(gameObject.transform);
        public static GlobalPositionXTranslator GlobalPositionX(Transform transform) => new GlobalPositionXTranslator(transform);
        public static GlobalPositionXTranslator GlobalPositionX(GameObject gameObject) => new GlobalPositionXTranslator(gameObject.transform);
        public static GlobalPositionYTranslator GlobalPositionY(Transform transform) => new GlobalPositionYTranslator(transform);
        public static GlobalPositionYTranslator GlobalPositionY(GameObject gameObject) => new GlobalPositionYTranslator(gameObject.transform);
        public static GlobalPositionZTranslator GlobalPositionZ(Transform transform) => new GlobalPositionZTranslator(transform);
        public static GlobalPositionZTranslator GlobalPositionZ(GameObject gameObject) => new GlobalPositionZTranslator(gameObject.transform);
        public static LocalScaleTranslator LocalScale(Transform transform) => new LocalScaleTranslator(transform);
        public static LocalScaleTranslator LocalScale(GameObject gameObject) => new LocalScaleTranslator(gameObject.transform);
        public static LocalScaleXTranslator LocalScaleX(Transform transform) => new LocalScaleXTranslator(transform);
        public static LocalScaleXTranslator LocalScaleX(GameObject gameObject) => new LocalScaleXTranslator(gameObject.transform);
        public static LocalScaleYTranslator LocalScaleY(Transform transform) => new LocalScaleYTranslator(transform);
        public static LocalScaleYTranslator LocalScaleY(GameObject gameObject) => new LocalScaleYTranslator(gameObject.transform);
        public static LocalScaleZTranslator LocalScaleZ(Transform transform) => new LocalScaleZTranslator(transform);
        public static LocalScaleZTranslator LocalScaleZ(GameObject gameObject) => new LocalScaleZTranslator(gameObject.transform);
    }

    public class LocalPositionTranslator : IValueTranslator<Vector3>
    {
        public Vector3 Current => transform.localPosition;
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

    public class LocalPositionXTranslator : IValueTranslator<float>
    {
        public float Current => transform.localPosition.x;
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

    public class LocalPositionYTranslator : IValueTranslator<float>
    {
        public float Current => transform.localPosition.y;
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

    public class LocalPositionZTranslator : IValueTranslator<float>
    {
        public float Current => transform.localPosition.z;
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

    public class GlobalPositionTranslator : IValueTranslator<Vector3>
    {
        public Vector3 Current => transform.position;
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

    public class GlobalPositionXTranslator : IValueTranslator<float>
    {
        public float Current => transform.position.x;
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

    public class GlobalPositionYTranslator : IValueTranslator<float>
    {
        public float Current => transform.position.y;
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

    public class GlobalPositionZTranslator : IValueTranslator<float>
    {
        public float Current => transform.position.z;
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

    public class LocalScaleTranslator : IValueTranslator<Vector3>
    {
        public Vector3 Current => transform.localScale;
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

    public class LocalScaleXTranslator : IValueTranslator<float>
    {
        public float Current => transform.localScale.x;
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

    public class LocalScaleYTranslator : IValueTranslator<float>
    {
        public float Current => transform.localScale.y;
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

    public class LocalScaleZTranslator : IValueTranslator<float>
    {
        public float Current => transform.localScale.z;
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

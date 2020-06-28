using UnityEngine;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static LocalPositionTranslator LocalPosition(Transform transform) => new LocalPositionTranslator(transform);
        public static LocalPositionTranslator LocalPosition(GameObject gameObject) => new LocalPositionTranslator(gameObject.transform);
        public static LocalPositionTranslator LocalPosition(Component component) => new LocalPositionTranslator(component.transform);
        public static LocalPositionXTranslator LocalPositionX(Transform transform) => new LocalPositionXTranslator(transform, 0);
        public static LocalPositionXTranslator LocalPositionX(GameObject gameObject) => new LocalPositionXTranslator(gameObject.transform, 0);
        public static LocalPositionXTranslator LocalPositionX(Component component) => new LocalPositionXTranslator(component.transform, 0);
        public static LocalPositionXTranslator LocalPositionY(Transform transform) => new LocalPositionXTranslator(transform, 1);
        public static LocalPositionXTranslator LocalPositionY(GameObject gameObject) => new LocalPositionXTranslator(gameObject.transform, 1);
        public static LocalPositionXTranslator LocalPositionY(Component component) => new LocalPositionXTranslator(component.transform, 1);
        public static LocalPositionXTranslator LocalPositionZ(Transform transform) => new LocalPositionXTranslator(transform, 2);
        public static LocalPositionXTranslator LocalPositionZ(GameObject gameObject) => new LocalPositionXTranslator(gameObject.transform, 2);
        public static LocalPositionXTranslator LocalPositionZ(Component component) => new LocalPositionXTranslator(component.transform, 2);
        public static GlobalPositionTranslator GlobalPosition(Transform transform) => new GlobalPositionTranslator(transform);
        public static GlobalPositionTranslator GlobalPosition(GameObject gameObject) => new GlobalPositionTranslator(gameObject.transform);
        public static GlobalPositionTranslator GlobalPosition(Component component) => new GlobalPositionTranslator(component.transform);
        public static GlobalPositionXTranslator GlobalPositionX(Transform transform) => new GlobalPositionXTranslator(transform, 0);
        public static GlobalPositionXTranslator GlobalPositionX(GameObject gameObject) => new GlobalPositionXTranslator(gameObject.transform, 0);
        public static GlobalPositionXTranslator GlobalPositionX(Component component) => new GlobalPositionXTranslator(component.transform, 0);
        public static GlobalPositionXTranslator GlobalPositionY(Transform transform) => new GlobalPositionXTranslator(transform, 1);
        public static GlobalPositionXTranslator GlobalPositionY(GameObject gameObject) => new GlobalPositionXTranslator(gameObject.transform, 1);
        public static GlobalPositionXTranslator GlobalPositionY(Component component) => new GlobalPositionXTranslator(component.transform, 1);
        public static GlobalPositionXTranslator GlobalPositionZ(Transform transform) => new GlobalPositionXTranslator(transform, 2);
        public static GlobalPositionXTranslator GlobalPositionZ(GameObject gameObject) => new GlobalPositionXTranslator(gameObject.transform, 2);
        public static GlobalPositionXTranslator GlobalPositionZ(Component component) => new GlobalPositionXTranslator(component.transform, 2);
        public static LocalScaleTranslator LocalScale(Transform transform) => new LocalScaleTranslator(transform);
        public static LocalScaleTranslator LocalScale(GameObject gameObject) => new LocalScaleTranslator(gameObject.transform);
        public static LocalScaleTranslator LocalScale(Component component) => new LocalScaleTranslator(component.transform);
        public static LocalScaleXTranslator LocalScaleX(Transform transform) => new LocalScaleXTranslator(transform, 0);
        public static LocalScaleXTranslator LocalScaleX(GameObject gameObject) => new LocalScaleXTranslator(gameObject.transform, 0);
        public static LocalScaleXTranslator LocalScaleX(Component component) => new LocalScaleXTranslator(component.transform, 0);
        public static LocalScaleXTranslator LocalScaleY(Transform transform) => new LocalScaleXTranslator(transform, 1);
        public static LocalScaleXTranslator LocalScaleY(GameObject gameObject) => new LocalScaleXTranslator(gameObject.transform, 1);
        public static LocalScaleXTranslator LocalScaleY(Component component) => new LocalScaleXTranslator(component.transform, 1);
        public static LocalScaleXTranslator LocalScaleZ(Transform transform) => new LocalScaleXTranslator(transform, 2);
        public static LocalScaleXTranslator LocalScaleZ(GameObject gameObject) => new LocalScaleXTranslator(gameObject.transform, 2);
        public static LocalScaleXTranslator LocalScaleZ(Component component) => new LocalScaleXTranslator(component.transform, 2);
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
        public int Index { get; }
        public float Current => transform.localPosition[Index];
        private readonly Transform transform;

        public LocalPositionXTranslator(Transform transform, int index)
        {
            Index = index;
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.localPosition;
            p[Index] = value;
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
        public int Index { get; }
        public float Current => transform.position[Index];
        private readonly Transform transform;

        public GlobalPositionXTranslator(Transform transform, int index)
        {
            Index = index;
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.position;
            p[Index] = value;
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
        public int Index { get; }
        public float Current => transform.localScale[Index];
        private readonly Transform transform;

        public LocalScaleXTranslator(Transform transform, int index)
        {
            Index = index;
            this.transform = transform;
        }

        public void Update(float value)
        {
            var p = transform.localScale;
            p[Index] = value;
            transform.localScale = p;
        }
    }
}

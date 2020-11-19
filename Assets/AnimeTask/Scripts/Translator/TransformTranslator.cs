using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static LocalPositionTranslator LocalPosition(GameObject gameObject) => new LocalPositionTranslator(gameObject.transform);
        public static LocalPositionTranslator LocalPosition(Component component) => new LocalPositionTranslator(component.transform);
        public static UniTask ToLocalPosition(this IAnimator<Vector3> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalPosition(gameObject), cancellationToken);
        public static UniTask ToLocalPosition(this IAnimator<Vector3> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalPosition(component), cancellationToken);
        public static UniTask ToLocalPosition(this IAnimator<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalPosition(gameObject), cancellationToken);
        public static UniTask ToLocalPosition(this IAnimator<Vector2> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalPosition(component), cancellationToken);
        public static UniTask ToLocalPosition(this IAnimatorWithStartValue<Vector3> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalPosition(gameObject), cancellationToken);
        public static UniTask ToLocalPosition(this IAnimatorWithStartValue<Vector3> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalPosition(component), cancellationToken);
        public static UniTask ToLocalPosition(this IAnimatorWithStartValue<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalPosition(gameObject), cancellationToken);
        public static UniTask ToLocalPosition(this IAnimatorWithStartValue<Vector2> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalPosition(component), cancellationToken);

        public static LocalPositionXTranslator LocalPositionX(GameObject gameObject) => new LocalPositionXTranslator(gameObject.transform, 0);
        public static LocalPositionXTranslator LocalPositionX(Component component) => new LocalPositionXTranslator(component.transform, 0);
        public static UniTask ToLocalPositionX(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalPositionX(gameObject), cancellationToken);
        public static UniTask ToLocalPositionX(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalPositionX(component), cancellationToken);
        public static UniTask ToLocalPositionX(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalPositionX(gameObject), cancellationToken);
        public static UniTask ToLocalPositionX(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalPositionX(component), cancellationToken);

        public static LocalPositionXTranslator LocalPositionY(GameObject gameObject) => new LocalPositionXTranslator(gameObject.transform, 1);
        public static LocalPositionXTranslator LocalPositionY(Component component) => new LocalPositionXTranslator(component.transform, 1);
        public static UniTask ToLocalPositionY(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalPositionY(gameObject), cancellationToken);
        public static UniTask ToLocalPositionY(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalPositionY(component), cancellationToken);
        public static UniTask ToLocalPositionY(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalPositionY(gameObject), cancellationToken);
        public static UniTask ToLocalPositionY(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalPositionY(component), cancellationToken);

        public static LocalPositionXTranslator LocalPositionZ(GameObject gameObject) => new LocalPositionXTranslator(gameObject.transform, 2);
        public static LocalPositionXTranslator LocalPositionZ(Component component) => new LocalPositionXTranslator(component.transform, 2);
        public static UniTask ToLocalPositionZ(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalPositionZ(gameObject), cancellationToken);
        public static UniTask ToLocalPositionZ(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalPositionZ(component), cancellationToken);
        public static UniTask ToLocalPositionZ(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalPositionZ(gameObject), cancellationToken);
        public static UniTask ToLocalPositionZ(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalPositionZ(component), cancellationToken);

        public static GlobalPositionTranslator GlobalPosition(GameObject gameObject) => new GlobalPositionTranslator(gameObject.transform);
        public static GlobalPositionTranslator GlobalPosition(Component component) => new GlobalPositionTranslator(component.transform);
        public static UniTask ToGlobalPosition(this IAnimator<Vector3> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, GlobalPosition(gameObject), cancellationToken);
        public static UniTask ToGlobalPosition(this IAnimator<Vector3> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, GlobalPosition(component), cancellationToken);
        public static UniTask ToGlobalPosition(this IAnimator<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, GlobalPosition(gameObject), cancellationToken);
        public static UniTask ToGlobalPosition(this IAnimator<Vector2> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, GlobalPosition(component), cancellationToken);
        public static UniTask ToGlobalPosition(this IAnimatorWithStartValue<Vector3> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, GlobalPosition(gameObject), cancellationToken);
        public static UniTask ToGlobalPosition(this IAnimatorWithStartValue<Vector3> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, GlobalPosition(component), cancellationToken);
        public static UniTask ToGlobalPosition(this IAnimatorWithStartValue<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, GlobalPosition(gameObject), cancellationToken);
        public static UniTask ToGlobalPosition(this IAnimatorWithStartValue<Vector2> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, GlobalPosition(component), cancellationToken);

        public static GlobalPositionXTranslator GlobalPositionX(GameObject gameObject) => new GlobalPositionXTranslator(gameObject.transform, 0);
        public static GlobalPositionXTranslator GlobalPositionX(Component component) => new GlobalPositionXTranslator(component.transform, 0);
        public static UniTask ToGlobalPositionX(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, GlobalPositionX(gameObject), cancellationToken);
        public static UniTask ToGlobalPositionX(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, GlobalPositionX(component), cancellationToken);
        public static UniTask ToGlobalPositionX(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, GlobalPositionX(gameObject), cancellationToken);
        public static UniTask ToGlobalPositionX(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, GlobalPositionX(component), cancellationToken);

        public static GlobalPositionXTranslator GlobalPositionY(GameObject gameObject) => new GlobalPositionXTranslator(gameObject.transform, 1);
        public static GlobalPositionXTranslator GlobalPositionY(Component component) => new GlobalPositionXTranslator(component.transform, 1);
        public static UniTask ToGlobalPositionY(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, GlobalPositionY(gameObject), cancellationToken);
        public static UniTask ToGlobalPositionY(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, GlobalPositionY(component), cancellationToken);
        public static UniTask ToGlobalPositionY(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, GlobalPositionY(gameObject), cancellationToken);
        public static UniTask ToGlobalPositionY(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, GlobalPositionY(component), cancellationToken);

        public static GlobalPositionXTranslator GlobalPositionZ(GameObject gameObject) => new GlobalPositionXTranslator(gameObject.transform, 2);
        public static GlobalPositionXTranslator GlobalPositionZ(Component component) => new GlobalPositionXTranslator(component.transform, 2);
        public static UniTask ToGlobalPositionZ(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, GlobalPositionZ(gameObject), cancellationToken);
        public static UniTask ToGlobalPositionZ(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, GlobalPositionZ(component), cancellationToken);
        public static UniTask ToGlobalPositionZ(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, GlobalPositionZ(gameObject), cancellationToken);
        public static UniTask ToGlobalPositionZ(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, GlobalPositionZ(component), cancellationToken);

        public static LocalScaleTranslator LocalScale(GameObject gameObject) => new LocalScaleTranslator(gameObject.transform);
        public static LocalScaleTranslator LocalScale(Component component) => new LocalScaleTranslator(component.transform);
        public static UniTask ToLocalScale(this IAnimator<Vector3> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalScale(gameObject), cancellationToken);
        public static UniTask ToLocalScale(this IAnimator<Vector3> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalScale(component), cancellationToken);
        public static UniTask ToLocalScale(this IAnimator<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalScale(gameObject), cancellationToken);
        public static UniTask ToLocalScale(this IAnimator<Vector2> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalScale(component), cancellationToken);
        public static UniTask ToLocalScale(this IAnimatorWithStartValue<Vector3> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalScale(gameObject), cancellationToken);
        public static UniTask ToLocalScale(this IAnimatorWithStartValue<Vector3> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalScale(component), cancellationToken);
        public static UniTask ToLocalScale(this IAnimatorWithStartValue<Vector2> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalScale(gameObject), cancellationToken);
        public static UniTask ToLocalScale(this IAnimatorWithStartValue<Vector2> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalScale(component), cancellationToken);

        public static LocalScaleXTranslator LocalScaleX(GameObject gameObject) => new LocalScaleXTranslator(gameObject.transform, 0);
        public static LocalScaleXTranslator LocalScaleX(Component component) => new LocalScaleXTranslator(component.transform, 0);
        public static UniTask ToLocalScaleX(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalScaleX(gameObject), cancellationToken);
        public static UniTask ToLocalScaleX(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalScaleX(component), cancellationToken);
        public static UniTask ToLocalScaleX(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalScaleX(gameObject), cancellationToken);
        public static UniTask ToLocalScaleX(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalScaleX(component), cancellationToken);

        public static LocalScaleXTranslator LocalScaleY(GameObject gameObject) => new LocalScaleXTranslator(gameObject.transform, 1);
        public static LocalScaleXTranslator LocalScaleY(Component component) => new LocalScaleXTranslator(component.transform, 1);
        public static UniTask ToLocalScaleY(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalScaleY(gameObject), cancellationToken);
        public static UniTask ToLocalScaleY(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalScaleY(component), cancellationToken);
        public static UniTask ToLocalScaleY(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalScaleY(gameObject), cancellationToken);
        public static UniTask ToLocalScaleY(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalScaleY(component), cancellationToken);

        public static LocalScaleXTranslator LocalScaleZ(GameObject gameObject) => new LocalScaleXTranslator(gameObject.transform, 2);
        public static LocalScaleXTranslator LocalScaleZ(Component component) => new LocalScaleXTranslator(component.transform, 2);
        public static UniTask ToLocalScaleZ(this IAnimator<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalScaleZ(gameObject), cancellationToken);
        public static UniTask ToLocalScaleZ(this IAnimator<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, LocalScaleZ(component), cancellationToken);
        public static UniTask ToLocalScaleZ(this IAnimatorWithStartValue<float> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalScaleZ(gameObject), cancellationToken);
        public static UniTask ToLocalScaleZ(this IAnimatorWithStartValue<float> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, LocalScaleZ(component), cancellationToken);

        public static GlobalRotationTranslator GlobalRotation(GameObject gameObject) => new GlobalRotationTranslator(gameObject.transform);
        public static GlobalRotationTranslator GlobalRotation(Component component) => new GlobalRotationTranslator(component.transform);
        public static UniTask ToGlobalRotation(this IAnimator<Quaternion> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.Play(animator, GlobalRotation(gameObject), cancellationToken);
        public static UniTask ToGlobalRotation(this IAnimator<Quaternion> animator, Component component, CancellationToken cancellationToken = default) => Anime.Play(animator, GlobalRotation(component), cancellationToken);
        public static UniTask ToGlobalRotation(this IAnimatorWithStartValue<Quaternion> animator, GameObject gameObject, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, GlobalRotation(gameObject), cancellationToken);
        public static UniTask ToGlobalRotation(this IAnimatorWithStartValue<Quaternion> animator, Component component, CancellationToken cancellationToken = default) => Anime.PlayTo(animator, GlobalRotation(component), cancellationToken);
    }

    public class LocalPositionTranslator : IValueTranslator<Vector3>, IValueTranslator<Vector2>
    {
        private readonly Transform transform;
        public Vector3 Current => transform.localPosition;

        Vector2 IValueTranslator<Vector2>.Current => transform.localPosition;
        Vector3 IValueTranslator<Vector3>.Current => transform.localPosition;

        public LocalPositionTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(Vector3 value)
        {
            transform.localPosition = value;
        }

        public void Update(Vector2 value)
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

    public class GlobalPositionTranslator : IValueTranslator<Vector3>, IValueTranslator<Vector2>
    {
        private readonly Transform transform;
        public Vector3 Current => transform.position;

        Vector2 IValueTranslator<Vector2>.Current => transform.position;
        Vector3 IValueTranslator<Vector3>.Current => transform.position;

        public GlobalPositionTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(Vector3 value)
        {
            transform.position = value;
        }


        public void Update(Vector2 value)
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

    public class LocalScaleTranslator : IValueTranslator<Vector3>, IValueTranslator<Vector2>
    {
        private readonly Transform transform;
        public Vector3 Current => transform.localScale;

        Vector3 IValueTranslator<Vector3>.Current => transform.localScale;
        Vector2 IValueTranslator<Vector2>.Current => transform.localScale;

        public LocalScaleTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(Vector3 value)
        {
            transform.localScale = value;
        }

        public void Update(Vector2 value)
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

    public class GlobalRotationTranslator : IValueTranslator<Quaternion>
    {
        private readonly Transform transform;
        public Quaternion Current => transform.rotation;

        Quaternion IValueTranslator<Quaternion>.Current => transform.rotation;

        public GlobalRotationTranslator(Transform transform)
        {
            this.transform = transform;
        }

        public void Update(Quaternion value)
        {
            transform.rotation = value;
        }
    }
}

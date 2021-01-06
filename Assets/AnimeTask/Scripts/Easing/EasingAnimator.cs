using System;
using UnityEngine;

namespace AnimeTask
{
    public static partial class Easing
    {
        public static Vector1EasingAnimator Create<T>(float duration) where T : IEasing, new()
        {
            return new Vector1EasingAnimator(new T(), 0f, 1f, duration);
        }

        public static Vector1EasingAnimator Create<T>(float start, float end, float duration) where T : IEasing, new()
        {
            return new Vector1EasingAnimator(new T(), start, end, duration);
        }

        public static Vector1EasingAnimatorWithStartValue Create<T>(float to, float duration) where T : IEasing, new()
        {
            return new Vector1EasingAnimatorWithStartValue(new T(), to, duration);
        }

        public static Vector2EasingAnimator Create<T>(Vector2 start, Vector2 end, float duration) where T : IEasing, new()
        {
            return new Vector2EasingAnimator(new T(), start, end, duration);
        }

        public static Vector2EasingAnimatorWithStartValue Create<T>(Vector2 to, float duration) where T : IEasing, new()
        {
            return new Vector2EasingAnimatorWithStartValue(new T(), to, duration);
        }

        public static Vector3EasingAnimator Create<T>(Vector3 start, Vector3 end, float duration) where T : IEasing, new()
        {
            return new Vector3EasingAnimator(new T(), start, end, duration);
        }

        public static Vector3EasingAnimatorWithStartValue Create<T>(Vector3 to, float duration) where T : IEasing, new()
        {
            return new Vector3EasingAnimatorWithStartValue(new T(), to, duration);
        }

        public static Vector4EasingAnimator Create<T>(Vector4 start, Vector4 end, float duration) where T : IEasing, new()
        {
            return new Vector4EasingAnimator(new T(), start, end, duration);
        }

        public static Vector4EasingAnimatorWithStartValue Create<T>(Vector4 to, float duration) where T : IEasing, new()
        {
            return new Vector4EasingAnimatorWithStartValue(new T(), to, duration);
        }

        public static QuaternionEasingAnimator Create<T>(Quaternion start, Quaternion end, float duration) where T : IEasing, new()
        {
            return new QuaternionEasingAnimator(new T(), start, end, duration);
        }

        public static QuaternionEasingAnimatorWithStartValue Create<T>(Quaternion to, float duration) where T : IEasing, new()
        {
            return new QuaternionEasingAnimatorWithStartValue(new T(), to, duration);
        }

        public static ColorEasingAnimator Create<T>(Color start, Color end, float duration) where T : IEasing, new()
        {
            return new ColorEasingAnimator(new T(), start, end, duration);
        }

        public static ColorEasingAnimatorWithStartValue Create<T>(Color to, float duration) where T : IEasing, new()
        {
            return new ColorEasingAnimatorWithStartValue(new T(), to, duration);
        }
    }

    public class Vector1EasingAnimator : IAnimator<float>
    {
        private readonly IEasing easing;
        private readonly float start;
        private readonly float end;
        private readonly float duration;

        public Vector1EasingAnimator(IEasing easing, float start, float end, float duration)
        {
            this.easing = easing;
            this.start = start;
            this.end = end;
            this.duration = duration;
        }

        public Tuple<float, bool> Update(float time)
        {
            var value = Mathf.LerpUnclamped(start, end, easing.Function(Mathf.Min(time / duration, 1.0f)));
            return Tuple.Create(value, time > duration);
        }
    }

    public class Vector1EasingAnimatorWithStartValue : IAnimatorWithStartValue<float>
    {
        private readonly IEasing easing;
        private readonly float to;
        private readonly float duration;

        public Vector1EasingAnimatorWithStartValue(IEasing easing, float to, float duration)
        {
            this.easing = easing;
            this.to = to;
            this.duration = duration;
        }

        public IAnimator<float> Start(float startValue)
        {
            return new Vector1EasingAnimator(easing, startValue, to, duration);
        }
    }

    public class Vector2EasingAnimator : IAnimator<Vector2>
    {
        private readonly IEasing easing;
        private readonly Vector2 start;
        private readonly Vector2 end;
        private readonly float duration;

        public Vector2EasingAnimator(IEasing easing, Vector2 start, Vector2 end, float duration)
        {
            this.easing = easing;
            this.start = start;
            this.end = end;
            this.duration = duration;
        }

        public Tuple<Vector2, bool> Update(float time)
        {
            var value = Vector2.LerpUnclamped(start, end, easing.Function(Mathf.Min(time / duration, 1.0f)));
            return Tuple.Create(value, time > duration);
        }
    }

    public class Vector2EasingAnimatorWithStartValue : IAnimatorWithStartValue<Vector2>
    {
        private readonly IEasing easing;
        private readonly Vector2 to;
        private readonly float duration;

        public Vector2EasingAnimatorWithStartValue(IEasing easing, Vector2 to, float duration)
        {
            this.easing = easing;
            this.to = to;
            this.duration = duration;
        }

        public IAnimator<Vector2> Start(Vector2 startValue)
        {
            return new Vector2EasingAnimator(easing, startValue, to, duration);
        }
    }

    public class Vector3EasingAnimator : IAnimator<Vector3>
    {
        private readonly IEasing easing;
        private readonly Vector3 start;
        private readonly Vector3 end;
        private readonly float duration;

        public Vector3EasingAnimator(IEasing easing, Vector3 start, Vector3 end, float duration)
        {
            this.easing = easing;
            this.start = start;
            this.end = end;
            this.duration = duration;
        }

        public Tuple<Vector3, bool> Update(float time)
        {
            var value = Vector3.LerpUnclamped(start, end, easing.Function(Mathf.Min(time / duration, 1.0f)));
            return Tuple.Create(value, time > duration);
        }
    }

    public class Vector3EasingAnimatorWithStartValue : IAnimatorWithStartValue<Vector3>
    {
        private readonly IEasing easing;
        private readonly Vector3 to;
        private readonly float duration;

        public Vector3EasingAnimatorWithStartValue(IEasing easing, Vector3 to, float duration)
        {
            this.easing = easing;
            this.to = to;
            this.duration = duration;
        }

        public IAnimator<Vector3> Start(Vector3 startValue)
        {
            return new Vector3EasingAnimator(easing, startValue, to, duration);
        }
    }

    public class Vector4EasingAnimator : IAnimator<Vector4>
    {
        private readonly IEasing easing;
        private readonly Vector4 start;
        private readonly Vector4 end;
        private readonly float duration;

        public Vector4EasingAnimator(IEasing easing, Vector4 start, Vector4 end, float duration)
        {
            this.easing = easing;
            this.start = start;
            this.end = end;
            this.duration = duration;
        }

        public Tuple<Vector4, bool> Update(float time)
        {
            var value = Vector4.LerpUnclamped(start, end, easing.Function(Mathf.Min(time / duration, 1.0f)));
            return Tuple.Create(value, time > duration);
        }
    }

    public class Vector4EasingAnimatorWithStartValue : IAnimatorWithStartValue<Vector4>
    {
        private readonly IEasing easing;
        private readonly Vector4 to;
        private readonly float duration;

        public Vector4EasingAnimatorWithStartValue(IEasing easing, Vector4 to, float duration)
        {
            this.easing = easing;
            this.to = to;
            this.duration = duration;
        }

        public IAnimator<Vector4> Start(Vector4 startValue)
        {
            return new Vector4EasingAnimator(easing, startValue, to, duration);
        }
    }

    public class QuaternionEasingAnimator : IAnimator<Quaternion>
    {
        private readonly IEasing easing;
        private readonly Quaternion start;
        private readonly Quaternion end;
        private readonly float duration;

        public QuaternionEasingAnimator(IEasing easing, Quaternion start, Quaternion end, float duration)
        {
            this.easing = easing;
            this.start = start;
            this.end = end;
            this.duration = duration;
        }

        public Tuple<Quaternion, bool> Update(float time)
        {
            var value = Quaternion.LerpUnclamped(start, end, easing.Function(Mathf.Min(time / duration, 1.0f)));
            return Tuple.Create(value, time > duration);
        }
    }

    public class QuaternionEasingAnimatorWithStartValue : IAnimatorWithStartValue<Quaternion>
    {
        private readonly IEasing easing;
        private readonly Quaternion to;
        private readonly float duration;

        public QuaternionEasingAnimatorWithStartValue(IEasing easing, Quaternion to, float duration)
        {
            this.easing = easing;
            this.to = to;
            this.duration = duration;
        }

        public IAnimator<Quaternion> Start(Quaternion startValue)
        {
            return new QuaternionEasingAnimator(easing, startValue, to, duration);
        }
    }

    public class ColorEasingAnimator : IAnimator<Color>
    {
        private readonly IEasing easing;
        private readonly Color start;
        private readonly Color end;
        private readonly float duration;

        public ColorEasingAnimator(IEasing easing, Color start, Color end, float duration)
        {
            this.easing = easing;
            this.start = start;
            this.end = end;
            this.duration = duration;
        }

        public Tuple<Color, bool> Update(float time)
        {
            var value = Color.LerpUnclamped(start, end, easing.Function(Mathf.Min(time / duration, 1.0f)));
            return Tuple.Create(value, time > duration);
        }
    }

    public class ColorEasingAnimatorWithStartValue : IAnimatorWithStartValue<Color>
    {
        private readonly IEasing easing;
        private readonly Color to;
        private readonly float duration;

        public ColorEasingAnimatorWithStartValue(IEasing easing, Color to, float duration)
        {
            this.easing = easing;
            this.to = to;
            this.duration = duration;
        }

        public IAnimator<Color> Start(Color startValue)
        {
            return new ColorEasingAnimator(easing, startValue, to, duration);
        }
    }
}

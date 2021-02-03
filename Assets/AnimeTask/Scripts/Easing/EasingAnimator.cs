using System;
using UnityEngine;

namespace AnimeTask
{
    public static class Easing
    {
        public static Vector1EasingAnimator Create<T>(float duration) where T : IEasing, new()
        {
            return new Vector1EasingAnimator(new T(), 0f, 1f, duration);
        }

        public static Vector1EasingAnimator Create<T>(float start, float end, float duration) where T : IEasing, new()
        {
            return new Vector1EasingAnimator(new T(), start, end, duration);
        }

        public static Vector1EasingAnimator Create<T>(float start, float end, Func<float, float> duration) where T : IEasing, new()
        {
            return new Vector1EasingAnimator(new T(), start, end, duration);
        }

        public static Vector1EasingAnimatorTo Create<T>(float to, float duration) where T : IEasing, new()
        {
            return new Vector1EasingAnimatorTo(new T(), to, duration);
        }

        public static Vector1EasingAnimatorToCalcDuration Create<T>(float to, Func<float, float> duration) where T : IEasing, new()
        {
            return new Vector1EasingAnimatorToCalcDuration(new T(), to, duration);
        }

        public static Vector2EasingAnimator Create<T>(Vector2 start, Vector2 end, float duration) where T : IEasing, new()
        {
            return new Vector2EasingAnimator(new T(), start, end, duration);
        }

        public static Vector2EasingAnimator Create<T>(Vector2 start, Vector2 end, Func<float, float> duration) where T : IEasing, new()
        {
            return new Vector2EasingAnimator(new T(), start, end, duration);
        }

        public static Vector2EasingAnimatorTo Create<T>(Vector2 to, float duration) where T : IEasing, new()
        {
            return new Vector2EasingAnimatorTo(new T(), to, duration);
        }

        public static Vector2EasingAnimatorToCalcDuration Create<T>(Vector2 to, Func<float, float> duration) where T : IEasing, new()
        {
            return new Vector2EasingAnimatorToCalcDuration(new T(), to, duration);
        }

        public static Vector3EasingAnimator Create<T>(Vector3 start, Vector3 end, float duration) where T : IEasing, new()
        {
            return new Vector3EasingAnimator(new T(), start, end, duration);
        }

        public static Vector3EasingAnimator Create<T>(Vector3 start, Vector3 end, Func<float, float> duration) where T : IEasing, new()
        {
            return new Vector3EasingAnimator(new T(), start, end, duration);
        }

        public static Vector3EasingAnimatorTo Create<T>(Vector3 to, float duration) where T : IEasing, new()
        {
            return new Vector3EasingAnimatorTo(new T(), to, duration);
        }

        public static Vector3EasingAnimatorToCalcDuration Create<T>(Vector3 to, Func<float, float> duration) where T : IEasing, new()
        {
            return new Vector3EasingAnimatorToCalcDuration(new T(), to, duration);
        }

        public static Vector4EasingAnimator Create<T>(Vector4 start, Vector4 end, float duration) where T : IEasing, new()
        {
            return new Vector4EasingAnimator(new T(), start, end, duration);
        }

        public static Vector4EasingAnimator Create<T>(Vector4 start, Vector4 end, Func<float, float> duration) where T : IEasing, new()
        {
            return new Vector4EasingAnimator(new T(), start, end, duration);
        }

        public static Vector4EasingAnimatorTo Create<T>(Vector4 to, float duration) where T : IEasing, new()
        {
            return new Vector4EasingAnimatorTo(new T(), to, duration);
        }

        public static Vector4EasingAnimatorToCalcDuration Create<T>(Vector4 to, Func<float, float> duration) where T : IEasing, new()
        {
            return new Vector4EasingAnimatorToCalcDuration(new T(), to, duration);
        }

        public static QuaternionEasingAnimator Create<T>(Quaternion start, Quaternion end, float duration) where T : IEasing, new()
        {
            return new QuaternionEasingAnimator(new T(), start, end, duration);
        }

        public static QuaternionEasingAnimator Create<T>(Quaternion start, Quaternion end, Func<float, float> duration) where T : IEasing, new()
        {
            return new QuaternionEasingAnimator(new T(), start, end, duration);
        }

        public static QuaternionEasingAnimatorTo Create<T>(Quaternion to, float duration) where T : IEasing, new()
        {
            return new QuaternionEasingAnimatorTo(new T(), to, duration);
        }

        public static QuaternionEasingAnimatorToCalcDuration Create<T>(Quaternion to, Func<float, float> duration) where T : IEasing, new()
        {
            return new QuaternionEasingAnimatorToCalcDuration(new T(), to, duration);
        }

        public static ColorEasingAnimator Create<T>(Color start, Color end, float duration) where T : IEasing, new()
        {
            return new ColorEasingAnimator(new T(), start, end, duration);
        }

        public static ColorEasingAnimator Create<T>(Color start, Color end, Func<float, float> duration) where T : IEasing, new()
        {
            return new ColorEasingAnimator(new T(), start, end, duration);
        }

        public static ColorEasingAnimatorTo Create<T>(Color to, float duration) where T : IEasing, new()
        {
            return new ColorEasingAnimatorTo(new T(), to, duration);
        }

        public static ColorEasingAnimatorToCalcDuration Create<T>(Color to, Func<float, float> duration) where T : IEasing, new()
        {
            return new ColorEasingAnimatorToCalcDuration(new T(), to, duration);
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

        public Vector1EasingAnimator(IEasing easing, float start, float end, Func<float, float> duration)
        {
            this.easing = easing;
            this.start = start;
            this.end = end;
            this.duration = duration.Invoke(Mathf.Abs(start - end));
        }

        public (float, float) Update(float time)
        {
            var value = Mathf.LerpUnclamped(start, end, easing.Function(Mathf.Min(time / duration, 1.0f)));
            return (value, Mathf.Min(time, duration));
        }
    }

    public class Vector1EasingAnimatorTo : IAnimatorWithStartValue<float>
    {
        private readonly IEasing easing;
        private readonly float to;
        private readonly float duration;

        public Vector1EasingAnimatorTo(IEasing easing, float to, float duration)
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

    public class Vector1EasingAnimatorToCalcDuration : IAnimatorWithStartValue<float>
    {
        private readonly IEasing easing;
        private readonly float to;
        private readonly Func<float, float> duration;

        public Vector1EasingAnimatorToCalcDuration(IEasing easing, float to, Func<float, float> duration)
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

        public Vector2EasingAnimator(IEasing easing, Vector2 start, Vector2 end, Func<float, float> duration)
        {
            this.easing = easing;
            this.start = start;
            this.end = end;
            this.duration = duration.Invoke(Vector2.Distance(start, end));
        }

        public (Vector2, float) Update(float time)
        {
            var value = Vector2.LerpUnclamped(start, end, easing.Function(Mathf.Min(time / duration, 1.0f)));
            return (value, Mathf.Min(time, duration));
        }
    }

    public class Vector2EasingAnimatorTo : IAnimatorWithStartValue<Vector2>
    {
        private readonly IEasing easing;
        private readonly Vector2 to;
        private readonly float duration;

        public Vector2EasingAnimatorTo(IEasing easing, Vector2 to, float duration)
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

    public class Vector2EasingAnimatorToCalcDuration : IAnimatorWithStartValue<Vector2>
    {
        private readonly IEasing easing;
        private readonly Vector2 to;
        private readonly Func<float, float> duration;

        public Vector2EasingAnimatorToCalcDuration(IEasing easing, Vector2 to, Func<float, float> duration)
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

        public Vector3EasingAnimator(IEasing easing, Vector3 start, Vector3 end, Func<float, float> duration)
        {
            this.easing = easing;
            this.start = start;
            this.end = end;
            this.duration = duration.Invoke(Vector3.Distance(start, end));
        }

        public (Vector3, float) Update(float time)
        {
            var value = Vector3.LerpUnclamped(start, end, easing.Function(Mathf.Min(time / duration, 1.0f)));
            return (value, Mathf.Min(time, duration));
        }
    }

    public class Vector3EasingAnimatorTo : IAnimatorWithStartValue<Vector3>
    {
        private readonly IEasing easing;
        private readonly Vector3 to;
        private readonly float duration;

        public Vector3EasingAnimatorTo(IEasing easing, Vector3 to, float duration)
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

    public class Vector3EasingAnimatorToCalcDuration : IAnimatorWithStartValue<Vector3>
    {
        private readonly IEasing easing;
        private readonly Vector3 to;
        private readonly Func<float, float> duration;

        public Vector3EasingAnimatorToCalcDuration(IEasing easing, Vector3 to, Func<float, float> duration)
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

        public Vector4EasingAnimator(IEasing easing, Vector4 start, Vector4 end, Func<float, float> duration)
        {
            this.easing = easing;
            this.start = start;
            this.end = end;
            this.duration = duration.Invoke(Vector4.Distance(start, end));
        }

        public (Vector4, float) Update(float time)
        {
            var value = Vector4.LerpUnclamped(start, end, easing.Function(Mathf.Min(time / duration, 1.0f)));
            return (value, Mathf.Min(time, duration));
        }
    }

    public class Vector4EasingAnimatorTo : IAnimatorWithStartValue<Vector4>
    {
        private readonly IEasing easing;
        private readonly Vector4 to;
        private readonly float duration;

        public Vector4EasingAnimatorTo(IEasing easing, Vector4 to, float duration)
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

    public class Vector4EasingAnimatorToCalcDuration : IAnimatorWithStartValue<Vector4>
    {
        private readonly IEasing easing;
        private readonly Vector4 to;
        private readonly Func<float, float> duration;

        public Vector4EasingAnimatorToCalcDuration(IEasing easing, Vector4 to, Func<float, float> duration)
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

        public QuaternionEasingAnimator(IEasing easing, Quaternion start, Quaternion end, Func<float, float> duration)
        {
            this.easing = easing;
            this.start = start;
            this.end = end;
            this.duration = duration.Invoke(Quaternion.Angle(start, end));
        }

        public (Quaternion, float) Update(float time)
        {
            var value = Quaternion.LerpUnclamped(start, end, easing.Function(Mathf.Min(time / duration, 1.0f)));
            return (value, Mathf.Min(time, duration));
        }
    }

    public class QuaternionEasingAnimatorTo : IAnimatorWithStartValue<Quaternion>
    {
        private readonly IEasing easing;
        private readonly Quaternion to;
        private readonly float duration;

        public QuaternionEasingAnimatorTo(IEasing easing, Quaternion to, float duration)
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

    public class QuaternionEasingAnimatorToCalcDuration : IAnimatorWithStartValue<Quaternion>
    {
        private readonly IEasing easing;
        private readonly Quaternion to;
        private readonly Func<float, float> duration;

        public QuaternionEasingAnimatorToCalcDuration(IEasing easing, Quaternion to, Func<float, float> duration)
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

        public ColorEasingAnimator(IEasing easing, Color start, Color end, Func<float, float> duration)
        {
            this.easing = easing;
            this.start = start;
            this.end = end;
            this.duration = duration.Invoke(Vector4.Distance(start, end));
        }

        public (Color, float) Update(float time)
        {
            var value = Color.LerpUnclamped(start, end, easing.Function(Mathf.Min(time / duration, 1.0f)));
            return (value, Mathf.Min(time, duration));
        }
    }

    public class ColorEasingAnimatorTo : IAnimatorWithStartValue<Color>
    {
        private readonly IEasing easing;
        private readonly Color to;
        private readonly float duration;

        public ColorEasingAnimatorTo(IEasing easing, Color to, float duration)
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

    public class ColorEasingAnimatorToCalcDuration : IAnimatorWithStartValue<Color>
    {
        private readonly IEasing easing;
        private readonly Color to;
        private readonly Func<float, float> duration;

        public ColorEasingAnimatorToCalcDuration(IEasing easing, Color to, Func<float, float> duration)
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

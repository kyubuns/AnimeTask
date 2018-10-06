using System;
using UnityEngine;

namespace AnimeTask
{
    public static class Easing
    {
        public static Vector3EasingAnimator Create<T>(Vector3 start, Vector3 end, float duration) where T : IEasing, new()
        {
            return new Vector3EasingAnimator(new T(), start, end, duration);
        }

        public static Vector3EasingAnimatorWithStartValue Create<T>(Vector3 to, float duration) where T : IEasing, new()
        {
            return new Vector3EasingAnimatorWithStartValue(new T(), to, duration);
        }
        
        public static Vector2EasingAnimator Create<T>(Vector2 start, Vector2 end, float duration) where T : IEasing, new()
        {
            return new Vector2EasingAnimator(new T(), start, end, duration);
        }

        public static Vector2EasingAnimatorWithStartValue Create<T>(Vector2 to, float duration) where T : IEasing, new()
        {
            return new Vector2EasingAnimatorWithStartValue(new T(), to, duration);
        }
        
        public static Vector1EasingAnimator Create<T>(float start, float end, float duration) where T : IEasing, new()
        {
            return new Vector1EasingAnimator(new T(), start, end, duration);
        }

        public static Vector1EasingAnimatorWithStartValue Create<T>(float to, float duration) where T : IEasing, new()
        {
            return new Vector1EasingAnimatorWithStartValue(new T(), to, duration);
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

        public void Start()
        {
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
        private Vector3 start;

        public Vector3EasingAnimatorWithStartValue(IEasing easing, Vector3 to, float duration)
        {
            this.easing = easing;
            this.to = to;
            this.duration = duration;
        }

        public void Start(Vector3 startValue)
        {
            start = startValue;
        }

        public Tuple<Vector3, bool> Update(float time)
        {
            var value = Vector3.LerpUnclamped(start, to, easing.Function(Mathf.Min(time / duration, 1.0f)));
            return Tuple.Create(value, time > duration);
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

        public void Start()
        {
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
        private Vector2 start;

        public Vector2EasingAnimatorWithStartValue(IEasing easing, Vector2 to, float duration)
        {
            this.easing = easing;
            this.to = to;
            this.duration = duration;
        }

        public void Start(Vector2 startValue)
        {
            start = startValue;
        }

        public Tuple<Vector2, bool> Update(float time)
        {
            var value = Vector2.LerpUnclamped(start, to, easing.Function(Mathf.Min(time / duration, 1.0f)));
            return Tuple.Create(value, time > duration);
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

        public void Start()
        {
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
        private float start;

        public Vector1EasingAnimatorWithStartValue(IEasing easing, float to, float duration)
        {
            this.easing = easing;
            this.to = to;
            this.duration = duration;
        }

        public void Start(float startValue)
        {
            start = startValue;
        }

        public Tuple<float, bool> Update(float time)
        {
            var value = Mathf.LerpUnclamped(start, to, easing.Function(Mathf.Min(time / duration, 1.0f)));
            return Tuple.Create(value, time > duration);
        }
    }
}

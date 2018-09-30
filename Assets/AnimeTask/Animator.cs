using System;
using UnityEngine;
using AnimeTask.Easing;

namespace AnimeTask
{
    public interface IAnimator<T>
    {
        void Start();
        (T value, bool finished) Update();
    }

    public class Vector3Easing : IAnimator<Vector3>
    {
        private readonly IEasing easing;
        private readonly Vector3 start;
        private readonly Vector3 end;
        private readonly float duration;
        private float startTime;

        public Vector3Easing(IEasing easing, Vector3 start, Vector3 end, TimeSpan duration)
        {
            this.easing = easing;
            this.start = start;
            this.end = end;
            this.duration = (float) duration.TotalSeconds;
        }

        public void Start()
        {
            startTime = Time.time;
        }

        public (Vector3 value, bool finished) Update()
        {
            var elapsed = Time.time - startTime;
            var value = Vector3.Lerp(start, end, easing.Function(Mathf.Min(elapsed / duration, 1.0f)));
            return (value, elapsed > duration);
        }
    }

    public class Vector2Easing : IAnimator<Vector2>
    {
        private readonly IEasing easing;
        private readonly Vector2 start;
        private readonly Vector2 end;
        private readonly float duration;
        private float startTime;

        public Vector2Easing(IEasing easing, Vector2 start, Vector2 end, TimeSpan duration)
        {
            this.easing = easing;
            this.start = start;
            this.end = end;
            this.duration = (float) duration.TotalSeconds;
        }

        public void Start()
        {
            startTime = Time.time;
        }

        public (Vector2 value, bool finished) Update()
        {
            var elapsed = Time.time - startTime;
            var value = Vector2.Lerp(start, end, easing.Function(Mathf.Min(elapsed / duration, 1.0f)));
            return (value, elapsed > duration);
        }
    }

    public class Vector1Easing : IAnimator<float>
    {
        private readonly IEasing easing;
        private readonly float start;
        private readonly float end;
        private readonly float duration;
        private float startTime;

        public Vector1Easing(IEasing easing, float start, float end, TimeSpan duration)
        {
            this.easing = easing;
            this.start = start;
            this.end = end;
            this.duration = (float) duration.TotalSeconds;
        }

        public void Start()
        {
            startTime = Time.time;
        }

        public (float value, bool finished) Update()
        {
            var elapsed = Time.time - startTime;
            var value = Mathf.Lerp(start, end, easing.Function(Mathf.Min(elapsed / duration, 1.0f)));
            return (value, elapsed > duration);
        }
    }
}

namespace AnimeTask.Easing
{
    public interface IEasing
    {
        float Function(float v);
    }

    public class Uniform : IEasing
    {
        public float Function(float v) => v;

        public static Vector3Easing Animation(Vector3 start, Vector3 end, TimeSpan duration) => new Vector3Easing(new Uniform(), start, end, duration);
        public static Vector2Easing Animation(Vector2 start, Vector2 end, TimeSpan duration) => new Vector2Easing(new Uniform(), start, end, duration);
        public static Vector1Easing Animation(float start, float end, TimeSpan duration) => new Vector1Easing(new Uniform(), start, end, duration);
    }
}

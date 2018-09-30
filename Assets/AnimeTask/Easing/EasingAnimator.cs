using System;
using UnityEngine;

namespace AnimeTask.Easing
{
    public class Vector3EasingAnimator : IAnimator<Vector3>
    {
        private readonly IEasing easing;
        private readonly Vector3 start;
        private readonly Vector3 end;
        private readonly float duration;
        private float startTime;

        public Vector3EasingAnimator(IEasing easing, Vector3 start, Vector3 end, TimeSpan duration)
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
            var value = Vector3.LerpUnclamped(start, end, easing.Function(Mathf.Min(elapsed / duration, 1.0f)));
            return (value, elapsed > duration);
        }
    }

    public class Vector2EasingAnimator : IAnimator<Vector2>
    {
        private readonly IEasing easing;
        private readonly Vector2 start;
        private readonly Vector2 end;
        private readonly float duration;
        private float startTime;

        public Vector2EasingAnimator(IEasing easing, Vector2 start, Vector2 end, TimeSpan duration)
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
            var value = Vector2.LerpUnclamped(start, end, easing.Function(Mathf.Min(elapsed / duration, 1.0f)));
            return (value, elapsed > duration);
        }
    }

    public class Vector1EasingAnimator : IAnimator<float>
    {
        private readonly IEasing easing;
        private readonly float start;
        private readonly float end;
        private readonly float duration;
        private float startTime;

        public Vector1EasingAnimator(IEasing easing, float start, float end, TimeSpan duration)
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
            var value = Mathf.LerpUnclamped(start, end, easing.Function(Mathf.Min(elapsed / duration, 1.0f)));
            return (value, elapsed > duration);
        }
    }
}

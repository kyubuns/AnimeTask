using System;
using UnityEngine;

namespace AnimeTask
{
    public static partial class Moving
    {
        public static Vector1LinearMovingAnimator Linear(float start, float velocity, float duration)
        {
            return new Vector1LinearMovingAnimator(start, velocity, duration);
        }

        public static Vector1LinearMovingAnimatorWithStartValue Linear(float velocity, float duration)
        {
            return new Vector1LinearMovingAnimatorWithStartValue(velocity, duration);
        }
        
        public static Vector2LinearMovingAnimator Linear(Vector2 start, Vector2 velocity, float duration)
        {
            return new Vector2LinearMovingAnimator(start, velocity, duration);
        }

        public static Vector2LinearMovingAnimatorWithStartValue Linear(Vector2 velocity, float duration)
        {
            return new Vector2LinearMovingAnimatorWithStartValue(velocity, duration);
        }
        
        public static Vector3LinearMovingAnimator Linear(Vector3 start, Vector3 velocity, float duration)
        {
            return new Vector3LinearMovingAnimator(start, velocity, duration);
        }

        public static Vector3LinearMovingAnimatorWithStartValue Linear(Vector3 velocity, float duration)
        {
            return new Vector3LinearMovingAnimatorWithStartValue(velocity, duration);
        }
    }

    public class Vector1LinearMovingAnimator : IAnimator<float>
    {
        private readonly float start;
        private readonly float velocity;
        private readonly float duration;

        public Vector1LinearMovingAnimator(float start, float velocity, float duration)
        {
            this.start = start;
            this.velocity = velocity;
            this.duration = duration;
        }

        public Tuple<float, bool> Update(float time)
        {
            var value = start + velocity * Mathf.Min(time, duration);
            return Tuple.Create(value, time > duration);
        }
    }

    public class Vector1LinearMovingAnimatorWithStartValue : IAnimatorWithStartValue<float>
    {
        private readonly float velocity;
        private readonly float duration;
        private float start;

        public Vector1LinearMovingAnimatorWithStartValue(float velocity, float duration)
        {
            this.velocity = velocity;
            this.duration = duration;
        }

        public void Start(float startValue)
        {
            start = startValue;
        }

        public Tuple<float, bool> Update(float time)
        {
            var value = start + velocity * Mathf.Min(time, duration);
            return Tuple.Create(value, time > duration);
        }
    }

    public class Vector2LinearMovingAnimator : IAnimator<Vector2>
    {
        private readonly Vector2 start;
        private readonly Vector2 velocity;
        private readonly float duration;

        public Vector2LinearMovingAnimator(Vector2 start, Vector2 velocity, float duration)
        {
            this.start = start;
            this.velocity = velocity;
            this.duration = duration;
        }

        public Tuple<Vector2, bool> Update(float time)
        {
            var value = start + velocity * Mathf.Min(time, duration);
            return Tuple.Create(value, time > duration);
        }
    }

    public class Vector2LinearMovingAnimatorWithStartValue : IAnimatorWithStartValue<Vector2>
    {
        private readonly Vector2 velocity;
        private readonly float duration;
        private Vector2 start;

        public Vector2LinearMovingAnimatorWithStartValue(Vector2 velocity, float duration)
        {
            this.velocity = velocity;
            this.duration = duration;
        }

        public void Start(Vector2 startValue)
        {
            start = startValue;
        }

        public Tuple<Vector2, bool> Update(float time)
        {
            var value = start + velocity * Mathf.Min(time, duration);
            return Tuple.Create(value, time > duration);
        }
    }

    public class Vector3LinearMovingAnimator : IAnimator<Vector3>
    {
        private readonly Vector3 start;
        private readonly Vector3 velocity;
        private readonly float duration;

        public Vector3LinearMovingAnimator(Vector3 start, Vector3 velocity, float duration)
        {
            this.start = start;
            this.velocity = velocity;
            this.duration = duration;
        }

        public Tuple<Vector3, bool> Update(float time)
        {
            var value = start + velocity * Mathf.Min(time, duration);
            return Tuple.Create(value, time > duration);
        }
    }

    public class Vector3LinearMovingAnimatorWithStartValue : IAnimatorWithStartValue<Vector3>
    {
        private readonly Vector3 velocity;
        private readonly float duration;
        private Vector3 start;

        public Vector3LinearMovingAnimatorWithStartValue(Vector3 velocity, float duration)
        {
            this.velocity = velocity;
            this.duration = duration;
        }

        public void Start(Vector3 startValue)
        {
            start = startValue;
        }

        public Tuple<Vector3, bool> Update(float time)
        {
            var value = start + velocity * Mathf.Min(time, duration);
            return Tuple.Create(value, time > duration);
        }
    }
}

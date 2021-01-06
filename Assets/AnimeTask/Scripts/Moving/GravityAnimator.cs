using System;
using UnityEngine;

namespace AnimeTask
{
    public static partial class Moving
    {
        public static Vector1GravityMovingAnimator Gravity(float start, float velocity, float acceleration, float duration)
        {
            return new Vector1GravityMovingAnimator(start, velocity, acceleration, duration);
        }

        public static Vector1GravityMovingAnimatorWithStartValue Gravity(float velocity, float acceleration, float duration)
        {
            return new Vector1GravityMovingAnimatorWithStartValue(velocity, acceleration, duration);
        }
        
        public static Vector2GravityMovingAnimator Gravity(Vector2 start, Vector2 velocity, Vector2 acceleration, float duration)
        {
            return new Vector2GravityMovingAnimator(start, velocity, acceleration, duration);
        }

        public static Vector2GravityMovingAnimatorWithStartValue Gravity(Vector2 velocity, Vector2 acceleration, float duration)
        {
            return new Vector2GravityMovingAnimatorWithStartValue(velocity, acceleration, duration);
        }
        
        public static Vector3GravityMovingAnimator Gravity(Vector3 start, Vector3 velocity, Vector3 acceleration, float duration)
        {
            return new Vector3GravityMovingAnimator(start, velocity, acceleration, duration);
        }

        public static Vector3GravityMovingAnimatorWithStartValue Gravity(Vector3 velocity, Vector3 acceleration, float duration)
        {
            return new Vector3GravityMovingAnimatorWithStartValue(velocity, acceleration, duration);
        }
    }

    public class Vector1GravityMovingAnimator : IAnimator<float>
    {
        private readonly float start;
        private readonly float velocity;
        private readonly float acceleration;
        private readonly float duration;

        public Vector1GravityMovingAnimator(float start, float velocity, float acceleration, float duration)
        {
            this.start = start;
            this.velocity = velocity;
            this.acceleration = acceleration;
            this.duration = duration;
        }

        public Tuple<float, bool> Update(float time)
        {
            var t = Mathf.Min(time, duration);
            var value = start + velocity * t + acceleration * (0.5f * t * t);
            return Tuple.Create(value, time > duration);
        }
    }

    public class Vector1GravityMovingAnimatorWithStartValue : IAnimatorWithStartValue<float>
    {
        private readonly float velocity;
        private readonly float acceleration;
        private readonly float duration;
        private float start;

        public Vector1GravityMovingAnimatorWithStartValue(float velocity, float acceleration, float duration)
        {
            this.velocity = velocity;
            this.acceleration = acceleration;
            this.duration = duration;
        }

        public void Start(float startValue)
        {
            start = startValue;
        }

        public Tuple<float, bool> Update(float time)
        {
            var t = Mathf.Min(time, duration);
            var value = start + velocity * t + acceleration * (0.5f * t * t);
            return Tuple.Create(value, time > duration);
        }
    }

    public class Vector2GravityMovingAnimator : IAnimator<Vector2>
    {
        private readonly Vector2 start;
        private readonly Vector2 velocity;
        private readonly Vector2 acceleration;
        private readonly float duration;

        public Vector2GravityMovingAnimator(Vector2 start, Vector2 velocity, Vector2 acceleration, float duration)
        {
            this.start = start;
            this.velocity = velocity;
            this.acceleration = acceleration;
            this.duration = duration;
        }

        public Tuple<Vector2, bool> Update(float time)
        {
            var t = Mathf.Min(time, duration);
            var value = start + velocity * t + acceleration * (0.5f * t * t);
            return Tuple.Create(value, time > duration);
        }
    }

    public class Vector2GravityMovingAnimatorWithStartValue : IAnimatorWithStartValue<Vector2>
    {
        private readonly Vector2 velocity;
        private readonly Vector2 acceleration;
        private readonly float duration;
        private Vector2 start;

        public Vector2GravityMovingAnimatorWithStartValue(Vector2 velocity, Vector2 acceleration, float duration)
        {
            this.velocity = velocity;
            this.acceleration = acceleration;
            this.duration = duration;
        }

        public void Start(Vector2 startValue)
        {
            start = startValue;
        }

        public Tuple<Vector2, bool> Update(float time)
        {
            var t = Mathf.Min(time, duration);
            var value = start + velocity * t + acceleration * (0.5f * t * t);
            return Tuple.Create(value, time > duration);
        }
    }

    public class Vector3GravityMovingAnimator : IAnimator<Vector3>
    {
        private readonly Vector3 start;
        private readonly Vector3 velocity;
        private readonly Vector3 acceleration;
        private readonly float duration;

        public Vector3GravityMovingAnimator(Vector3 start, Vector3 velocity, Vector3 acceleration, float duration)
        {
            this.start = start;
            this.velocity = velocity;
            this.acceleration = acceleration;
            this.duration = duration;
        }

        public Tuple<Vector3, bool> Update(float time)
        {
            var t = Mathf.Min(time, duration);
            var value = start + velocity * t + acceleration * (0.5f * t * t);
            return Tuple.Create(value, time > duration);
        }
    }

    public class Vector3GravityMovingAnimatorWithStartValue : IAnimatorWithStartValue<Vector3>
    {
        private readonly Vector3 velocity;
        private readonly Vector3 acceleration;
        private readonly float duration;
        private Vector3 start;

        public Vector3GravityMovingAnimatorWithStartValue(Vector3 velocity, Vector3 acceleration, float duration)
        {
            this.velocity = velocity;
            this.acceleration = acceleration;
            this.duration = duration;
        }

        public void Start(Vector3 startValue)
        {
            start = startValue;
        }

        public Tuple<Vector3, bool> Update(float time)
        {
            var t = Mathf.Min(time, duration);
            var value = start + velocity * t + acceleration * (0.5f * t * t);
            return Tuple.Create(value, time > duration);
        }
    }
}

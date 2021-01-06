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

        public Tuple<float, float> Update(float time)
        {
            var value = start + velocity * Mathf.Min(time, duration);
            return Tuple.Create(value, Mathf.Min(time, duration));
        }
    }

    public class Vector1LinearMovingAnimatorWithStartValue : IAnimatorWithStartValue<float>
    {
        private readonly float velocity;
        private readonly float duration;

        public Vector1LinearMovingAnimatorWithStartValue(float velocity, float duration)
        {
            this.velocity = velocity;
            this.duration = duration;
        }

        public IAnimator<float> Start(float startValue)
        {
            return new Vector1LinearMovingAnimator(startValue, velocity, duration);
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

        public Tuple<Vector2, float> Update(float time)
        {
            var value = start + velocity * Mathf.Min(time, duration);
            return Tuple.Create(value, Mathf.Min(time, duration));
        }
    }

    public class Vector2LinearMovingAnimatorWithStartValue : IAnimatorWithStartValue<Vector2>
    {
        private readonly Vector2 velocity;
        private readonly float duration;

        public Vector2LinearMovingAnimatorWithStartValue(Vector2 velocity, float duration)
        {
            this.velocity = velocity;
            this.duration = duration;
        }

        public IAnimator<Vector2> Start(Vector2 startValue)
        {
            return new Vector2LinearMovingAnimator(startValue, velocity, duration);
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

        public Tuple<Vector3, float> Update(float time)
        {
            var value = start + velocity * Mathf.Min(time, duration);
            return Tuple.Create(value, Mathf.Min(time, duration));
        }
    }

    public class Vector3LinearMovingAnimatorWithStartValue : IAnimatorWithStartValue<Vector3>
    {
        private readonly Vector3 velocity;
        private readonly float duration;

        public Vector3LinearMovingAnimatorWithStartValue(Vector3 velocity, float duration)
        {
            this.velocity = velocity;
            this.duration = duration;
        }

        public IAnimator<Vector3> Start(Vector3 startValue)
        {
            return new Vector3LinearMovingAnimator(startValue, velocity, duration);
        }
    }
}

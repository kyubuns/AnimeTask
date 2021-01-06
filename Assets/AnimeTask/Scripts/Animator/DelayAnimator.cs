using System;
using UnityEngine;

namespace AnimeTask
{
    public static partial class Animator
    {
        public static DelayAnimator<T> Delay<T>(T startValue, float duration)
        {
            return new DelayAnimator<T>(startValue, duration);
        }

        public static DelayAnimatorWithStartValue<T> Delay<T>(float duration)
        {
            return new DelayAnimatorWithStartValue<T>(duration);
        }
    }

    public class DelayAnimator<T> : IAnimator<T>
    {
        private readonly T start;
        private readonly float duration;

        public DelayAnimator(T start, float duration)
        {
            this.start = start;
            this.duration = duration;
        }

        public Tuple<T, float> Update(float time)
        {
            return Tuple.Create(start, Mathf.Min(time, duration));
        }
    }

    public class DelayAnimatorWithStartValue<T> : IAnimatorWithStartValue<T>
    {
        private readonly float duration;

        public DelayAnimatorWithStartValue(float duration)
        {
            this.duration = duration;
        }

        public IAnimator<T> Start(T startValue)
        {
            return new DelayAnimator<T>(startValue, duration);
        }
    }
}

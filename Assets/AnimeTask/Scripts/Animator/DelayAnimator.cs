using System;
using UnityEngine;

namespace AnimeTask
{
    public static partial class Animator
    {
        public static DelayAnimator<T> Delay<T>(T startValue, float duration) => new DelayAnimator<T>(startValue, duration);
        public static DelayAnimatorWithStartValue<T> Delay<T>(float duration) => new DelayAnimatorWithStartValue<T>(duration);

        public static ConcatAnimator<T> Delay<T>(this IAnimator<T> animator, float duration) => Concat(animator, Delay<T>(duration));
        public static ConcatAnimatorWithStartValue<T> Delay<T>(this IAnimatorWithStartValue<T> animator, float duration) => Concat(animator, Delay<T>(duration));

        public static RelativeDelayAnimator<T1, T2> RelativeDelay<T1, T2>(this T1 startValue, IAnimator<T2> baseAnimator, float duration) => new RelativeDelayAnimator<T1, T2>(startValue, baseAnimator, duration);
        public static RelativeDelayAnimatorWithStartValue<T1, T2> RelativeDelay<T1, T2>(this IAnimatorWithStartValue<T2> baseAnimator, float duration) => new RelativeDelayAnimatorWithStartValue<T1, T2>(baseAnimator, duration);
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

    public class RelativeDelayAnimator<T1, T2> : IAnimator<T1>
    {
        private readonly T1 start;
        private readonly IAnimator<T2> baseAnimator;
        private readonly float duration;

        public RelativeDelayAnimator(T1 start, IAnimator<T2> baseAnimator, float duration)
        {
            this.start = start;
            this.baseAnimator = baseAnimator;
            this.duration = duration;
        }

        public Tuple<T1, float> Update(float time)
        {
            var f = time - duration;
            var (_, used) = baseAnimator.Update(f);
            if (used < f)
            {
                return Tuple.Create(start, time - (f - used));
            }

            return Tuple.Create(start, time);
        }
    }

    public class RelativeDelayAnimatorWithStartValue<T1, T2> : IAnimatorWithStartValue<T1>
    {
        private readonly IAnimatorWithStartValue<T2> baseAnimator;
        private readonly float duration;

        public RelativeDelayAnimatorWithStartValue(IAnimatorWithStartValue<T2> baseAnimator, float duration)
        {
            this.baseAnimator = baseAnimator;
            this.duration = duration;
        }

        public IAnimator<T1> Start(T1 startValue)
        {
            return new RelativeDelayAnimator<T1, T2>(startValue, baseAnimator.Start(default), duration);
        }
    }
}

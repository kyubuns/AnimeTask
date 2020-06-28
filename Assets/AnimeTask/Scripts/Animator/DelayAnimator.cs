using System;
using UnityEngine;

namespace AnimeTask
{
    public static partial class Animator
    {
        public static DelayAnimator<T> Delay<T>(float duration, IAnimator<T> animator)
        {
            return new DelayAnimator<T>(duration, animator);
        }

        public static DelayAnimatorWithStartValue<T> Delay<T>(float duration, IAnimatorWithStartValue<T> animator)
        {
            return new DelayAnimatorWithStartValue<T>(duration, animator);
        }
    }

    public class DelayAnimator<T> : IAnimator<T>
    {
        private readonly float duration;
        private readonly IAnimator<T> animator;

        public DelayAnimator(float duration, IAnimator<T> animator)
        {
            this.duration = duration;
            this.animator = animator;
        }

        public void Start()
        {
            animator.Start();
        }

        public Tuple<T, bool> Update(float time)
        {
            return animator.Update(Mathf.Max(time - duration, 0f));
        }
    }

    public class DelayAnimatorWithStartValue<T> : IAnimatorWithStartValue<T>
    {
        private readonly float duration;
        private readonly IAnimatorWithStartValue<T> animator;

        public DelayAnimatorWithStartValue(float duration, IAnimatorWithStartValue<T> animator)
        {
            this.duration = duration;
            this.animator = animator;
        }

        public void Start(T startValue)
        {
            animator.Start(startValue);
        }

        public Tuple<T, bool> Update(float time)
        {
            return animator.Update(Mathf.Max(time - duration, 0f));
        }
    }
}

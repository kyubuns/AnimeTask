using System;
using UnityEngine;

namespace AnimeTask
{
    public static partial class Animator
    {
        public static DebugLogAnimator<T> DebugLog<T>(this IAnimator<T> animator)
        {
            return new DebugLogAnimator<T>(animator);
        }

        public static DebugLogAnimatorWithStartValue<T> DebugLog<T>(this IAnimatorWithStartValue<T> animator)
        {
            return new DebugLogAnimatorWithStartValue<T>(animator);
        }
    }

    public class DebugLogAnimator<T> : IAnimator<T>
    {
        private readonly IAnimator<T> animator;

        public DebugLogAnimator(IAnimator<T> animator)
        {
            this.animator = animator;
        }

        public Tuple<T, bool> Update(float time)
        {
            var v = animator.Update(time);
            Debug.Log($"{time:0.00}: {v}");
            return v;
        }
    }

    public class DebugLogAnimatorWithStartValue<T> : IAnimatorWithStartValue<T>
    {
        private readonly IAnimatorWithStartValue<T> animator;

        public DebugLogAnimatorWithStartValue(IAnimatorWithStartValue<T> animator)
        {
            this.animator = animator;
        }

        public IAnimator<T> Start(T startValue)
        {
            return new DebugLogAnimator<T>(animator.Start(startValue));
        }
    }
}
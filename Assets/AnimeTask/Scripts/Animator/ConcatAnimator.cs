using System;
using System.Collections.Generic;

namespace AnimeTask
{
    public static partial class Animator
    {
        public static ConcatAnimator<T> Concat<T>(this IAnimator<T> animator1, params IConcatableAnimator<T>[] animator2)
        {
            return new ConcatAnimator<T>(animator1, animator2);
        }

        public static ConcatAnimatorWithStartValue<T> Concat<T>(this IAnimatorWithStartValue<T> animator1, params IConcatableAnimator<T>[] animator2)
        {
            return new ConcatAnimatorWithStartValue<T>(animator1, animator2);
        }
    }

    public class ConcatAnimator<T> : IAnimator<T>
    {
        private readonly List<IConcatableAnimator<T>> animators;
        private T currentValue;
        private IAnimator<T> currentAnimator;
        private float usedTime;

        public ConcatAnimator(IAnimator<T> animator1, IEnumerable<IConcatableAnimator<T>> animator2)
        {
            animators = new List<IConcatableAnimator<T>>(animator2);

            currentAnimator = animator1;
        }

        public Tuple<T, float> Update(float time)
        {
            while (true)
            {
                if (currentAnimator == null) return Tuple.Create(currentValue, usedTime);
                var (v, used) = currentAnimator.Update(time - usedTime);

                if (used < time - usedTime)
                {
                    currentValue = v;
                    usedTime += used;
                    GetNext();
                    continue;
                }

                return Tuple.Create(v, time);
            }
        }

        private void GetNext()
        {
            if (animators.Count == 0)
            {
                currentAnimator = null;
                return;
            }
            var n = animators[0];
            animators.RemoveAt(0);

            if (n is IAnimator<T> animator) currentAnimator = animator;
            else if (n is IAnimatorWithStartValue<T> animatorWithStartValue) currentAnimator = animatorWithStartValue.Start(currentValue);
            else throw new NotSupportedException($"{n} is not supported");
        }
    }

    public class ConcatAnimatorWithStartValue<T> : IAnimatorWithStartValue<T>
    {
        private readonly IAnimatorWithStartValue<T> animator1;
        private readonly IConcatableAnimator<T>[] animator2;
        private IAnimator<T> playingAnimator;

        public ConcatAnimatorWithStartValue(IAnimatorWithStartValue<T> animator1, IConcatableAnimator<T>[] animator2)
        {
            this.animator1 = animator1;
            this.animator2 = animator2;
        }

        public IAnimator<T> Start(T startValue)
        {
            return new ConcatAnimator<T>(animator1.Start(startValue), animator2);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimeTask
{
    public static partial class Animator
    {
        public static ConcatAnimator<T> Concat<T>(params IConcatableAnimator<T>[] animators)
        {
            return new ConcatAnimator<T>(animators);
        }

        public static ConcatAnimator<T> Concat<T>(this IConcatableAnimator<T> animator1, params IConcatableAnimator<T>[] animator2)
        {
            return new ConcatAnimator<T>(new[] { animator1 }.Concat(animator2).ToArray());
        }
    }

    public class ConcatAnimator<T> : IAnimatorWithStartValue<T>
    {
        private readonly List<IConcatableAnimator<T>> animators;
        private IAnimator<T> playingAnimator;

        public ConcatAnimator(IEnumerable<IConcatableAnimator<T>> animators)
        {
            this.animators = new List<IConcatableAnimator<T>>(animators);
        }

        public IAnimator<T> Start(T startValue)
        {
            return new ConcatAnimatorInternal(animators, startValue);
        }

        private class ConcatAnimatorInternal : IAnimator<T>
        {
            private readonly List<IConcatableAnimator<T>> animators;
            private T currentValue;
            private IAnimator<T> currentAnimator;
            private float usedTime;

            public ConcatAnimatorInternal(IEnumerable<IConcatableAnimator<T>> animators, T currentValue)
            {
                this.animators = new List<IConcatableAnimator<T>>(animators);
                this.currentValue = currentValue;
                GetNext();
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
    }
}
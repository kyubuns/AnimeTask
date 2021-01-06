using System;

namespace AnimeTask
{
    public static partial class Animator
    {
        public static ConvertAnimator<T1, T2> Convert<T1, T2>(this IAnimator<T1> animator, Func<T1, T2> func)
        {
            return new ConvertAnimator<T1, T2>(animator, func);
        }

        public static ConvertAnimatorWithStartValue<T> Convert<T>(this IAnimatorWithStartValue<T> animator, Func<T, T> func)
        {
            return new ConvertAnimatorWithStartValue<T>(animator, func);
        }
    }

    public class ConvertAnimator<T1, T2> : IAnimator<T2>
    {
        private readonly IAnimator<T1> animator;
        private readonly Func<T1, T2> func;

        public ConvertAnimator(IAnimator<T1> animator, Func<T1, T2> func)
        {
            this.animator = animator;
            this.func = func;
        }

        public Tuple<T2, float> Update(float time)
        {
            var (item1, item2) = animator.Update(time);
            return Tuple.Create(func(item1), item2);
        }
    }

    public class ConvertAnimatorWithStartValue<T> : IAnimatorWithStartValue<T>
    {
        private readonly IAnimatorWithStartValue<T> animator;
        private readonly Func<T, T> func;

        public ConvertAnimatorWithStartValue(IAnimatorWithStartValue<T> animator, Func<T, T> func)
        {
            this.animator = animator;
            this.func = func;
        }

        public IAnimator<T> Start(T startValue)
        {
            return new ConvertAnimator<T, T>(animator.Start(startValue), func);
        }
    }
}

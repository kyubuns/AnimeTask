using System;

namespace AnimeTask
{
    public static partial class Animator
    {
        public static ConvertAnimator<T1, T2> Convert<T1, T2>(this IAnimator<T1> animator, Func<T1, T2> func)
        {
            return new ConvertAnimator<T1, T2>(animator, func);
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

        public void Start()
        {
            animator.Start();
        }

        public Tuple<T2, bool> Update(float time)
        {
            var (item1, item2) = animator.Update(time);
            return Tuple.Create(func(item1), item2);
        }
    }
}

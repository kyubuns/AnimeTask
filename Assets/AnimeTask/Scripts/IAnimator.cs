using System;

namespace AnimeTask
{
    public interface IAnimator<T>
    {
        Tuple<T, bool> Update(float time);
    }

    public interface IAnimatorWithStartValue<T>
    {
        IAnimator<T> Start(T startValue);
    }
}

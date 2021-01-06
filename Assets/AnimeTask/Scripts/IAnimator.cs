using System;

namespace AnimeTask
{
    public interface IAnimator<T>
    {
        Tuple<T, bool> Update(float time);
    }

    public interface IAnimatorWithStartValue<T>
    {
        void Start(T startValue);
        Tuple<T, bool> Update(float time);
    }
}

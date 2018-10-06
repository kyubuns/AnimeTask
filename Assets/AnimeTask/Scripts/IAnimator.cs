namespace AnimeTask
{
    public interface IAnimator<T>
    {
        void Start();
        (T value, bool finished) Update();
    }

    public interface IAnimatorWithStartValue<T>
    {
        void Start(T startValue);
        (T value, bool finished) Update();
    }
}

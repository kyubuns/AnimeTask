namespace AnimeTask
{
    public interface IAnimator<T>
    {
        void Start();
        (T value, bool finished) Update();
    }
}

namespace AnimeTask
{
    public interface ITranslator<in T>
    {
        bool Alive { get; }
        void Update(T value);
    }

    public interface IValueTranslator<T> : ITranslator<T>
    {
        T Current { get; }
    }
}

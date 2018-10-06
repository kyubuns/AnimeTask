namespace AnimeTask
{
    public interface ITranslator<in T>
    {
        void Update(T value);
    }

    public interface ITranslatorWithCurrentValue<T> : ITranslator<T>
    {
        T Current { get; }
    }
}

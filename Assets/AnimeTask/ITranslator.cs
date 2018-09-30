namespace AnimeTask
{
    public interface ITranslator<in T>
    {
        void Update(T value);
    }
}

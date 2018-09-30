using System;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static ActionTranslator<T> Action<T>(Action<T> action) => new ActionTranslator<T>(action);
    }

    public class ActionTranslator<T> : ITranslator<T>
    {
        private readonly Action<T> action;

        public ActionTranslator(Action<T> action)
        {
            this.action = action;
        }

        public void Update(T value)
        {
            action(value);
        }
    }
}

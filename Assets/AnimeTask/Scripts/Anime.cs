using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace AnimeTask
{
    public static class Anime
    {
        private static AnimeRunner animeRunner;

        public static async Task Play<T>(IAnimator<T> animator, ITranslator<T> translator)
        {
            if (animeRunner == null)
            {
                var go = new GameObject("AnimeRunner");
                animeRunner = go.AddComponent<AnimeRunner>();
            }
            var awaitable = new AwaitableEnumerator();
            animator.Start();
            animeRunner.StartCoroutine(Coroutine(animator, translator, awaitable));
            await awaitable;
        }

        private static IEnumerator Coroutine<T>(IAnimator<T> animator, ITranslator<T> translator, AwaitableEnumerator awaitable)
        {
            while (true)
            {
                var (value, finished) = animator.Update();
                translator.Update(value);
                if (finished) break;
                yield return null;
            }
            awaitable.Finished();
        }

        public static async Task PlayTo<T>(IAnimatorWithStartValue<T> animator, IValueTranslator<T> translator)
        {
            if (animeRunner == null)
            {
                var go = new GameObject("AnimeRunner");
                animeRunner = go.AddComponent<AnimeRunner>();
            }
            var awaitable = new AwaitableEnumerator();
            animator.Start(translator.Current);
            animeRunner.StartCoroutine(Coroutine(animator, translator, awaitable));
            await awaitable;
        }

        private static IEnumerator Coroutine<T>(IAnimatorWithStartValue<T> animator, ITranslator<T> translator, AwaitableEnumerator awaitable)
        {
            while (true)
            {
                var (value, finished) = animator.Update();
                translator.Update(value);
                if (finished) break;
                yield return null;
            }
            awaitable.Finished();
        }
    }

    public class AwaitableEnumerator : INotifyCompletion
    {
        private Action continuationAction;
        public bool IsCompleted { get; private set; }
        public void GetResult() {}

        public void OnCompleted(Action continuation)
        {
            continuationAction = continuation;
        }

        public void Finished()
        {
            IsCompleted = true;
            continuationAction();
        }
    }

    public static class AwaitableEnumeratorExtensions
    {
        public static AwaitableEnumerator GetAwaiter(this AwaitableEnumerator awaitable)
        {
            return awaitable;
        }
    }
}

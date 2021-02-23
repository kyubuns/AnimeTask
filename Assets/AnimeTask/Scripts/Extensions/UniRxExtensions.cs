#if ANIMETASK_UNIRX_SUPPORT
using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UniRx;

namespace AnimeTask.Extensions
{
    public static class UniRxExtensions
    {
        public static IDisposable SubscribeTask<T>(this IObservable<T> source, Func<T, CancellationToken, UniTask> taskFunc)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            return source
                .DoOnCancel(() =>
                {
                    cancellationTokenSource.Cancel();
                })
                .Subscribe(x =>
                {
                    cancellationTokenSource.Cancel();
                    cancellationTokenSource = new CancellationTokenSource();
                    taskFunc(x, cancellationTokenSource.Token).Forget();
                });
        }
    }
}
#endif
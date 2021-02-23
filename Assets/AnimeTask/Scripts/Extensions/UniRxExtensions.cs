#if ANIMETASK_UNIRX_SUPPORT
using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UniRx;

namespace AnimeTask.Extensions
{
    public static class UniRxExtensions
    {
        public static IObservable<AsyncUnit> SelectSwitchTask<T>(this IObservable<T> source, Func<T, CancellationToken, UniTask> selector)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            return source
                .Select(x =>
                {
                    cancellationTokenSource.Cancel();
                    cancellationTokenSource = new CancellationTokenSource();
                    return selector(x, cancellationTokenSource.Token).ToObservable();
                })
                .Switch();
        }

        public static IObservable<TR> SelectSwitchTask<T, TR>(this IObservable<T> source, Func<T, CancellationToken, UniTask<TR>> selector)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            return source
                .Select(x =>
                {
                    cancellationTokenSource.Cancel();
                    cancellationTokenSource = new CancellationTokenSource();
                    return selector(x, cancellationTokenSource.Token).ToObservable();
                })
                .Switch();
        }
    }
}
#endif
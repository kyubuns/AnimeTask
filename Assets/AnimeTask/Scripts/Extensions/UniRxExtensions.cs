#if ANIMETASK_UNIRX_SUPPORT
using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UniRx;

namespace AnimeTask.Extensions
{
    public static class UniRxExtensions
    {
        public static IDisposable SubscribeToAnime<T>(this IObservable<IAnimator<T>> animatorObservable, Func<IAnimator<T>, CancellationToken, UniTask> translator)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            return animatorObservable
                .DoOnCancel(() =>
                {
                    cancellationTokenSource.Cancel();
                })
                .Subscribe(x =>
                {
                    cancellationTokenSource.Cancel();
                    cancellationTokenSource = new CancellationTokenSource();
                    translator(x, cancellationTokenSource.Token).Forget();
                });
        }
    }
}
#endif
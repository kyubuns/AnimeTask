using System.Threading;
using UnityEngine;

namespace AnimeTask
{
    public static class Extension
    {
        public static AnimationCanceller GetAnimationCanceller(this GameObject self)
        {
            var holder = self.GetComponent<AnimationCanceller>();
            if (holder == null) holder = self.AddComponent<AnimationCanceller>();
            return holder;
        }

        public static AnimationCanceller GetAnimationCanceller(this Component self)
        {
            return self.gameObject.GetAnimationCanceller();
        }
    }

    public class AnimationCanceller : MonoBehaviour
    {
        private CancellationTokenSource cancellationTokenSource;

        public void OnDestroy()
        {
            Cancel();
        }

        public AnimationCanceller Cancel()
        {
            cancellationTokenSource?.Cancel();
            cancellationTokenSource = null;
            return this;
        }

        public CancellationTokenSource TokenSource
        {
            get
            {
                if (cancellationTokenSource == null)
                {
                    cancellationTokenSource = new CancellationTokenSource();
                }
                return cancellationTokenSource;
            }
        }

        public CancellationToken Token => TokenSource.Token;
    }
}
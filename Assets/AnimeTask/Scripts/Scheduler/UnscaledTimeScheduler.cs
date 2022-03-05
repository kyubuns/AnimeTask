using Cysharp.Threading.Tasks;
using UnityEngine;

namespace AnimeTask
{
    public class UnscaledTimeScheduler : IScheduler
    {
        public float DeltaTime => Time.unscaledDeltaTime;
        public PlayerLoopTiming UpdateTiming => PlayerLoopTiming.Update;
    }
}

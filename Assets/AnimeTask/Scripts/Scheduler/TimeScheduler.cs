using Cysharp.Threading.Tasks;
using UnityEngine;

namespace AnimeTask
{
    public class TimeScheduler : IScheduler
    {
        public float DeltaTime => Time.deltaTime;
        public PlayerLoopTiming UpdateTiming => PlayerLoopTiming.Update;
    }
}

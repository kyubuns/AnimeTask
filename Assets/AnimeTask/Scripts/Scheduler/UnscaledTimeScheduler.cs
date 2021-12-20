using UnityEngine;

namespace AnimeTask
{
    public class UnscaledTimeScheduler : IScheduler
    {
        public float DeltaTime => Time.unscaledDeltaTime;
    }
}

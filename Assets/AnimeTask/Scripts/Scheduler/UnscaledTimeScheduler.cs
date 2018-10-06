using UnityEngine;

namespace AnimeTask
{
    public class UnscaledTimeScheduler : IScheduler
    {
        public float Now => Time.unscaledTime;
    }
}

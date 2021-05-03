using UnityEngine;

namespace AnimeTask
{
    public class DefaultTimeScheduler : IScheduler
    {
        public float Now => Application.isPlaying ? Time.time : Time.realtimeSinceStartup;
    }
}

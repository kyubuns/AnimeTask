using UnityEngine;

namespace AnimeTask
{
    public class TimeScheduler : IScheduler
    {
        public float Now => Time.time;
    }
}

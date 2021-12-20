using UnityEngine;

namespace AnimeTask
{
    public class TimeScheduler : IScheduler
    {
        public float DeltaTime => Time.deltaTime;
    }
}

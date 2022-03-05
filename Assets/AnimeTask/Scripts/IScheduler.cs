using Cysharp.Threading.Tasks;

namespace AnimeTask
{
    public interface IScheduler
    {
        float DeltaTime { get; }
        PlayerLoopTiming UpdateTiming { get; }
    }
}

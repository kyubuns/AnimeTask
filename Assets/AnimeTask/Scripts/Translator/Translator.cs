using System.Threading.Tasks;
using UnityEngine;

namespace AnimeTask
{
    public static partial class TranslateTo
    {
        public static void CheckAlive(GameObject gameObject)
        {
            if (gameObject == null) throw new TaskCanceledException();
        }

        public static void CheckAlive(Component component)
        {
            if (component == null) throw new TaskCanceledException();
            if (component.gameObject == null) throw new TaskCanceledException();
        }
    }
}
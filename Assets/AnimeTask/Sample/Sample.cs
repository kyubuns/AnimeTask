using System.Threading.Tasks;
using UnityEngine;

namespace AnimeTask.Sample
{
    public class Sample : MonoBehaviour
    {
        public async Task Sample01()
        {
            Debug.Log("Play Sample01");

            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

            await Anime.Play(
                Easing.Create<OutCubic>(new Vector3(-5f, 0f, 0f), new Vector3(5f, 0f, 0f), 2f), TranslateTo.LocalPosition(cube.transform)
            );

            Destroy(cube);
        }
    }
}

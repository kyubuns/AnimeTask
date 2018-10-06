using System;
using System.Threading.Tasks;
using UnityEngine;

namespace AnimeTask.Sample
{
    public class Sample : MonoBehaviour
    {
        public async Task Sample01()
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.localPosition = new Vector3(-5f, 0f, 0f);

            await Task.Delay(TimeSpan.FromSeconds(1));
            await Anime.PlayTo(
                Easing.Create<OutCubic>(new Vector3(5f, 0f, 0f), 2f),
                TranslateTo.LocalPosition(cube)
            );
            await Task.Delay(TimeSpan.FromSeconds(1));

            Destroy(cube);
        }

        public async Task Sample02()
        {
            var cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube1.transform.localPosition = new Vector3(0f, 3f, 0f);

            var cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube2.transform.localPosition = new Vector3(0f, 3f, 0f);

            var cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube3.transform.localPosition = new Vector3(0f, 3f, 0f);

            await Task.Delay(TimeSpan.FromSeconds(1));
            await Task.WhenAll(
                CircleAnimation(cube1, 0.0f),
                CircleAnimation(cube2, 0.2f),
                CircleAnimation(cube3, 0.4f)
            );
            await Task.Delay(TimeSpan.FromSeconds(1));

            Destroy(cube1);
        }

        private async Task CircleAnimation(GameObject go, float delay)
        {
            await Task.Delay(TimeSpan.FromSeconds(delay));
            await Anime.Play(
                Easing.Create<OutCubic>(0.0f, Mathf.PI * 2.0f, 2f),
                TranslateTo.Action<float>(x =>
                {
                    var p = new Vector3(Mathf.Sin(x), Mathf.Cos(x), 0.0f) * 3.0f;
                    go.transform.localPosition = p;
                }));
        }
    }
}

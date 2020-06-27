using System;
using System.Collections;
using System.Threading;
using UnityEngine;
#if ENABLE_UNITASK
using Task = UniRx.Async.UniTask;
#else
using System.Threading.Tasks;
#endif

namespace AnimeTask.Sample
{
    public class Sample : MonoBehaviour
    {
        public async Task Sample01()
        {
            using (var cubes = new SampleCubes(new Vector3(-5f, 0f, 0f)))
            {
                await Anime.Delay(1f);
                await Anime.PlayTo(
                    Easing.Create<OutCubic>(new Vector3(5f, 0f, 0f), 2f),
                    TranslateTo.LocalPosition(cubes[0])
                );
                await Anime.Delay(1f);
            }
        }

        public async Task Sample02()
        {
            using (var cubes = new SampleCubes(new Vector3(0f, 3f, 0f), new Vector3(0f, 3f, 0f), new Vector3(0f, 3f, 0f)))
            {
                await Anime.Delay(1f);
                await Task.WhenAll(
                    CircleAnimation(cubes[0], 0.0f),
                    CircleAnimation(cubes[1], 0.2f),
                    CircleAnimation(cubes[2], 0.4f)
                );
                await Anime.Delay(1f);
            }
        }

        public async Task Sample03()
        {
            using (var cubes = new SampleCubes(new Vector3(-5f, 0f, 0f)))
            {
                await Anime.Delay(1f);
                CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
                cancellationTokenSource.Token.Register(() => Debug.Log("Cancel"));
                cancellationTokenSource.CancelAfter(500);

                await Anime.PlayTo(
                    Easing.Create<OutCubic>(new Vector3(5f, 0f, 0f), 2f),
                    TranslateTo.LocalPosition(cubes[0]),
                    cancellationTokenSource.Token
                );
                await Anime.Delay(1f);
            }
        }

        private async Task CircleAnimation(GameObject go, float delay)
        {
            await Anime.Delay(delay);
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

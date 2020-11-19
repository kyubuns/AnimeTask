using System;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace AnimeTask.Sample
{
    public class Sample : MonoBehaviour
    {
        public async Task Sample01()
        {
            using (var cubes = new SampleCubes(new Vector3(-5f, 0f, 0f)))
            {
                await UniTask.Delay(TimeSpan.FromSeconds(1));
                await Easing.Create<OutCubic>(new Vector3(5f, 0f, 0f), 2f).ToLocalPosition(cubes[0]);
                await UniTask.Delay(TimeSpan.FromSeconds(1));
            }
        }

        public async Task Sample02()
        {
            using (var cubes = new SampleCubes(new Vector3(0f, 3f, 0f), new Vector3(0f, 3f, 0f), new Vector3(0f, 3f, 0f)))
            {
                await UniTask.Delay(TimeSpan.FromSeconds(1));
                await UniTask.WhenAll(
                    CircleAnimation(cubes[0], 0.0f),
                    CircleAnimation(cubes[1], 0.2f),
                    CircleAnimation(cubes[2], 0.4f)
                );
                await UniTask.Delay(TimeSpan.FromSeconds(1));
            }
        }

        public async Task Sample03()
        {
            using (var cubes = new SampleCubes(new Vector3(-5f, 0f, 0f)))
            {
                await UniTask.Delay(TimeSpan.FromSeconds(1));
                CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
                cancellationTokenSource.Token.Register(() => Debug.Log("Cancel"));
                cancellationTokenSource.CancelAfter(500);

                await Easing.Create<OutCubic>(new Vector3(5f, 0f, 0f), 2f).ToLocalPosition(cubes[0], cancellationTokenSource.Token);
                await UniTask.Delay(TimeSpan.FromSeconds(1), cancellationToken: cancellationTokenSource.Token);
            }
        }

        private async UniTask CircleAnimation(GameObject go, float delay)
        {
            await UniTask.Delay(TimeSpan.FromSeconds(delay));
            await Animator.Convert(
                    Easing.Create<OutCubic>(0.0f, Mathf.PI * 2.0f, 2f),
                    x => new Vector3(Mathf.Sin(x), Mathf.Cos(x), 0.0f) * 3.0f)
                .ToLocalPosition(go);
        }

        public async Task Sample04()
        {
            using (var cubes = new SampleCubes(new Vector3(-5f, 0f, 0f)))
            {
                await UniTask.Delay(TimeSpan.FromSeconds(1));
                await UniTask.WhenAll(
                    Moving.Linear(2f, 2f).ToLocalPositionX(cubes[0]),
                    Animator.Delay(1.8f, Easing.Create<Linear>(Vector2.zero, 0.2f)).ToLocalScale(cubes[0])
                );
                await UniTask.Delay(TimeSpan.FromSeconds(1));
            }
        }

        public async Task Sample05()
        {
            using (var cubes = new SampleCubes(new Vector3(-5f, 0f, 0f)))
            {
                await UniTask.Delay(TimeSpan.FromSeconds(1));
                await UniTask.WhenAll(
                    Easing.Create<OutCubic>(Quaternion.identity, Quaternion.Euler(30f, 0f, 0f), 0.5f).ToGlobalRotation(cubes[0])
                );
                await UniTask.Delay(TimeSpan.FromSeconds(1));
            }
        }
    }
}

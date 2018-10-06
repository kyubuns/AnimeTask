using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace AnimeTask.Sample
{
    public static class Util
    {
        public static GameObject CreatePrimitiveCube(Vector3 position)
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.localPosition = position;
            return cube;
        }
    }

    public class SampleCubes : IDisposable
    {
        private readonly List<GameObject> cubes = new List<GameObject>();
        public GameObject this[int index] => cubes[index];

        public SampleCubes(params Vector3[] positions)
        {
            foreach (var position in positions)
            {
                cubes.Add(Util.CreatePrimitiveCube(position));
            }
        }

        public void Dispose()
        {
            foreach (var cube in cubes)
            {
                Object.Destroy(cube);
            }
        }
    }
}

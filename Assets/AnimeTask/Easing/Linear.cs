using System;
using UnityEngine;

namespace AnimeTask.Easing
{
    public class Linear : IEasing
    {
        public float Function(float v) => v;

        public static Vector3EasingAnimator Animation(Vector3 start, Vector3 end, TimeSpan duration) => new Vector3EasingAnimator(new Linear(), start, end, duration);
        public static Vector2EasingAnimator Animation(Vector2 start, Vector2 end, TimeSpan duration) => new Vector2EasingAnimator(new Linear(), start, end, duration);
        public static Vector1EasingAnimator Animation(float start, float end, TimeSpan duration) => new Vector1EasingAnimator(new Linear(), start, end, duration);
    }
}

using UnityEngine;

namespace AnimeTask
{
    public static partial class Moving
    {
        public static AnimationCurveAnimator AnimationCurve(AnimationCurve animationCurve, float playSpeed = 1.0f)
        {
            return new AnimationCurveAnimator(animationCurve, playSpeed);
        }
    }

    public class AnimationCurveAnimator : IAnimator<float>
    {
        private readonly AnimationCurve animationCurve;
        private readonly float playSpeed;
        private readonly float duration;

        public AnimationCurveAnimator(AnimationCurve animationCurve, float playSpeed)
        {
            this.animationCurve = animationCurve;
            this.playSpeed = playSpeed;
            duration = animationCurve.keys[animationCurve.keys.Length - 1].time / playSpeed;
        }

        public (float, float) Update(float time)
        {
            var value = animationCurve.Evaluate(time * playSpeed);
            return (value, Mathf.Min(time, duration));
        }
    }
}

using UnityEngine;

namespace AnimeTask
{
    public class Linear : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return v;
        }
    }

    public class InBack : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return 2.70158f * v * v * v - 1.70158f * v * v;
        }
    }

    public class OutBack : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return 1f + 2.70158f * Mathf.Pow(v - 1f, 3f) + 1.70158f * Mathf.Pow(v - 1f, 2f);
        }
    }

    public class InOutBack : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            const float c1 = 1.70158f;
            const float c2 = c1 * 1.525f;

            if (v < 0.5f)
            {
                return (Mathf.Pow(2f * v, 2f) * ((c2 + 1f) * 2f * v - c2)) / 2f;
            }
            else
            {
                return (Mathf.Pow(2f * v - 2f, 2f) * ((c2 + 1f) * (v * 2f - 2f) + c2) + 2f) / 2f;
            }
        }
    }

    public class InBounce : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return Bounce(v);
        }

        public static float Bounce(float v)
        {
            return 1 - OutBounce.Bounce(1 - v);
        }
    }

    public class OutBounce : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return Bounce(v);
        }

        public static float Bounce(float v)
        {
            if (v < 1 / 2.75f)
            {
                return 7.5625f * v * v;
            }
            else if (v < 2 / 2.75f)
            {
                var f = v - 0.54545f;
                return 7.5625f * f * f + 0.75f;
            }
            else if (v < 2.5 / 2.75f)
            {
                var f = v - 0.81818f;
                return 7.5625f * f * f + 0.9375f;
            }
            else
            {
                var f = v - 0.95454f;
                return 7.5625f * f * f + 0.984375f;
            }
        }
    }

    public class InOutBounce : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            if (v < 0.5f)
            {
                return 0.5f * InBounce.Bounce(v * 2f);
            }
            else
            {
                return 0.5f * OutBounce.Bounce(v * 2f - 1f) + 0.5f;
            }
        }
    }

    public class InCirc : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return 1f - Mathf.Sqrt(1f - (v * v));
        }
    }

    public class OutCirc : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return Mathf.Sqrt((2f - v) * v);
        }
    }

    public class InOutCirc : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            if (v < 0.5f)
            {
                return 0.5f * (1 - Mathf.Sqrt(1f - 4f * (v * v)));
            }
            else
            {
                return 0.5f * (Mathf.Sqrt(-((2f * v) - 3f) * ((2f * v) - 1f)) + 1f);
            }
        }
    }

    public class InCubic : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return v * v * v;
        }
    }

    public class OutCubic : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            var f = (v - 1f);
            return f * f * f + 1f;
        }
    }

    public class InOutCubic : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            if (v < 0.5f)
            {
                return 4f * v * v * v;
            }
            else
            {
                var f = ((2f * v) - 2f);
                return 0.5f * f * f * f + 1f;
            }
        }
    }

    public class InElastic : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            if (Mathf.Approximately(0.0f, v) || Mathf.Approximately(1.0f, v)) return v;
            return Mathf.Sin((v * 10f - 10.75f) * (2f * Mathf.PI / 3f)) * -Mathf.Pow(2f, 10f * (v - 1f));
        }
    }

    public class OutElastic : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            if (Mathf.Approximately(0.0f, v) || Mathf.Approximately(1.0f, v)) return v;
            return Mathf.Sin((v * 10f - 0.75f) * (2f * Mathf.PI / 3f)) * Mathf.Pow(2f, -10f * v) + 1f;
        }
    }

    public class InOutElastic : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            if (Mathf.Approximately(0.0f, v) || Mathf.Approximately(1.0f, v)) return v;

            if (v < 0.5f)
            {
                return -Mathf.Pow(2f, 20f * v - 10f) * Mathf.Sin((20f * v - 11.125f) * (2f * Mathf.PI) / 4.5f) / 2f;
            }
            else
            {
                return Mathf.Pow(2f, -20f * v + 10f) * Mathf.Sin((20f * v - 11.125f) * (2f * Mathf.PI) / 4.5f) / 2f + 1f;
            }
        }
    }

    public class InExpo : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return Mathf.Approximately(0.0f, v) ? v : Mathf.Pow(2f, 10f * (v - 1f));
        }
    }

    public class OutExpo : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return Mathf.Approximately(1.0f, v) ? v : 1f - Mathf.Pow(2f, -10f * v);
        }
    }

    public class InOutExpo : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            if (Mathf.Approximately(0.0f, v) || Mathf.Approximately(1.0f, v)) return v;

            if (v < 0.5f)
            {
                return 0.5f * Mathf.Pow(2f, (20f * v) - 10f);
            }
            else
            {
                return -0.5f * Mathf.Pow(2f, (-20f * v) + 10f) + 1f;
            }
        }
    }

    public class InQuad : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return v * v;
        }
    }

    public class OutQuad : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return -(v * (v - 2f));
        }
    }

    public class InOutQuad : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            if (v < 0.5f)
            {
                return 2f * v * v;
            }
            else
            {
                return -2f * v * v + 4f * v - 1f;
            }
        }
    }

    public class InQuart : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return v * v * v * v;
        }
    }

    public class OutQuart : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            var f = (v - 1f);
            return f * f * f * (1f - v) + 1f;
        }
    }

    public class InOutQuart : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            if (v < 0.5f)
            {
                return 8f * v * v * v * v;
            }
            else
            {
                var f = (v - 1f);
                return 1f - 8f * f * f * f * f;
            }
        }
    }

    public class InQuint : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return v * v * v * v * v;
        }
    }

    public class OutQuint : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            var f = (v - 1f);
            return f * f * f * f * f + 1f;
        }
    }

    public class InOutQuint : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            if (v < 0.5f)
            {
                return 16f * v * v * v * v * v;
            }
            else
            {
                var f = ((2f * v) - 2f);
                return 0.5f * f * f * f * f * f + 1f;
            }
        }
    }

    public class InSine : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return Mathf.Sin((v - 1f) * (Mathf.PI / 2f)) + 1f;
        }
    }

    public class OutSine : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return Mathf.Sin(v * (Mathf.PI / 2f));
        }
    }

    public class InOutSine : IEasing
    {
        public float Function(float v)
        {
            return Calc(v);
        }

        public static float Calc(float v)
        {
            return 0.5f * (1f - Mathf.Cos(v * Mathf.PI));
        }
    }
}

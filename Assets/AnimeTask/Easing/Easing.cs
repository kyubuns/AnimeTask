using UnityEngine;

namespace AnimeTask
{
    public class Linear : IEasing
    {
        public float Function(float v)
        {
            return v;
        }
    }

    public class InBack : IEasing
    {
        public float Function(float v)
        {
            return v * v * v - v * Mathf.Sin(v * Mathf.PI);
        }
    }

    public class OutBack : IEasing
    {
        public float Function(float v)
        {
            var f = (1f - v);
            return 1f - (f * f * f - f * Mathf.Sin(f * Mathf.PI));
        }
    }

    public class InOutBack : IEasing
    {
        public float Function(float v)
        {
            if (v < 0.5f)
            {
                var f = 2f * v;
                return 0.5f * (f * f * f - f * Mathf.Sin(f * Mathf.PI));
            }
            else
            {
                var f = (1 - (2 * v - 1));
                return 0.5f * (1f - (f * f * f - f * Mathf.Sin(f * Mathf.PI))) + 0.5f;
            }
        }
    }

    public class InBounce : IEasing
    {
        public float Function(float v)
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
            return Bounce(v);
        }

        public static float Bounce(float v)
        {
            if (v < 4f / 11.0f)
            {
                return (121f * v * v) / 16.0f;
            }
            else if (v < 8f / 11.0f)
            {
                return (363f / 40.0f * v * v) - (99f / 10.0f * v) + 17f / 5.0f;
            }
            else if (v < 9f / 10.0f)
            {
                return (4356f / 361.0f * v * v) - (35442f / 1805.0f * v) + 16061f / 1805.0f;
            }
            else
            {
                return (54f / 5.0f * v * v) - (513f / 25.0f * v) + 268f / 25.0f;
            }
        }
    }

    public class InOutBounce : IEasing
    {
        public float Function(float v)
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
            return 1f - Mathf.Sqrt(1f - (v * v));
        }
    }

    public class OutCirc : IEasing
    {
        public float Function(float v)
        {
            return Mathf.Sqrt((2f - v) * v);
        }
    }

    public class InOutCirc : IEasing
    {
        public float Function(float v)
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
            return v * v * v;
        }
    }

    public class OutCubic : IEasing
    {
        public float Function(float v)
        {
            var f = (v - 1f);
            return f * f * f + 1f;
        }
    }

    public class InOutCubic : IEasing
    {
        public float Function(float v)
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
            return Mathf.Sin(13 * (Mathf.PI / 2f) * v) * Mathf.Pow(2f, 10f * (v - 1f));
        }
    }

    public class OutElastic : IEasing
    {
        public float Function(float v)
        {
            return Mathf.Sin(-13 * (Mathf.PI / 2f) * (v + 1)) * Mathf.Pow(2f, -10f * v) + 1f;
        }
    }

    public class InOutElastic : IEasing
    {
        public float Function(float v)
        {
            if (v < 0.5f)
            {
                return 0.5f * Mathf.Sin(13f * (Mathf.PI / 2f) * (2f * v)) * Mathf.Pow(2f, 10f * ((2f * v) - 1f));
            }
            else
            {
                return 0.5f * (Mathf.Sin(-13f * (Mathf.PI / 2f) * ((2f * v - 1f) + 1f)) * Mathf.Pow(2f, -10f * (2f * v - 1f)) + 2f);
            }
        }
    }

    public class InExpo : IEasing
    {
        public float Function(float v)
        {
            return Mathf.Approximately(0.0f, v) ? v : Mathf.Pow(2f, 10f * (v - 1f));
        }
    }

    public class OutExpo : IEasing
    {
        public float Function(float v)
        {
            return Mathf.Approximately(1.0f, v) ? v : 1f - Mathf.Pow(2f, -10f * v);
        }
    }

    public class InOutExpo : IEasing
    {
        public float Function(float v)
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
            return v * v;
        }
    }

    public class OutQuad : IEasing
    {
        public float Function(float v)
        {
            return -(v * (v - 2f));
        }
    }

    public class InOutQuad : IEasing
    {
        public float Function(float v)
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
            return v * v * v * v;
        }
    }

    public class OutQuart : IEasing
    {
        public float Function(float v)
        {
            var f = (v - 1f);
            return f * f * f * (1f - v) + 1f;
        }
    }

    public class InOutQuart : IEasing
    {
        public float Function(float v)
        {
            if (v < 0.5f)
            {
                return 8f * v * v * v * v;
            }
            else
            {
                var f = ((2f * v) - 2f);
                return 0.5f * f * f * f * f + 1f;
            }
        }
    }

    public class InQuint : IEasing
    {
        public float Function(float v)
        {
            return v * v * v * v * v;
        }
    }

    public class OutQuint : IEasing
    {
        public float Function(float v)
        {
            var f = (v - 1f);
            return f * f * f * f * f + 1f;
        }
    }

    public class InOutQuint : IEasing
    {
        public float Function(float v)
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
            return Mathf.Sin((v - 1f) * (Mathf.PI / 2f)) + 1f;
        }
    }

    public class OutSine : IEasing
    {
        public float Function(float v)
        {
            return Mathf.Sin(v * (Mathf.PI / 2f));
        }
    }

    public class InOutSine : IEasing
    {
        public float Function(float v)
        {
            return 0.5f * (1f - Mathf.Cos(v * Mathf.PI));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace VectorMathLibrary
{
    public class Vector2
    {
        public float x;
        public float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float magnitude
        {
            get
            {
                return MathF.Sqrt((x * x) + (y * y));
            }
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            Vector2 ans = new Vector2(a.x + b.x, a.y + b.y);
            return ans;
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            Vector2 ans = new Vector2(a.x - b.x, a.y - b.y);
            return ans;
        }

        public static Vector2 operator *(float a, Vector2 b)
        {
            return new Vector2(a * b.x, a * b.y);
        }

        public static Vector2 operator *(Vector2 b, float a)
        {
            return new Vector2(a * b.x, a * b.y);
        }

        public void Normalize()
        {
            float mag = magnitude;
            this.x /= mag;
            this.y /= mag;
        }

        public Vector2 normalized
        {
            get
            {
                return new Vector2(this.x / magnitude, this.y / magnitude);
            }
        }
    }
}

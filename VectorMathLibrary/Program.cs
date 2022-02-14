using System;

namespace VectorMathLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2 v = new Vector2(2, 3);
            Console.WriteLine(v.normalized);
            Console.WriteLine(v.normalized.magnitude);

            Vector2 u = new Vector2(-5, 1);
            u.Normalize();
            Console.WriteLine(u);
            Console.WriteLine(u.magnitude);
        }
    }
}

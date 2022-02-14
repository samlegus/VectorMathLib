using System;

namespace VectorMathLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2 u = new Vector2(1, 1);
            Vector2 v = new Vector2(2, 3);
            Vector2 r = new Vector2(-1, 2);

            Console.WriteLine(5f * v);
            Console.WriteLine(v * 5f);
        }
    }
}

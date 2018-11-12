using System;

namespace Sumdag3
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res);
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);
            Udskriv("Dette er en test");

            Console.ReadKey();
        }

        private static void Udskriv(string v)
        {
            Console.WriteLine(v);
        }

        private static double BeregnAreal(int v)
        {
            double res = (Math.PI*v*v);
            return res;

        }

        private static int LægSammen(int v1, int v2)
        {
            return (v1 + v2);
        }
    }
}

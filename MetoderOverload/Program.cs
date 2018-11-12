using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregn(1,2));
            Console.WriteLine(Beregn(1,2,3));
            Console.WriteLine(Beregn(1,2,3,4));

            Console.ReadLine();
        }

        private static int Beregn(int v1, int v2, int v3, int v4)
        {
            int res1 = Beregn(v1 ,v2);
            int res2 = Beregn(v3, v4);
            return (Beregn(res1, res2));
        }

        private static int Beregn(int v1, int v2, int v3)
        {
            int res = Beregn(v1, v2);
            int res2 = Beregn(res, v3);

            return res2;
            ;
        }

        private static int Beregn(int v1, int v2)
        {
            return(v1+v2);

        }
    }

}

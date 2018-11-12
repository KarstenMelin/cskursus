using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoderRekursiv
{
    class Program
    {
        static void Main(string[] args)
        {

            LøkkeSomMetode(1, 10);

            Console.ReadLine();
        }

        public static void LøkkeSomMetode(int v1, int v2)
        {

            if (v1 <= v2)
                {
                Console.WriteLine(v1);
                v1++;
                LøkkeSomMetode(v1, v2);
            }
                
        }
    }
}

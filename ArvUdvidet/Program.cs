using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvUdvidet
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool());

            Console.WriteLine(r.Next(1,1002));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public class UdvidetRandom : Random
        {
            public bool NextBool()

            {   
                return this.Next(1,1002) < 501; 
            }

        }
    }
}

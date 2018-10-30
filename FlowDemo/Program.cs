using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("Resultatet er:");
            Console.WriteLine();

            for (int i = 0; i < 19; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

                if (i < 16)
                    continue;
                else
                    break;
            }


            Console.WriteLine();
            Console.WriteLine();

            // Break ud i kode er også muligt
            // System.Diagnostics.Debugger.Break();

            // Hold Console åbn (ved debug)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }

        }
    }
}

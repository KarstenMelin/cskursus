using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine($"Heltallet er: {heltal}");

            Console.WriteLine();





            double kommatal = 12.5;

            kommatal++;

            kommatal--;

            kommatal *= 2;

            Console.WriteLine($"Kommatal = {kommatal}");


            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();
                                           
            }
        }
    }
}


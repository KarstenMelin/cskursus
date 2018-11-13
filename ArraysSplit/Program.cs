using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSplit
{
    class Program
    {

        
        static void Main(string[] args)
        {

            string txt = "3;5;22;1;10;15;5";

            string[] enkelt = txt.Split(';');

            int sum = 0;

            for (int i = 0; i < enkelt.Length; i++)
            {
                int tal = Convert.ToInt32(enkelt[i]);
                sum += tal;
            }

            Console.WriteLine($"Summen er {sum:N2}");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}

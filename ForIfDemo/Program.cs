using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                string linie = "";
                for (int j = 1; j < 11; j++)
                {
                    int res = i * j;
                    
                    if (res > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }


                    if (res < 10)
                        { Console.Write("   " + res); }
                    else if (res < 100)
                    {
                        Console.Write("  " + res);
                    }
                    else
                    {
                        Console.Write(" " + res);
                    }

                        
                    
                }

                Console.WriteLine("");                
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


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

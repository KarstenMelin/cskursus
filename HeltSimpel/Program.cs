﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeltSimpel
{
    // public delegate void MinDelegate1(string s1);



    class Program
    {
        static void Main(string[] args)
        {
          //  MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
          //  f1.Invoke("test");
          //  f1 -= MinSkrivTilConsole;
            // f1("væk");

            Action<string> f2 = MinSkrivTilConsole;
            f2("test");
          //  f2 -= MinSkrivTilConsole;
            // f2("væk");

            Action<string> f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("test3");
            // f3 -= MinSkrivTilConsole;
            f3("væk1");
            // f3 -= Console.WriteLine;
            f3("væk2");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }
}

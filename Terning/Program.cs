﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public class Terning
        {
            public int værdi;
            public bool snyd;

            private static Random rnd = new Random();
         
            public Terning()
            {
                this.værdi = 1;
                this.snyd = false;
            }

            public Terning(bool snyd)
            {
                this.værdi = 1;
                this.snyd = snyd;
            }
            public void Skriv()
            {
                Console.WriteLine("[" + this.værdi + "]");
            }

            public void Ryst()
            {
                if (snyd)
                    this.værdi = 6;
                else
                    this.værdi = rnd.Next(1, 7);

                
            }
        }
    }
}

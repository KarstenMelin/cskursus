using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenskaberTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();

            t.Skriv();

            t.Ryst();

            t.Skriv();

            t.Værdi = 7;

            t.Skriv();

            t = new Terning(6);

            t.Skriv();




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public class Terning
        {
            public Terning() { }

            public Terning(int værdi)
            {
                this.Værdi = værdi;
            }


            private int værdi;


            public int Værdi
            {
                get
                {
                    Console.WriteLine("Terning aflæses som " + this.værdi);
                    return værdi;
                }
                set
                {
                    Console.WriteLine("Terning tildeles " + value);

                    if (value < 1 || value > 6)
                        værdi = 1;
                    else
                    værdi = value;
                }
            }

            private static Random rnd = new Random();

            public void Ryst()
            {
                this.værdi = rnd.Next(1, 7);

            }

            public void Skriv()
            {
                Console.WriteLine("[" + this.værdi + "]");
            }
        }
    }
}

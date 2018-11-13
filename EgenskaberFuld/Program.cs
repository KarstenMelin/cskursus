using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenskaberFuld
{
    class Program
    {
        static void Main(string[] args)
        {

            Vare v = new Vare();
            v.Navn = "Vandhane";
            v.Pris = 125.10;
            Console.WriteLine(v.PrisMedMoms());

            Vare v2 = new Vare("Var enr 2", 200.23);
            Console.WriteLine(v2.PrisMedMoms());



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }



        public class Vare
        {

            public Vare()
            {   }

            public Vare(string navn, double pris)
            {
                this.Pris = pris;
                this.Navn = navn;
            }

            private string navn;

            public string Navn
            {
                get
                {
                    Console.WriteLine("Get Navn");
                    return navn;
                }
                set
                {
                    Console.WriteLine("Set Navn");
                    navn = value;
                }
            }

            private double pris;

            public double Pris
            {
                get
                {
                    Console.WriteLine("Get Pris");
                    return pris;
                }
                set
                {
                    Console.WriteLine("Set Pris");
                    pris = value;
                }
            }

   
            public double PrisMedMoms()
            {
                return this.pris * 1.25;
            }

        }
    }
}

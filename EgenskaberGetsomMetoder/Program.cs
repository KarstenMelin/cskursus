using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenskaberGetsomMetoder
{
    class Program
    {
        static void Main(string[] args)
        {

            Trekant t = new Trekant(3, 5);
            Console.WriteLine($"Arealet er: {t.GetAreal()}");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public class Trekant
        {
            public int Grundlinje { get; private set; }
            public int Højde { get; private set; }

            public Trekant (int grundlinje, int højde)
            {
                this.Grundlinje = grundlinje;
                this.Højde = højde;
            }

            public double GetAreal() => this.Højde * this.Grundlinje * 0.5;
        }            

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Fornavn = "Karsten", Efternavn = "Melin" };
            Console.WriteLine("Personens fulde navn er " + p.FuldtNavn());
            Console.WriteLine("");

            Elev e = new Elev() { Fornavn = "Hans", Efternavn = "Hansen", Klasselokale = "2.6.8"};
            Console.WriteLine("Elevens fulde navn er " + e.FuldtNavn());
            Console.WriteLine("");

            Instruktør i = new Instruktør();
            i.Efternavn = "Larsen";
            i.Fornavn = "Lars";
            Console.WriteLine("Instruktørens fulde navn er " + i.FuldtNavn());
            Console.WriteLine("");



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}

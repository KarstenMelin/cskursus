using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t = new Terning();
           
            t.Skriv();
            t.Ryst();
            t.Skriv();

            Console.WriteLine("");

            LudoTerning l = new LudoTerning();
            l.Skriv();
            Console.WriteLine(l.ErGlobus);
            Console.WriteLine(l.ErStjerne);
            Console.WriteLine("");

            l.Ryst();
            l.Skriv();
            Console.WriteLine(l.ErGlobus);
            Console.WriteLine(l.ErStjerne);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}

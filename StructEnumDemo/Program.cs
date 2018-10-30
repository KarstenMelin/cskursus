using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnumDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            FilTyper ft = new FilTyper();
            ft = FilTyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);


            Person p = new Person();
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);


            // Hold Console åbn (ved debug)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
                                    
        }
             
    }

}

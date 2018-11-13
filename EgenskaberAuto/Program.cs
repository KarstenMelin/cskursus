using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenskaberAuto
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            p.Fornavn = "Anders";
            p.Efternavn = "And";

            Console.WriteLine(p.Fuldtnavn);
            


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public class Person
        {
            public string Fornavn { get; set; }

            private string efternavn;

            public string Efternavn
            {
                get { return efternavn; }
                set {
                    if (value.Length < 3)
                        efternavn = "";
                        else
                    efternavn = value; }
            }

            public string Fuldtnavn => Fornavn + " " + efternavn;
        }
    }
}

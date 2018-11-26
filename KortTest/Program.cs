using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortTest
{
    class Program
    {
        static void Main(string[] args)
        {
            KortspilApp.Kerne.Spillekort s = new KortspilApp.Kerne.Spillekort();
            Console.WriteLine(s.Kulør + " " + s.Værdi);



            


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public class SpilleKortKrig : KortspilApp.Kerne.Spillekort
        {

        }
    }
}

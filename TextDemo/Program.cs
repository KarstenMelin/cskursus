using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "a";
            string b = "a";
            bool test;
            test = a == b;

            Console.WriteLine($"er de ens?: { test}");

         
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            string samletNavn = fornavn + " " + efternavn;

            string stortNavn = samletNavn.ToUpper();
            Console.WriteLine(stortNavn);

            string lilleNavn = samletNavn.ToLower();
            Console.WriteLine(lilleNavn);

            string delNavn = samletNavn.Substring(7, 4);
            Console.WriteLine(delNavn);

            Console.WriteLine(fornavn + "\r\n\t" + efternavn);

            System.IO.File.WriteAllText("c:\\temp\\test.txt", samletNavn);




            // Hold console åben ved debug

            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();



            }
        }
    }
}

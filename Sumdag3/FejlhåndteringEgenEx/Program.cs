using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejlhåndteringEgenEx
{
    class Program
    {
        static void Main(string[] args)
        {

            string filnavn = "C:\\temp\\tal.txt";
            if (!System.IO.File.Exists(filnavn))
                throw new ApplicationException("Filen " + filnavn + " findes ikke!");


            string indhold = "";

            try
            {
                indhold = System.IO.File.ReadAllText(filnavn);
                int tal = Convert.ToInt32(indhold);
                tal++;

                System.IO.File.WriteAllText(filnavn, tal.ToString());
                Console.WriteLine($"Tal i fil er nu {tal}");

            }

            catch (System.FormatException)
            {
                throw new ApplicationException($"'{indhold}' kan ikke konverteres til et heltal");
            }

            catch (Exception)
            {
                throw;
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}

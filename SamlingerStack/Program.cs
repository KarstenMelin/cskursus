using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamlingerStack
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public class Bunke
        {
            private Stack<Kort> korts = new Stack<Kort>();

            public class Tilføjkort
            {
                
            }
        }
         

        public class Kort
        {
            public string Kulør { get; set; }
            public int Værdi { get; set; }
            public override string ToString()
            {
                return this.Kulør + " " + this.Værdi;
            }
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.fornavn = "anders";
            p1.efternavn = "and";
            p1.fødselsår = 1935;

            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.EstimeretAlder());

            Person p2 = new Person("andersine", "And", 1939);

            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.EstimeretAlder());

                                 


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public class Person
        {
            public string fornavn;
            public string efternavn;
            public int fødselsår;

            public Person()
            {
                fornavn = "";
                efternavn = "";
            }

            public Person(string f, string e, int aa)
            {
                this.fornavn = f;
                this.efternavn = e;
                this.fødselsår = aa;

            }

            public string FuldtNavn()
            {
                return $"{fornavn} {efternavn}";
            }

           public int EstimeretAlder()
            {
           
               return DateTime.Now.Year - fødselsår;
             
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine($"Dato og tid: {d1}");
            d1 = d1.AddDays(10);
            Console.WriteLine($"Dato og tid: {d1}");
            d1 = d1.AddMinutes(20);
            Console.WriteLine($"Dato og tid: {d1}");
            d1 = d1.AddMonths(-1);
            Console.WriteLine($"Dato og tid: {d1}");

            DateTime d2 = new DateTime(1965, 4, 23);
            DateTime d3 = new DateTime(1969, 4, 11);
            Console.WriteLine($"Dato og tid: {d2}");
            Console.WriteLine($"Dato og tid: {d3}");
            System.TimeSpan d4 = d3.Subtract(d2);
            Console.WriteLine($"Dato og tid: {d4.Days:N2}");

            System.TimeSpan t2 = new TimeSpan(16, 00, 00);
            Console.WriteLine($"Timespan t2: {t2}");

            System.TimeSpan t3 = new TimeSpan(00, 30, 00);
            Console.WriteLine($"Timespan t3: {t3}");

            TimeSpan t4 = t2.Subtract(t3);
            Console.WriteLine($"Timespan t4: {t4}");

            System.TimeSpan t5 = t2.Add(t3);
            Console.WriteLine($"Timespan t5: {t5}");




            // Hold Console åbn (ved debug)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }

        }
    }
}

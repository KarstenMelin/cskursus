using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeroderStatisk
{
    class Program
    {
        static void Main(string[] args)
        {

            string fileName = @"c:\temp\test.txt";
            bool res = System.IO.File.Exists(fileName);
            Console.WriteLine(res);
            Console.WriteLine();

            Console.WriteLine(System.IO.File.ReadAllText(fileName));
            Console.WriteLine();


            var fil = new System.IO.FileInfo(@"c:\temp\test.txt");
            Console.WriteLine(fil.LastAccessTime);
            Console.WriteLine(fil.Extension);
            Console.WriteLine();



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}

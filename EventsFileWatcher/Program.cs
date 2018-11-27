using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsFileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            // bind en metode til w.Changed

            w.Changed += W_Changed;
            w.Created += (s, e) => { Console.WriteLine("Fil oprettet " + e.FullPath); };

            do
            {

            } while (true);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        private static void W_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine($"Filen { e.Name} er rettet");
        }
    }
}

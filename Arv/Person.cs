using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Person
    {
        public string Fornavn { get; set; }

        public string Efternavn { get; set; }

        public string FuldtNavn ()
        {
            return $"{Fornavn} {Efternavn}";
        }
    }
}

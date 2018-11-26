using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvTerning
{
    class LudoTerning : Terning
    {
        public bool ErGlobus
        {
            get
            {
                return this.Værdi == 3;
            }
        }

        public bool ErStjerne
        {
            get
            {
                return this.Værdi == 5;
            }
        }

        public LudoTerning() : base() { }
        public LudoTerning(int værdi) : base(værdi) { }

        public override void Skriv()
        {

            switch (this.Værdi)
            {
                case 3:
                    Console.WriteLine("[" + "G" + "]");
                    break;

                case 5:
                    Console.WriteLine("[" + "S" + "]");
                    break;

                default:
                    base.Skriv();
                    break;
            }
        }
    }
}

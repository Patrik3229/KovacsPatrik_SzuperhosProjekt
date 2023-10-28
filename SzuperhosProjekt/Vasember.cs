using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Vasember : Bosszuallo, IMilliardos
    {
        Random RND = new Random();
        public Vasember() : base(150, true)
        {

        }

        public void KutyutKeszit()
        {
            this.Szuperero += RND.Next(0, 11);
        }

        public override bool MegmentiAVilagot()
        {
            if (this.Szuperero > 1000)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            if (this.VanEGyengesege)
            {
                return $"Vasember: Szupererő: {this.Szuperero}; van gyengesége";
            }
            else return $"Vasember: Szupererő: {this.Szuperero}; nincs gyengesége";
        }
    }
}
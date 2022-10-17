using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    internal  class Psiho : Mutant
    {
         int številouporabemoči;
         int iq;

        public int ŠteviloUporabeMoči { get => številouporabemoči; set => številouporabemoči = value; }
        public int IQ { get => iq; set => iq = value; }


        public override int KvocientNevarnosti()
        {
            return Stopnja*ŠteviloUporabeMoči * IQ;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    internal  class Elementarec: Mutant
    {

         int področje;
        

        
        public int Področje { get => this.področje; set => this.področje = value; }

        public override int KvocientNevarnosti()
        {
            return Področje * Stopnja;
        }
        
    }
}

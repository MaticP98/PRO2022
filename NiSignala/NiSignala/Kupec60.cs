using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiSignala
{
    internal class Kupec60 : Kupec
    {
        private int višjaTarifaPorabljeno;
        public new void BeležiKlic(int min, TipKlica tip)
        {
            switch (tip)
            {
                case TipKlica.Stacionarno:
                    stanje += min * 0.12m;
                    break;
                case TipKlica.Mobilno:
                    int vMinute, nMinute;
                    int ševMinute = (višjaTarifaPorabljeno < 60) ?
                        60 - višjaTarifaPorabljeno : 0;
                    if (min > ševMinute)
                    {
                        vMinute= ševMinute;
                        nMinute = min - vMinute;
                            }
                    else
                    {
                        vMinute = min;
                        nMinute = 0;
                    }
                    stanje += vMinute * 0.035m + nMinute * 0.01m;
                    višjaTarifaPorabljeno += vMinute;
                    break;
                default:
                    break;
            }
        }
    }
}

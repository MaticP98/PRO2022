using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NiSignala
{
    internal class Program
    {

        static void Main(String[] args)
        {
            Kupec janez = new Kupec();
            janez.Ime = "Janez Novak";
            janez.BeležiKlic(10, TipKlica.Stacionarno);
            Console.WriteLine(janez.Ime + "dolguje" + janez.Stanje);
            Console.WriteLine(janez.Ime+" "+janez.GetType());

            Kupec alenka = new Kupec60();
            alenka.Ime = "Alenka Novak";
            alenka.BeležiKlic(100, TipKlica.Mobilno);
            Console.WriteLine(alenka.Ime + "dolguje" + janez.Stanje);
            Console.ReadLine();

        }
    }

} 
    


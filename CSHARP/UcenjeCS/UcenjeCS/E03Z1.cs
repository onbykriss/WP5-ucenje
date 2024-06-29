using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z1
    {
        // program od korisnika traži unos broj godina koje ima korisnik
        // program ispisuje da li je korisnik punoljetna osoba ili ne

        // dodatno: ako je unos ispod nulo godina ili iznad 100 godina


        public static void Izvedi()
        {


            Console.Write("Unesi broj godina: ");
            int g = int.Parse(Console.ReadLine()); 
            if (g >= 18)
            {
                Console.WriteLine("Punoljetan");
            }
            else
            {
                Console.WriteLine("Nisi punoljetan");
            }
            if (g < 1 || g > 100)
            { 
                Console.WriteLine("Dostup zabranjen");
            }

      














        }













    }
}

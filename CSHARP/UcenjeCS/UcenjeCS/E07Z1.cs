using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z1
    {
        public static void Izvedi() 
        {

            // Program od korisnika unesi broj (Osigurava se unos)
            // Koristeči while petlju program ispisuje
            //zbroj svih parnih brojeva od 1 do unesenog broja (skupa s njim)
            // unos 10 ispis 30
            // unos 12 ispis 42

            int broj;
            while (true)
            {
                Console.WriteLine("Unesi broj: ");
                if (int.TryParse(Console.ReadLine(), out broj) && broj >= 10 && broj <= 20)
                {
                    break;
                }
                Console.WriteLine("Neispravan broj. Pokušajte ponovo.");
            }
            Console.WriteLine("Unjeli ste broj " + broj);

            Console.WriteLine("*************************************************************+");

            // Program od korisnika unosi 10 brojeva
            // Program ispisuje prvo zboj svih unesenih brojeva
            // i nakon toga ispisuje unosene brojeve jedno ispod drugog

            int[] brojevi = new int[10];
            int sum = 0;

            for (int i = 0; i < brojevi.Length; i++)
            {
                Console.WriteLine("Unesi {0}. broj: ", i + 1);
                brojevi[i] = int.Parse(Console.ReadLine());
                sum += brojevi[i];

            }

            Console.WriteLine("Zbroj svih unesenih brojeva je: " + sum);

            Console.WriteLine("Uneseni brojevi su:");
            for (int i = 0; i < brojevi.Length; i++)
            {
                Console.WriteLine(brojevi[i]);
            }

            Console.WriteLine("*************************************************************");








        }

    }
}

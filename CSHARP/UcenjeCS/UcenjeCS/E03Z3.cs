using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z3
    {

        // program od korisnika traži unos dva cijela broja
        // program ispisuje manji

        public static void Izvedi()
        {

            int broj1, broj2;

            Console.WriteLine("Unesi prvi broj1");
            broj1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Unesi drugi broj");
            broj2 = int.Parse(Console.ReadLine());

            if (broj1 < broj2)
            {
                Console.WriteLine("Manji broj je: " + broj1);
            }
            else if (broj2 < broj1)
            {
                Console.WriteLine("Manji broj je : " + broj2);
            }
            else 
            {
                Console.WriteLine("Unjeli ste isti broj");
            }










        }


    }
}

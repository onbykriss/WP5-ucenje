using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnoGrananjeIf
    {





        public static void Izvedi()
        {
            int i = 7; // Ovo simuliram da je korisnik pomoču int.parse CR učitao vrijednost

            bool uvjet = i == 8;

            Console.WriteLine(uvjet);

            // if radi s bool tipom podataka
            if (uvjet) {
                Console.WriteLine("Vrijednost variable i je 8");  // u if čes uč ako odgovara uvjetu 
            }
            // ovo nikada pisat
            if (uvjet == true) 
            {
              
            }

            // najcesca sintaksa
            if (i == 8) 
            { 
           
            }

            // if ima i else granu
            if (i > 10) 
            {
                Console.WriteLine("i je veči od 10");
          
            }
            else
            {
                Console.WriteLine("i nije veči od 10");
                
            }

            // if ne mora imati {} ako se if ili else odnose samo na jednu linija
            // ovo nije najbolja praksa. Best praksa
            if (i > 10)
                Console.WriteLine("i je veči od 10");
            else
                Console.WriteLine("i nije veci od 10");


            // puna sintaksa if naredbe
            int b = 2;
            if (b == 1)
            {
                Console.WriteLine("Ne može");
            }
            else if (b > 5) 
            { 
                Console.WriteLine("OK");
                
            }  // jos moze ic nn else if djelova
            else  
            {

                Console.WriteLine("Ostalo");
            }

            // operatori & i &&
            // & uvjet provjerava oba uvjeta
            // && koliko 1. uvjet nije zadovoljen, drugi se niti ne gleda
            int x = 2, y = 1;

            if (x == 1 && y == 1)
            { 
            
            Console.WriteLine("x i y su 1");

            }
            // operatori  |     (alt + 124)

            // |  provjerava oba uvjeta
            // || koliko je prvi uvjet zadovoljen, ne gleda na drugi
            if (i > 1 || i == 0)
            {
                Console.WriteLine("ako je prvi uvjet zadovoljen ulazi se u if");
            
            }

            // if se može gnjezditi
            if (x == 3)
            {
              int k = 9;
                if (i > 0)
                {
                    Console.WriteLine("Zadovoljeno");
                }
                else 
                {

                    Console.WriteLine("NE");
                }
                // preduvjet je da if i else provode istu akciju - u ovom slučaju cw
               
                Console.WriteLine(x == 0 ? "OK" : "NE");







            }

        
        
        
        
        
        
        















        }
















    }
}

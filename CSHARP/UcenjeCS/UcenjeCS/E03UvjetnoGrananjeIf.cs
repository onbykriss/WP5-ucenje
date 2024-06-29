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


        public static void Izvedi()   //TO UVJEK MORAŠ UPISATI PRIJE POČNEŠ RADIT !!!!
        {
            int i = 7;      //Ovo simuliram da je korisnik pomoču int.parse CR učitao vrijednost

            bool uvjet = i == 8;  // == provjerava vrijednost
            
            Console.WriteLine(uvjet);

            // IF radi s BOOL tipom podataka znači TRUE ili FALSE ( u nasem primjeru je i=8)
            // drugi primjer i = 7 znači ispisat če FALSE

            if (uvjet) 
            {
             Console.WriteLine("Vrijednost variable i je 8");  // u if čes uč ako odgovara uvjetu 
            }

            // ovo nikada pisat!!!!!
            // if (uvjet == true) 
            //{ 
            //}

            // najčešča sintaksa
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
            // ovo nije najbolja praksa. Primjer dole!

            //  if (i > 10) Console.WriteLine("i je veči od 10");
            //  else Console.WriteLine("i nije veci od 10");
            //       Console.WriteLine("AAAAAAA");


            // puna sintaksa if naredbe : if, else, else if
            int b = 2;
            if (b == 1)
            {
             Console.WriteLine("Ne može");  //Ako je vrjednost 1 onda ulazi u "Ne može" fazu
            }
            else if (b > 5) 
            { 
             Console.WriteLine("OK");  //Ako je vrjednost > 5 onda ulazi u "OK" fazu
            } // jos moze ič nn else if djelova
            else  
            {
             Console.WriteLine("Ostalo"); //Ako je vrjednost svi ostali brojevi onda ulazi u "Ostalo" fazu
            }

            // operatori & i && (END I ENDEND) "AND"   Ujek upotrebljavamo 2 &&
            // & uvjet provjerava oba uvjeta
            // && koliko 1. uvjet nije zadovoljen, drugi se niti ne gleda
            int x = 2, y = 1;
            if (x == 1 && y == 1)  // x = FALSE  (ako je x = 2 iči če napred provjeravat i drugi kod)
            { 
             Console.WriteLine("x i y su 1");
            }
            
            // operatori  |  (PAJT) "OR" (AltGr + W) (alt + 124)  Ujek upotrebljavamo 2 ||
            // |  provjerava oba uvjeta
            // || koliko je prvi uvjet zadovoljen, ne gleda na drugi
            if (i > 1 || i == 0)
            {
             Console.WriteLine("ako je prvi uvjet zadovoljen ulazi se u if");
            }

            // if se može gnjezditi
            if (x == 3)
            {
              //int k = 9;  //ova če bit deklarirana samo ako je if (X==3)
                if (i > 0)
                {
                 Console.WriteLine("Zadovoljeno");
                }
                else 
                {
                 Console.WriteLine("NE");
                }
                
                // inline IF - tercijarni operator?
                x = 0;
                if (x == 0)
                {
                    Console.WriteLine("OK");
                }
                else 
                {
                    Console.WriteLine("NE");
                }

                // preduvjet je da if i else provode istu akciju - u ovom slučaju consolewriteline
               
                Console.WriteLine(x == 0 ? "OK" : "NE");  // prvo stavimo vrijednost onda ? i onda true : false








            }

        
        
        
        
        
        
        















        }
















    }
}

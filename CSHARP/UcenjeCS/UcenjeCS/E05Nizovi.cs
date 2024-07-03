using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {
        public static void Izvedi() 
        {

            // motivacija: treba ti 12 variabli za 12 temperatura različitih mjeseci
            // ono što znamo
            // int temp1, temp2, temp3, temp4; // ovo je loše rešenje


            // eng. Arrays (znači niz informacija)
            // hr. Polja

            // OVO SU SVE JEDNODIMENZIONALNI NIZOVI
            // [ AltGr + F 

            // definicija niza :
            int[] temperature = new int[12];  // največi problem nizova je što na početku moram znati broj nizova

          // nizovi počinju s indexom 0
          // 1. element niza je na indexu 0

          temperature[0] = -2;   // januar (0)
          temperature[1] = 0;
          //...
          temperature[11] = -3;  // december (11)
            
          // dužina niza (Lenght)
          Console.WriteLine(temperature.Length);    // ukupan broj elemenata

                  // zadnji se u pravilu ovako postavlja
                  temperature[temperature.Length - 1 ] = 0;   // napravili smo da zadnji element u nizu ima vrijednost 0
                                                              // (program čita 5,4,3,2,1 = i ta zadnji je 0)
                                                              // stavis 3 bit če na 3 mjestu vrijdnost 0 (70, 72, 0 , 125, 76)
            Console.WriteLine("**************************************************************");

            Console.WriteLine(temperature[1]);   // njegova vrijedost je 0

            /////// temperature[12] = 1;  greška prilikom izvođenja jer niz ide od 0 do 11

            Console.WriteLine(temperature);  // ispisuje:  System.Int32[] writeline nezna kako prikazati temperature pa stavi napis ...

            Console.WriteLine("**************************************************************");

            // ispisati sve elemente niza u jednom redu
            Console.WriteLine(string.Join(",",temperature));

            Console.WriteLine("**************************************************************");

            // skračeniji način
            int[] niz = { 2, 3, 4, 5, 56, 6, 3, 3 };

            // ispisati 56
            Console.WriteLine(niz[4]);

            string[] gradovi = { "Osjek", "Donji Miholjac", "Valpovo" };

            // ispisati zadnji grad
            Console.WriteLine(gradovi[gradovi.Length-1]);

            int[,] tablica = {
            { 1,2,3,},
            { 4,5,6 },
            { 7,8,9 }
            };

            // izpiši 6  ( tablica ide u redove onda u stupce) 

            Console.WriteLine(tablica[1,2]);

            // ispiši 9  
            Console.WriteLine(tablica[2,2]);

            // kako se radi trodimenzionalni niz
            int[,,] kocka = { };

            // tesaarect - 4 dimenzije

            int[,,] tesaarect = { };

            // multiverseint

            int[,,,,,,] multiverse = { };

            // nizovi mogu imati i različite tipove podataka

            object[] objekti = { "Ovo", 3,2.6, true};









        }

    }
}

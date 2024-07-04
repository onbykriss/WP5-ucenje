using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class vjezbanje
    {
        public static void Izvedi() 
        {

            int n = 5;
            int[,] tablica = new int[n , n];

            int broj = 1;         //vrednost je 1          
            int red = n - 1, stupac = n - 1;    //prvo idu redovi a onda stupci (n=5)
            int smjer = 0;         // 0 = lijevo, 1 = gore, 2 = desno, 3 = dolje

            while (broj <= n * n)   //nastavimo do koje vrijednosti če se ispisat brojevi u nasem primjeru (broj <= 5 x 5)
            {
                 tablica[red, stupac] = broj;  // primjer:red = 4, stupac = 4, broj = 1
                 broj++;  //da bo naslednja vrednost, ki jo vnesemo v tabelo, za 1 večja od prejšnje
               
                 switch (smjer)
                 {
                       case 0: // Lijevo
                            if (stupac > 0 && tablica[red, stupac - 1] == 0)  //stupac > 0: Provjera da li je stupac veći od 0
                                                                              // tablica[redak, stupac - 1] == 0: Provjera je li sljedeće polje lijevo prazno (vrijednost je 0)
                            {
                                stupac--;  //smanjujemo vrijednost stupca za 1, što znači da pomičemo jednu ćeliju ulijevo
                            }
                            else
                            {
                                smjer = 1; //Promjena smjera kretanja na gore
                                red--;   //premakne se za jedan redak gore
                            }
                            break;  //zaustavi rad

                       case 1: // Gore
                            if (red > 0 && tablica[red - 1, stupac] == 0) //red > 0: Provjera da li je red veći od 0
                                                                          // tablica[red - 1, stupac] == 0: provjera je li sljedeče polje iznad nas prazno (vrijednost je 0)
                            {
                                red--; //premakne se za jedan redak gore
                            }
                            else
                            {
                                smjer = 2;   //Promjena smjera kretanja u desno
                                stupac++;    //povećavamo vrijednost stupaca za 1
                            }
                            break;  //zaustavi rad

                       case 2: // Desno
                            if (stupac < n - 1 && tablica[red, stupac + 1] == 0)  //stupac < n - 1: Provjera da li je slijedeči stupac veći od 0
                                                                                  // tablica[red - 1, stupac] == 0: provjera je li sljedeče polje iznad nas prazno (vrijednost je 0)
                            {
                                stupac++;  //povećavamo vrijednost stupaca za 1
                            }
                            else
                            {
                                smjer = 3; //Promjena smjera kretanja na dole
                                red++;  //povećavamo vrijednost reda za 1
                            }
                            break;  //zaustavi rad

                       case 3: // Dolje
                            if (red < n - 1 && tablica[red + 1, stupac] == 0)  //red < n - 1: Provjera da li je slijedeči red veći od 0
                            {                                                //tablica[red + 1, stupac] == 0: Provjera je li sljedeći redak u istom stupcu prazan
                                red++; //povećavamo vrijednost reda za 1
                            }
                            else
                            {
                                smjer = 0;   ////Promjena smjera kretanja u lijepo
                                stupac--;   //smanjujemo vrijednost stupca za 1, što znači da pomičemo jednu ćeliju ulijevo
                            }
                            break;  //zaustavi rad
                 }
            }

            // Ispis tablice
            for (int i = 0; i < n; i++)  //Ova petlja prolazi kroz sve redove tablice
            {
               for (int j = 0; j < n; j++) //Ova petlja prolazi kroz sve stupce tablice
               {
                 Console.Write(tablica[i, j].ToString("D2") + " "); // ToString("D2") pretvara vrijednost tablica[i, j] u string formatiran kao dvocifreni decimalni broj.
               }                                                      // + " " : odvojeno sa razmakom
               Console.WriteLine();
            }
            
        }


    }

}


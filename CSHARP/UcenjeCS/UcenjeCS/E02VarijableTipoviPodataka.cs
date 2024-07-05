using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodataka
    {




        public static void Izvedi() 
        {



            // deklaracija varijabla
            int i;

            // dodjeljivanje vridnosti - operator dodjeljivanje =
            i = 7;

            // korištenje varijable
            Console.WriteLine(i);

            // učitanje broja od korisnik
            // pročitati Why Good Programmers Are lazy and Dumb - https://blogoscoped.com/archive/2005-08-24-n14.html

            Console.Write("Molim upisati cijeli broj veči on nule: ");


            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine(broj+1);

            Console.WriteLine("**********************************************************");
            // za decimalne brojeve čemo koristiti Float

            Console.WriteLine("Unesi decimalni broj (, je oznaka za decimalni broj): ");
            Console.WriteLine(float.Parse(Console.ReadLine())+1);
            bool uvjet = false;
            Console.WriteLine(uvjet);
            
            Console.WriteLine("**********************************************************");

            // operatori za rad s verijablama
            // =,+,-,*,/
            // == operator uspoređivanja, tipa bool
            // != različito, tipa bool


            int j = 3;

            Console.WriteLine(j==3);  // == operator uspoređivanja, tipa bool
            Console.WriteLine(j!= 6);  // != različito, tipa bool

            Console.WriteLine("**********************************************************");

            // increment i dekrement

            i = 0;
            i = i + 1;
            i += 1;
            i++;  // prvo koristi pa uvečaj
            ++i;  // prvo uvečaj pa koristi

            i = 1;
            Console.WriteLine(i++);  //1
            Console.WriteLine(i);   //2
            Console.WriteLine(++i); //3
            Console.WriteLine(i);   //3

            // dekrement je ista stvar samo u minu
            i--;
            --i;

            //prekrasni zadaci
            int x = 0, y = 1;
            x = ++x - y;  // x = 0, y = 1
            y = x-- + y;  // x = -1, y = 1
            Console.WriteLine(x + y);  // 0

            Console.WriteLine("**********************************************************");

            // prvo na početku dvosatnog vježbanja doma si zadati zadatak
            // na kraju dvosatnog vježbanja riješiti ga

            // operator modulo

            Console.WriteLine("9%2 = {0}", 9%2);
            Console.WriteLine("8%2 = {0}", 8%2);

            x = 5;
            y = 2;

            // int / int daje int
            // mora se raditi cast

            Console.WriteLine(x/(float)y);   // (float) cast u tip podataka float

          







        
        
        
        
        
        
        }









    }
}

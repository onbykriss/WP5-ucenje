using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10TryCatch
    {

        public static void Izvedi() 
        {

            int broj;

            while (true)
            {
                Console.WriteLine("Upiši broj: ");

                try
                {
                    broj = int.Parse(Console.ReadLine());
                    if (broj <= 0 || broj > 1000) 
                    {
                        Console.WriteLine("Broj mora biti između 1 i 1000");   //umjesto da napise da se
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unjeli broj");   //umjesto da napise da se
                                                              //sistem srušio jer je korisnik upisao
                                                              //slovo umjesto broj
                                                              // ON CE NAPISATI : NISTE UNJELI BROJ
                }
            }

            // siguran sam da variabla broj imati vrijednost
            Console.WriteLine("Hvala na unosu {0} broja", broj);

            // kako bi osigurali da čovjek unese ime
            
            string ime;
            do
            {
                Console.WriteLine("Koje je tvoje ime");
                ime = Console.ReadLine();
                if (ime.Trim().Length == 0)
                {
                    Console.WriteLine("Niste unjeli ime");
                    continue;
                }
                break;
            } while (true);
                

            
            Console.WriteLine("Vaše ime je >{0}< " + ime);



        }



    }
}

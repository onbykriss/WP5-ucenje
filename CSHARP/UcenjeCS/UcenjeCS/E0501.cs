using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E0501
    {
        public static void Izvedi() 
        {

            // Za unesenu riječ provjerite da li je palindrom?
            // Palindrom je riječ koja se jednako čita s obje strane
            // anavolimilovana, 02022020, ananabraparbanana, evolove, evoove

            string ime = "ananabraparbanana";
            bool Palindrom = false;

            for (int i = 0; i < ime.Length / 2; i++)
            {
                if (ime[i] == ime[ime.Length - 1 - i])
                {
                    Palindrom = false;
                    break;

                }
                else 
                {
                    Console.WriteLine(ime[i] + " nisu isti ");
                }
            }


            //if(Palindrom)
            //{
            //    Console.WriteLine("Riječ je Palindrom");
            //}
            //else 
            //{
            //    Console.WriteLine("Riječ nije Palindrom");
            //}

            Console.WriteLine("Riječ  {0} Palidrom", Palindrom? "JE": "NIJE");


        }


    }
}

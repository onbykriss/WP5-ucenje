using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Uvjetno_grananjeSwitch
    {

        public static void Izvedi()
        {
            // switch je višestrukno grananje

            int i = 0;

            switch (i)
            {

                case 0:
                    Console.WriteLine("Dobar");
                    break;
                case 1:
                    Console.WriteLine("Loš");
                    break;
                case 2:
                    Console.WriteLine("Zao");
                    break;
                default:
                    Console.WriteLine("Ostalo");
                    break;


                    // switch rasi s int, string, char i drugi 
                    //csharp switch doc  potrazi na internetu

                    char znak = 'T';
                    Console.WriteLine(znak);
                    Console.WriteLine((int)znak);





            
            }
        
        }
    }
}

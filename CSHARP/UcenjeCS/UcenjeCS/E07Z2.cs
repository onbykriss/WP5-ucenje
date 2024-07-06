using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07Z2
    {
        public static void Izvedi() 
        {

            int i = 0;
            int suma = 0;
            while (true)
            {
                i = int.Parse(Console.ReadLine());

                if (i == -1)
                {
                    break;
                }
                suma += 1;


            }
            Console.WriteLine(suma);





        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04Z1
    {

        public static void Izvedi()
        {


            // korisnik unosi brojčanu vrijednost ocjene od 1 do 5
            // program ispisuje slovnu ocjenu,
            // a ako korisnik nije unijeo ocjenu program ispisuje = broj nije ocjena

            Console.WriteLine("Unesite ocjenu između 1 i 5");
            int ocjena = int.Parse(Console.ReadLine());
           
            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("Negativno");
                    break;
                case 2:
                    Console.WriteLine("Nezadovoljivo");
                    break;
                case 3:
                    Console.WriteLine("Dobro");
                    break;
                case 4:
                    Console.WriteLine("Vrlo dobro");
                    break;
                case 5:
                    Console.WriteLine("Odličan");
                    break;
                default:
                    Console.WriteLine("Broj nije ocjena");
                    break;




            }







        }








    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{

    // program od korisnika traži unos cijelog broja
    // program ispisuje da li je uneseni broj paran ili ne


    internal class E03Z2
    {


        public static void Izvedi()
        {

            // program od korisnika traži unos dva cijela broja
            // program ispisuje manji

            //Console.WriteLine("Unesi cijeli broj");
            //int broj = int.Parse(Console.ReadLine());
            //if (broj % 2 == 0)   
            //{ 
                  //Console.WriteLine("Broj" + broj + "je paran");
            //}
            //else
            //{
                  //Console.WriteLine("Broj" + broj + "je neparan");
            //}

            //DZ



            // isti zadatak ali za tri unesena broja ispisati najmanji
            // rješenje od chatGPT ja
            int broj1, broj2, broj3;

            Console.WriteLine("Unesi prvi broj");
            broj1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi drugi broj");
            broj2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi treči broj");
            broj3 = int.Parse(Console.ReadLine());

            int najmanji = broj1;
            if (broj2 < najmanji)
            {
                najmanji = broj2; // Ako je drugi broj manji od trenutno najmanjeg, postaje najmanji
            }

            if (broj3 < najmanji)
            {
                najmanji = broj3; // Ako je treći broj manji od trenutno najmanjeg, postaje najmanji
            }

            Console.WriteLine("Najmanji broj je: " + najmanji);




        }


    }
}

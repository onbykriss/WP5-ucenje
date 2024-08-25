using System;


namespace ZavrsniRad
{
    internal class Zadatak
    {

        /*
         * 
         * Kreirati klase prema ERA dijagramu Vaše baze podataka
         * Implementirati nasljeđivanje i prepisati metodu ToString
         * 
         * Za svaku klasu napraviti po jedan konstruktor
         * 
         * Svaku klasu instancirati u ovoj klasu
         * 
         */

        public Zadatak()
        {
            //ovdje instancirati svaku kreiranu klasu jednom i dodjeliti svim svojstvima vrijednosti
        }

        public class OsnovnaKlasa
        {
            public int Id { get; set; }

            public OsnovnaKlasa(int id)
            {
                Id = id;
            }

            public override string ToString()
            {
                return $"ID: {Id}";
            }
        }



    }
}
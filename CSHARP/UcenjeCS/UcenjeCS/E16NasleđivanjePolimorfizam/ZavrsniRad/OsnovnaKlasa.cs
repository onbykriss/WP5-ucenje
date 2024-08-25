using System;

namespace ZavrsniRad
{
    public class OsnovnaKlasa
    {
        public int Id { get; set; }

        // Konstruktor sa svim parametrima
        public OsnovnaKlasa(int id)
        {
            Id = id;
        }

        // Konstruktor brez parametara
        public OsnovnaKlasa()
        {
        }

        // Metoda ToString
        public override string ToString()
        {
            return $"ID: {Id}";
        }
    }
}


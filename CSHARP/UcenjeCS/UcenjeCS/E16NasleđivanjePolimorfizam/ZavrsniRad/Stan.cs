using System;

namespace ZavrsniRad
{
    public class Stan : OsnovnaKlasa
    {
        public int Kvadratura { get; set; }
        public string Adresa { get; set; }
        public string Opremanje { get; set; }
        public string Slika { get; set; }

        public Stan(int id, int kvadratura, string adresa, string opremanje, string slika)
            : base(id)
        {
            Kvadratura = kvadratura;
            Adresa = adresa;
            Opremanje = opremanje;
            Slika = slika;
        }

        public Stan() : base()
        {
            Kvadratura = 0;
            Adresa = "N/A";
            Opremanje = "N/A";
            Slika = "N/A";
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Kvadratura: {Kvadratura}, Adresa: {Adresa}, Opremanje: {Opremanje}, Slika: {Slika}";
        }
    }
}
using System;


namespace ZavrsniRad
{
    public class Stan : OsnovnaKlasa
    {
        public int Kvadratura { get; set; }
        public string Adresa { get; set; }
        public string Oprema { get; set; }
        public string Slika { get; set; }

        public Stan(int id, int kvadratura, string adresa, string oprema, string slika)
            : base(id)
        {
            Kvadratura = kvadratura;
            Adresa = adresa;
            Oprema = oprema;
            Slika = slika;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Kvadratura: {Kvadratura}, Adresa: {Adresa}, Oprema: {Oprema}, Slika: {Slika}";
        }
    }
}

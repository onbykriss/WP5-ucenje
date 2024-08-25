using System;

namespace ZavrsniRad
{
    public class Zakupac : OsnovnaKlasa
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public Zakupac(int id, string ime, string prezime, string email, string telefon)
            : base(id)
        {
            Ime = ime;
            Prezime = prezime;
            Email = email;
            Telefon = telefon;
        }

        public Zakupac() : base()
        {
            Ime = "N/A";
            Prezime = "N/A";
            Email = "N/A";
            Telefon = "N/A";
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Ime: {Ime}, Prezime: {Prezime}, Email: {Email}, Telefon: {Telefon}";
        }
    }
}
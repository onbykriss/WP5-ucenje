using System;

namespace ZavrsniRad
{
    public class Zakupci : OsnovnaKlasa
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public Zakupci(int idZakupci, string ime, string prezime, string email, string telefon)
            : base(idZakupci)
        {
            Ime = ime;
            Prezime = prezime;
            Email = email;
            Telefon = telefon;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Ime: {Ime}, Prezime: {Prezime}, Email: {Email}, Telefon: {Telefon}";
        }
    }
}
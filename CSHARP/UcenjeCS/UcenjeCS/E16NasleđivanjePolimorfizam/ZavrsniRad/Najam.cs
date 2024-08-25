using System;

namespace ZavrsniRad
{
    public class Najam : OsnovnaKlasa
    {
        public int IdStanovi { get; set; }
        public int IdZakupci { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public decimal CijenaNajma { get; set; }

        public Najam(int id, int idStanovi, int idZakupci, DateTime datumPocetka, DateTime datumZavrsetka, decimal cijenaNajma)
            : base(id)
        {
            IdStanovi = idStanovi;
            IdZakupci = idZakupci;
            DatumPocetka = datumPocetka;
            DatumZavrsetka = datumZavrsetka;
            CijenaNajma = cijenaNajma;
        }

        public Najam() : base()
        {
            IdStanovi = 0;
            IdZakupci = 0;
            DatumPocetka = DateTime.MinValue;
            DatumZavrsetka = DateTime.MinValue;
            CijenaNajma = 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, IdStanovi: {IdStanovi}, IdZakupci: {IdZakupci}, DatumPocetka: {DatumPocetka.ToShortDateString()}, DatumZavrsetka: {DatumZavrsetka.ToShortDateString()}, CijenaNajma: {CijenaNajma:C}";
        }
    }
}

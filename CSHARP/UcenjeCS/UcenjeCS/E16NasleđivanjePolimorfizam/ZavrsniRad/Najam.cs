using System;


namespace ZavrsniRad
{
    public class Najmovi : OsnovnaKlasa
    {
        public int IdStanovi { get; set; }
        public int IdZakupci { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public decimal CijenaNajma { get; set; }

        public Najmovi(int idNajmovi, int idStanovi, int idZakupci, DateTime datumPocetka, DateTime datumZavrsetka, decimal cijenaNajma)
            : base(idNajmovi)
        {
            IdStanovi = idStanovi;
            IdZakupci = idZakupci;
            DatumPocetka = datumPocetka;
            DatumZavrsetka = datumZavrsetka;
            CijenaNajma = cijenaNajma;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Stan ID: {IdStanovi}, Zakupac ID: {IdZakupci}, Datum Pocetka: {DatumPocetka:yyyy-MM-dd}, Datum Završetka: {DatumZavrsetka:yyyy-MM-dd}, Cijena Najma: {CijenaNajma:C}";
        }
    }
}

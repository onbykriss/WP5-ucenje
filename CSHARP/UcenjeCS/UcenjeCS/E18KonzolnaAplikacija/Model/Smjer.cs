namespace UcenjeCS.E18KonzolnaAplikacija.Model
{
    internal class Smjer : Entitet
    {

        public Smjer()
        {
            this.Vaucer = false;
            Trajanje = 0;
            Cijena = 0;
            IzvodiSeOd = DateTime.Now;
            DatumPromjene = DateTime.Now;
        }

        public string? Naziv { get; set; }
        public int? Trajanje { get; set; } = 0; // mogu se i ovako dodjeliti početne vrijednosti
        public float? Cijena { get; set; }
        public DateTime? IzvodiSeOd { get; set; }
        public bool? Vaucer { get; set; }

        public DateTime? DatumPromjene { get; set; }

        public override string ToString()
        {
            return "Sifra=" + Sifra + " ,Naziv=" + Naziv + ", Trajanje=" + Trajanje + ", Cijena=" + Cijena +
                ", IzvodiSeOd=" + IzvodiSeOd + ", Verificiran=" + Vaucer;
        }

    }
}
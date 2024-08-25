using System;

namespace ZavrsniRad
{
    public class Zadatak
    {
        public Stan Stan { get; set; }
        public Zakupac Zakupac { get; set; }
        public Najam Najam { get; set; }

        public Zadatak()
        {
            // Inicializacija vsakega razreda z nekaterimi vrednostmi
            Stan = new Stan(1, 50, "Zell am See", "kuhinja, spavaonica, wc, terasa", "slika.jpg");
            Zakupac = new Zakupac(1, "Kristina", "Andric", "fashionbykriss@gmail.com", "031511271");
            Najam = new Najam(1, 1, 1, new DateTime(2024, 2, 7), new DateTime(2024, 2, 28), 1560);
        }
    }
}
using System;
using System.Text;

namespace UcenjeCS
{
    public class GeneratorLozinki
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesite dužinu lozinke:");
            int duzinaLozinke = int.Parse(Console.ReadLine());

            Console.WriteLine("Uključiti velika slova? (da/ne):");
            bool ukljucenaVelikaSlova = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Uključiti mala slova? (da/ne):");
            bool ukljucenaMalaSlova = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Uključiti brojeve? (da/ne):");
            bool ukljuceniBrojevi = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Uključiti interpunkcijske znakove? (da/ne):");
            bool ukljuceniInterpunkcijskiZnakovi = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Lozinka počinje s brojem? (da/ne):");
            bool pocinjeSBrojem = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Lozinka počinje s interpunkcijskim znakom? (da/ne):");
            bool pocinjeSInterpunkcijskimZnakom = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Lozinka završava s brojem? (da/ne):");
            bool zavrsavaSBrojem = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Lozinka završava s interpunkcijskim znakom? (da/ne):");
            bool zavrsavaSInterpunkcijskimZnakom = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Lozinka ima ponavljajuće znakove? (da/ne):");
            bool imaPonavljajuceZnakove = Console.ReadLine().ToLower() == "da";

            Console.WriteLine("Broj lozinki koje je potrebno generirati:");
            int brojLozinki = int.Parse(Console.ReadLine());

            for (int i = 0; i < brojLozinki; i++)
            {
                string lozinka = GenerirajLozinku(duzinaLozinke, ukljucenaVelikaSlova, ukljucenaMalaSlova, ukljuceniBrojevi, ukljuceniInterpunkcijskiZnakovi, pocinjeSBrojem, pocinjeSInterpunkcijskimZnakom, zavrsavaSBrojem, zavrsavaSInterpunkcijskimZnakom, imaPonavljajuceZnakove);
                Console.WriteLine($"Generirana lozinka {i + 1}: {lozinka}");
            }
        }

        private static string GenerirajLozinku(int duzina, bool velikaSlova, bool malaSlova, bool brojevi, bool interpunkcijskiZnakovi, bool pocinjeSBrojem, bool pocinjeSInterpunkcijskimZnakom, bool zavrsavaSBrojem, bool zavrsavaSInterpunkcijskimZnakom, bool ponavljajuciZnakovi)
        {
            const string velikaSlovaSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string malaSlovaSet = "abcdefghijklmnopqrstuvwxyz";
            const string brojeviSet = "0123456789";
            const string interpunkcijskiZnakoviSet = "!@#$%^&*()_+-=[]{}|;:,.<>?";

            StringBuilder lozinka = new StringBuilder();
            Random random = new Random();

            // Ustvarimo niz možnih znakov, namesto List<char>
            char[] moguciZnakovi = new char[0];

            if (velikaSlova)
            {
                Array.Resize(ref moguciZnakovi, moguciZnakovi.Length + velikaSlovaSet.Length);
                Array.Copy(velikaSlovaSet.ToCharArray(), 0, moguciZnakovi, moguciZnakovi.Length - velikaSlovaSet.Length, velikaSlovaSet.Length);
            }
            if (malaSlova)
            {
                Array.Resize(ref moguciZnakovi, moguciZnakovi.Length + malaSlovaSet.Length);
                Array.Copy(malaSlovaSet.ToCharArray(), 0, moguciZnakovi, moguciZnakovi.Length - malaSlovaSet.Length, malaSlovaSet.Length);
            }
            if (brojevi)
            {
                Array.Resize(ref moguciZnakovi, moguciZnakovi.Length + brojeviSet.Length);
                Array.Copy(brojeviSet.ToCharArray(), 0, moguciZnakovi, moguciZnakovi.Length - brojeviSet.Length, brojeviSet.Length);
            }
            if (interpunkcijskiZnakovi)
            {
                Array.Resize(ref moguciZnakovi, moguciZnakovi.Length + interpunkcijskiZnakoviSet.Length);
                Array.Copy(interpunkcijskiZnakoviSet.ToCharArray(), 0, moguciZnakovi, moguciZnakovi.Length - interpunkcijskiZnakoviSet.Length, interpunkcijskiZnakoviSet.Length);
            }

            // Začetni del lozinke
            if (pocinjeSBrojem)
            {
                lozinka.Append(brojeviSet[random.Next(brojeviSet.Length)]);
                duzina--;
            }
            else if (pocinjeSInterpunkcijskimZnakom)
            {
                lozinka.Append(interpunkcijskiZnakoviSet[random.Next(interpunkcijskiZnakoviSet.Length)]);
                duzina--;
            }

            // Generiranje preostalega dela lozinke
            for (int i = lozinka.Length; i < duzina; i++)
            {
                char noviZnak;
                do
                {
                    noviZnak = moguciZnakovi[random.Next(moguciZnakovi.Length)];
                } while (!ponavljajuciZnakovi && lozinka.ToString().Contains(noviZnak));

                lozinka.Append(noviZnak);
            }

            // Zaključni del lozinke
            if (zavrsavaSBrojem)
            {
                lozinka.Append(brojeviSet[random.Next(brojeviSet.Length)]);
            }
            else if (zavrsavaSInterpunkcijskimZnakom)
            {
                lozinka.Append(interpunkcijskiZnakoviSet[random.Next(interpunkcijskiZnakoviSet.Length)]);
            }

            return lozinka.ToString();
        }
    }
}

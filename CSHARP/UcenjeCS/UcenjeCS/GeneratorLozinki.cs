using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    public class GeneratorLozinki 
    {

        //Generator lozinki
        //Program od korisnika traži unos podataka:
        //Dužina lozinke
        //Uključena/isključena velika slova
        //Uključena/isključena mala slova
        //Uključeni/isključeni brojevi
        //Uključeni/isključeni interpunkcijski znakovi
        //Lozinka počinje ili ne s brojem
        //Lozinka počinje ili ne s interpunkcijskim znakom
        //Lozinka završava ili ne s brojem
        //Lozinka završava ili ne s interpunkcijskim znakom
        //Lozinka ima/nema ponavljajuće znakove
        //Broj lozinki koje je potrebno generirati

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

            List<char> moguciZnakovi = new List<char>();

            if (velikaSlova) moguciZnakovi.AddRange(velikaSlovaSet);
            if (malaSlova) moguciZnakovi.AddRange(malaSlovaSet);
            if (brojevi) moguciZnakovi.AddRange(brojeviSet);
            if (interpunkcijskiZnakovi) moguciZnakovi.AddRange(interpunkcijskiZnakoviSet);

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

            for (int i = lozinka.Length; i < duzina; i++)
            {
                char noviZnak;
                do
                {
                    noviZnak = moguciZnakovi[random.Next(moguciZnakovi.Count)];
                } while (!ponavljajuciZnakovi && lozinka.ToString().Contains(noviZnak));

                lozinka.Append(noviZnak);
            }

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

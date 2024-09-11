using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E14LjetniZadaci 
    { 
    
    }


        //Ljubavni kalkulator
        //Napraviti osnovni zadatak prema inicijalnoj slici koristeći rekurziju
        //Dodatno:
        //Osigurati unos imena (smije imati samo slova, bez brojeva i interpunkcijskih znakova)
        //promijeniti algoritam da zbraja dva susjedna broja (1 i 2, 3 i 4, 5 i 6, itd.) umjesto osnovnog algoritma 1 i zadnji, drugi i predzadnji itd.
        //Umjesto rekurzije koristiti petlju po izboru

        

class LjubavniKalkulator
    {
        static void Main()
        {
            // Unos imena
            Console.WriteLine("Unesite prvo ime (KRISTINA): ");
            string ime1 = Console.ReadLine().ToUpper();

            Console.WriteLine("Unesite drugo ime (TOMISLAV): ");
            string ime2 = Console.ReadLine().ToUpper();

            // Spajanje imena
            string kombinacija = ime1 + ime2;

            // Prebrojavanje učestalosti slova
            int[] brojeviIme1 = PrebrojSlova(ime1, kombinacija);
            int[] brojeviIme2 = PrebrojSlova(ime2, kombinacija);

            // Ispis brojeva ispod imena
            Console.WriteLine($"{ime1}: {string.Join("", brojeviIme1)}");
            Console.WriteLine($"{ime2}: {string.Join("", brojeviIme2)}");

            // Zbrajanje brojeva prema opisanom pravilu
            int[] zbrojeniBrojevi = ZbrojiBrojeve(brojeviIme1, brojeviIme2);

            // Ispis zbrojenih brojeva
            Console.WriteLine($"Zbrojeni brojevi: {string.Join(", ", zbrojeniBrojevi)}");

            // Daljnje zbrajanje dok ne dobijemo konačni postotak
            int postotakLjubavi = IzracunajPostotak(zbrojeniBrojevi);

            Console.WriteLine($"Ljubavni postotak između {ime1} i {ime2} je: {postotakLjubavi}%");
        }

        // Prebrojavanje koliko se puta svako slovo pojavljuje u kombinaciji
        static int[] PrebrojSlova(string ime, string kombinacija)
        {
            int[] brojevi = new int[ime.Length];
            for (int i = 0; i < ime.Length; i++)
            {
                brojevi[i] = kombinacija.Count(c => c == ime[i]);
            }
            return brojevi;
        }

        // Zbrajanje brojeva prema pravilu: prvi broj iz prvog imena i zadnji iz drugog imena
        static int[] ZbrojiBrojeve(int[] ime1Brojevi, int[] ime2Brojevi)
        {
            int duljina = Math.Max(ime1Brojevi.Length, ime2Brojevi.Length);
            int[] zbrojeniBrojevi = new int[duljina];

            for (int i = 0; i < ime1Brojevi.Length; i++)
            {
                int ime1 = ime1Brojevi[i];
                int ime2 = ime2Brojevi[ime2Brojevi.Length - 1 - i];
                zbrojeniBrojevi[i] = ime1 + ime2;
            }

            return zbrojeniBrojevi;
        }

        // Rekurzivno zbrajanje sve dok ne dobijemo dvocifreni broj (postotak)
        static int IzracunajPostotak(int[] brojevi)
        {
            while (brojevi.Length > 2)
            {
                int novaDuzina = brojevi.Length / 2 + brojevi.Length % 2;
                int[] noviBrojevi = new int[novaDuzina];

                for (int i = 0; i < brojevi.Length / 2; i++)
                {
                    noviBrojevi[i] = brojevi[i] + brojevi[brojevi.Length - 1 - i];
                }

                if (brojevi.Length % 2 != 0)
                {
                    noviBrojevi[novaDuzina - 1] = brojevi[brojevi.Length / 2];
                }

                brojevi = noviBrojevi;
            }

            return brojevi[0] * 10 + brojevi[1];
        }
    }


        //******************************************************************************************



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



        class PasswordGenerator
        {
            static Random random = new Random();

            static void Main(string[] args)
            {
                // Tražimo unos od korisnika za postavke
                Console.Write("Unesite željenu dužinu lozinke: ");
                int duzinaLozinke = int.Parse(Console.ReadLine());

                Console.Write("Uključiti velika slova (da/ne): ");
                bool ukljuciVelikaSlova = Console.ReadLine().ToLower() == "da";

                Console.Write("Uključiti mala slova (da/ne): ");
                bool ukljuciMalaSlova = Console.ReadLine().ToLower() == "da";

                Console.Write("Uključiti brojeve (da/ne): ");
                bool ukljuciBrojeve = Console.ReadLine().ToLower() == "da";

                Console.Write("Uključiti interpunkcijske znakove (da/ne): ");
                bool ukljuciInterpunkcijske = Console.ReadLine().ToLower() == "da";

                Console.Write("Lozinka počinje s brojem (da/ne): ");
                bool pocinjeBrojem = Console.ReadLine().ToLower() == "da";

                Console.Write("Lozinka počinje s interpunkcijskim znakom (da/ne): ");
                bool pocinjeInterpunkcijskim = Console.ReadLine().ToLower() == "da";

                Console.Write("Lozinka završava s brojem (da/ne): ");
                bool zavrsavaBrojem = Console.ReadLine().ToLower() == "da";

                Console.Write("Lozinka završava s interpunkcijskim znakom (da/ne): ");
                bool zavrsavaInterpunkcijskim = Console.ReadLine().ToLower() == "da";

                Console.Write("Dozvoliti ponavljajuće znakove (da/ne): ");
                bool dozvoliPonavljanje = Console.ReadLine().ToLower() == "da";

                Console.Write("Koliko lozinki želite generirati: ");
                int brojLozinki = int.Parse(Console.ReadLine());

                // Generišemo lozinke
                for (int i = 0; i < brojLozinki; i++)
                {
                    string lozinka = GenerisiLozinku(duzinaLozinke, ukljuciVelikaSlova, ukljuciMalaSlova, ukljuciBrojeve, ukljuciInterpunkcijske, pocinjeBrojem, pocinjeInterpunkcijskim, zavrsavaBrojem, zavrsavaInterpunkcijskim, dozvoliPonavljanje);
                    Console.WriteLine($"Lozinka {i + 1}: {lozinka}");
                }
            }

            static string GenerisiLozinku(int duzina, bool ukljuciVelikaSlova, bool ukljuciMalaSlova, bool ukljuciBrojeve, bool ukljuciInterpunkcijske, bool pocinjeBrojem, bool pocinjeInterpunkcijskim, bool zavrsavaBrojem, bool zavrsavaInterpunkcijskim, bool dozvoliPonavljanje)
            {
                string velikaSlova = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string malaSlova = "abcdefghijklmnopqrstuvwxyz";
                string brojevi = "0123456789";
                string interpunkcija = "!@#$%^&*()-_=+[]{}|;:',.<>?/";

                StringBuilder moguciZnakovi = new StringBuilder();

                if (ukljuciVelikaSlova) moguciZnakovi.Append(velikaSlova);
                if (ukljuciMalaSlova) moguciZnakovi.Append(malaSlova);
                if (ukljuciBrojeve) moguciZnakovi.Append(brojevi);
                if (ukljuciInterpunkcijske) moguciZnakovi.Append(interpunkcija);

                if (moguciZnakovi.Length == 0)
                {
                    throw new ArgumentException("Morate uključiti barem jednu kategoriju znakova za generiranje lozinke.");
                }

                StringBuilder lozinka = new StringBuilder();
                int preostaliZnakovi = duzina;

                // Postavljamo početni znak ako je određeno da lozinka mora početi brojem ili interpunkcijskim znakom
                if (pocinjeBrojem)
                {
                    lozinka.Append(brojevi[random.Next(brojevi.Length)]);
                    preostaliZnakovi--;
                }
                else if (pocinjeInterpunkcijskim)
                {
                    lozinka.Append(interpunkcija[random.Next(interpunkcija.Length)]);
                    preostaliZnakovi--;
                }

                // Postavljamo završni znak ako je određeno da lozinka mora završavati brojem ili interpunkcijskim znakom
                char zavrsniZnak = '\0';
                if (zavrsavaBrojem)
                {
                    zavrsniZnak = brojevi[random.Next(brojevi.Length)];
                    preostaliZnakovi--;
                }
                else if (zavrsavaInterpunkcijskim)
                {
                    zavrsniZnak = interpunkcija[random.Next(interpunkcija.Length)];
                    preostaliZnakovi--;
                }

                // Dodavanje srednjih znakova lozinke
                while (preostaliZnakovi > 0)
                {
                    char noviZnak = moguciZnakovi[random.Next(moguciZnakovi.Length)];

                    // Ako ponavljanje nije dozvoljeno, proveravamo da li već imamo taj znak
                    if (!dozvoliPonavljanje && lozinka.ToString().Contains(noviZnak))
                    {
                        continue;
                    }

                    lozinka.Append(noviZnak);
                    preostaliZnakovi--;
                }

                // Dodajemo završni znak, ako je određen
                if (zavrsniZnak != '\0')
                {
                    lozinka.Append(zavrsniZnak);
                }

                return lozinka.ToString();
            }
        }





    }

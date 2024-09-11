using System;
using System.Collections.Generic;
using System.Linq;

namespace UcenjeCS
{
    public class E14LjetniZadaci2
    {
        public static void Izvedi()
        {
            // Unos imena
            Console.WriteLine("Vpisi svoje ime:");
            string ime1 = Console.ReadLine().ToUpper();

            Console.WriteLine("Vpisi ime svoje simpatije:");
            string ime2 = Console.ReadLine().ToUpper();

            // Spajanje imena
            string spojenaImena = ime1 + ime2;

            // Brojanje učestalosti slova u spojena imena
            var brojac = BrojSlova(spojenaImena);

            // Ispis slova i učestalosti
            PrikaziSlovaIUcestalost(spojenaImena, brojac);

            // Kreiraj listu brojeva
            var brojevi = PretvoriUListuBrojeva(spojenaImena, brojac);

            // Zbrajanje brojeva po pravilima
            List<int> rezultat = ZbrajajBrojeve(brojevi);

            Console.WriteLine("Ljubavni postotak između imena " + ime1 + " i " + ime2 + " je: " + rezultat[0] + rezultat[1] + "%");
        }

        // Funkcija za brojanje učestalosti slova
        static Dictionary<char, int> BrojSlova(string tekst)
        {
            var brojac = new Dictionary<char, int>();

            foreach (var slovo in tekst)
            {
                if (char.IsLetter(slovo))
                {
                    if (brojac.ContainsKey(slovo))
                    {
                        brojac[slovo]++;
                    }
                    else
                    {
                        brojac[slovo] = 1;
                    }
                }
            }

            return brojac;
        }

        // Funkcija za formatiranje slova u string
        static string FormatSlova(string tekst, int sirinaKolone)
        {
            return string.Join(" ", tekst.Select(slovo => slovo.ToString().PadLeft(sirinaKolone)));
        }

        // Funkcija za formatiranje učestalosti slova u string
        static string FormatUcestalost(Dictionary<char, int> brojac, string tekst, int sirinaKolone)
        {
            var ucestalosti = new List<string>();

            foreach (var slovo in tekst)
            {
                if (brojac.ContainsKey(slovo))
                {
                    ucestalosti.Add(brojac[slovo].ToString().PadLeft(sirinaKolone));
                }
                else
                {
                    ucestalosti.Add(" ".PadLeft(sirinaKolone));
                }
            }

            return string.Join(" ", ucestalosti);
        }

        // Funkcija za ispis slova i njihove učestalosti
        static void PrikaziSlovaIUcestalost(string tekst, Dictionary<char, int> brojac)
        {
            int sirinaKolone = 2; // Širina svake kolone

            // Ispis slova
            Console.WriteLine(FormatSlova(tekst, sirinaKolone));

            // Ispis učestalosti ispod slova
            Console.WriteLine(FormatUcestalost(brojac, tekst, sirinaKolone));
        }

        // Funkcija za pretvaranje učestalosti slova u listu brojeva
        static List<int> PretvoriUListuBrojeva(string tekst, Dictionary<char, int> brojac)
        {
            var brojevi = new List<int>();

            foreach (var slovo in tekst)
            {
                if (brojac.ContainsKey(slovo))
                {
                    brojevi.Add(brojac[slovo]);
                }
            }

            return brojevi;
        }

        // Funkcija za zbrajanje brojeva prema pravilima (prvi s zadnjim, drugi s predzadnjim...)
        static List<int> ZbrajajBrojeve(List<int> brojevi)
        {
            while (brojevi.Count > 2)
            {
                List<int> noviBrojevi = new List<int>();

                int start = 0;
                int end = brojevi.Count - 1;

                // Zbrajanje prvog i zadnjeg, drugog i predzadnjeg, itd.
                while (start < end)
                {
                    int zbroj = brojevi[start] + brojevi[end];

                    // Ako je zbroj dvocifren, razdvoji ga na znamenke
                    if (zbroj >= 10)
                    {
                        noviBrojevi.Add(zbroj / 10);
                        noviBrojevi.Add(zbroj % 10);
                    }
                    else
                    {
                        noviBrojevi.Add(zbroj);
                    }

                    start++;
                    end--;
                }

                // Ako ima neparan broj brojeva, dodaj srednji broj
                if (start == end)
                {
                    noviBrojevi.Add(brojevi[start]);
                }

                // Prikaz svakog koraka
                Console.WriteLine(string.Join(" ", noviBrojevi));
                brojevi = noviBrojevi;
            }

            return brojevi;
        }
    }
}

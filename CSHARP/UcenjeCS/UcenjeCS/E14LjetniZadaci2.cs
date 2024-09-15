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

            // Kreiraj niz brojeva
            int[] brojevi = PretvoriUNizBrojeva(spojenaImena, brojac);

            // Zbrajanje brojeva po pravilima
            int[] rezultat = ZbrajajBrojeve(brojevi);

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
            var ucestalosti = new string[tekst.Length];

            for (int i = 0; i < tekst.Length; i++)
            {
                char slovo = tekst[i];
                if (brojac.ContainsKey(slovo))
                {
                    ucestalosti[i] = brojac[slovo].ToString().PadLeft(sirinaKolone);
                }
                else
                {
                    ucestalosti[i] = " ".PadLeft(sirinaKolone);
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

        // Funkcija za pretvaranje učestalosti slova u niz brojeva
        static int[] PretvoriUNizBrojeva(string tekst, Dictionary<char, int> brojac)
        {
            int[] brojevi = new int[tekst.Length];
            int index = 0;

            foreach (var slovo in tekst)
            {
                if (brojac.ContainsKey(slovo))
                {
                    brojevi[index++] = brojac[slovo];
                }
            }

            // Smanjimo niz na stvarnu veličinu  (Array)
            Array.Resize(ref brojevi, index);

            return brojevi;
        }

        // Funkcija za zbrajanje brojeva prema pravilima (prvi s zadnjim, drugi s predzadnjim...)
        static int[] ZbrajajBrojeve(int[] brojevi)
        {
            while (brojevi.Length > 2)
            {
                int[] noviBrojevi = new int[brojevi.Length];

                int start = 0;
                int end = brojevi.Length - 1;
                int index = 0;

                // Zbrajanje prvog i zadnjeg, drugog i predzadnjeg, itd.
                while (start < end)
                {
                    int zbroj = brojevi[start] + brojevi[end];

                    // Ako je zbroj dvocifren, razdvoji ga na znamenke
                    if (zbroj >= 10)
                    {
                        noviBrojevi[index++] = zbroj / 10;
                        noviBrojevi[index++] = zbroj % 10;
                    }
                    else
                    {
                        noviBrojevi[index++] = zbroj;
                    }

                    start++;
                    end--;
                }

                // Ako ima neparan broj brojeva, dodaj srednji broj
                if (start == end)
                {
                    noviBrojevi[index++] = brojevi[start];
                }

                // Smanjimo niz na stvarnu veličinu (Array)
                Array.Resize(ref noviBrojevi, index);

                // Prikaz svakog koraka
                Console.WriteLine(string.Join(" ", noviBrojevi));

                brojevi = noviBrojevi;
            }

            return brojevi;
        }
    }
}

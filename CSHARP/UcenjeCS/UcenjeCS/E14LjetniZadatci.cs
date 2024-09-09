using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E14LjetniZadaci
    {


        //Ljetni zadaci:
        //Ciklična matrica
        //Napraviti osnovni zadatak prema inicijalnoj slici
        //Dodatno:
        //Osigurati unos brojeva redova i kolona u rasponu 2 do 50
        //Napraviti da nakon završetka generiranja jedne matrice pita želite li napraviti još jednu i tako sve dok ne unese NE
        //Napraviti opcije programa o smjeru kretanja brojeva:
        //1. dolje lijevo početak u smjeru kazaljke na satu (inicijalni zadatak)
        //2. dolje desno početak u smjeru kazaljke na satu
        //3. gore lijevo početak u smjeru kazaljke na satu
        //4. gore desno početak u kontra smjeru kazaljke na satu
        //5. dolje lijevo početak u kontra smjeru kazaljke na satu 
        //6. dolje desno početak u kontra smjeru kazaljke na satu
        //7. gore lijevo početak u kontra smjeru kazaljke na satu
        //8. gore desno početak u kontra smjeru kazaljke na satu
        //9. sredina (ono što je bio kraj u prvih 8 primjera) lijevo u smjeru kazaljke na satu
        //10. sredina (ono što je bio kraj u prvih 8 primjera) desno u smjeru kazaljke na satu
        //11. sredina (ono što je bio kraj u prvih 8 primjera) gore u smjeru kazaljke na satu
        //12. sredina (ono što je bio kraj u prvih 8 primjera) dolje u smjeru kazaljke na satu
        //13. sredina (ono što je bio kraj u prvih 8 primjera) lijevo u kontra smjeru kazaljke na satu
        //14. sredina (ono što je bio kraj u prvih 8 primjera) desno u kontra smjeru kazaljke na satu
        //15. sredina (ono što je bio kraj u prvih 8 primjera) gore u kontra smjeru kazaljke na satu
        //16. sredina (ono što je bio kraj u prvih 8 primjera) dolje u kontra smjeru kazaljke na satu

        //Formatirati brojeve da budu potpisati po pravilima matematike: jedinica ispod jedinice, desetica ispod desetice, stotica ispod stotice



        public static void Main()
        {
            do
            {
                Console.WriteLine("Unesite broj redova (2-50): ");
                int rows = UnosBroja(2, 50);
                Console.WriteLine("Unesite broj kolona (2-50): ");
                int cols = UnosBroja(2, 50);

                Console.WriteLine("Odaberite smjer kretanja:");
                Console.WriteLine("1. Dolje lijevo - smjer kazaljke na satu");
                Console.WriteLine("2. Dolje desno - smjer kazaljke na satu");
                Console.WriteLine("3. Gore lijevo - smjer kazaljke na satu");
                Console.WriteLine("4. Gore desno - kontra smjer kazaljke na satu");
                Console.WriteLine("5. Dolje lijevo - kontra smjer kazaljke na satu");
                Console.WriteLine("6. Dolje desno - kontra smjer kazaljke na satu");
                Console.WriteLine("7. Gore lijevo - kontra smjer kazaljke na satu");
                Console.WriteLine("8. Gore desno - kontra smjer kazaljke na satu");
                //Console.WriteLine("9. Opcija s početkom iz sredine");

                int opcija = UnosBroja(1, 8); // Za sada koristimo prvih 8 opcija.

                int[,] matrix = new int[rows, cols];
                GenerirajMatricu(matrix, opcija);

                IspisiMatricu(matrix);

                Console.WriteLine("Želite li generirati još jednu matricu? (DA/NE)");
            } while (Console.ReadLine().ToUpper() == "DA");
        }

        // Metoda za unos broja s validacijom
        static int UnosBroja(int min, int max)
        {
            int broj;
            while (!int.TryParse(Console.ReadLine(), out broj) || broj < min || broj > max)
            {
                Console.WriteLine($"Unesite broj između {min} i {max}:");
            }
            return broj;
        }

        // Metoda za generiranje matrice prema zadanoj opciji
        static void GenerirajMatricu(int[,] matrix, int opcija)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int broj = 1;

            int top = 0, bottom = rows - 1, left = 0, right = cols - 1;

            switch (opcija)
            {
                case 1: // Dolje lijevo, smjer kazaljke na satu
                    while (top <= bottom && left <= right)
                    {
                        for (int i = bottom; i >= top; i--) // dolje prema gore
                            matrix[i, left] = broj++;

                        left++;

                        for (int i = left; i <= right; i++) // lijevo prema desno
                            matrix[top, i] = broj++;

                        top++;

                        if (left <= right)
                        {
                            for (int i = top; i <= bottom; i++) // gore prema dolje
                                matrix[i, right] = broj++;

                            right--;
                        }

                        if (top <= bottom)
                        {
                            for (int i = right; i >= left; i--) // desno prema lijevo
                                matrix[bottom, i] = broj++;

                            bottom--;
                        }
                    }
                    break;
                    
                // Opcija 2: Dolje desno - smjer kazaljke na satu

                case 2: // Dolje desno, smjer kazaljke na satu
                    while (top <= bottom && left <= right)
                    {
                        // Desno prema gore
                        for (int i = bottom; i >= top; i--) // dolje prema gore
                            matrix[i, right] = broj++;

                        right--;

                        // Gore prema lijevo
                        for (int i = right; i >= left; i--) // desno prema lijevo
                            matrix[top, i] = broj++;

                        top++;

                        if (left <= right)
                        {
                            // Lijevo prema dolje
                            for (int i = top; i <= bottom; i++) // gore prema dolje
                                matrix[i, left] = broj++;

                            left++;
                        }

                        if (top <= bottom)
                        {
                            // Dolje prema desno
                            for (int i = left; i <= right; i++) // lijevo prema desno
                                matrix[bottom, i] = broj++;

                            bottom--;
                        }
                    }
                    break;

                case 3: // Gore lijevo, smjer kazaljke na satu
                    while (top <= bottom && left <= right)
                    {
                        // Lijevo prema desno
                        for (int i = left; i <= right; i++)
                            matrix[top, i] = broj++;

                        top++;

                        // Gore prema dolje
                        for (int i = top; i <= bottom; i++)
                            matrix[i, right] = broj++;

                        right--;

                        if (top <= bottom)
                        {
                            // Desno prema lijevo
                            for (int i = right; i >= left; i--)
                                matrix[bottom, i] = broj++;

                            bottom--;
                        }

                        if (left <= right)
                        {
                            // Dolje prema gore
                            for (int i = bottom; i >= top; i--)
                                matrix[i, left] = broj++;

                            left++;
                        }
                    }
                    break;

                case 4: // Gore desno, kontra smjer kazaljke na satu
                    while (top <= bottom && left <= right)
                    {
                        // Gore prema dolje
                        for (int i = top; i <= bottom; i++)
                            matrix[i, right] = broj++;

                        right--;

                        // Desno prema lijevo
                        for (int i = right; i >= left; i--)
                            matrix[bottom, i] = broj++;

                        bottom--;

                        if (top <= bottom)
                        {
                            // Dolje prema gore
                            for (int i = bottom; i >= top; i--)
                                matrix[i, left] = broj++;

                            left++;
                        }

                        if (left <= right)
                        {
                            // Lijevo prema desno
                            for (int i = left; i <= right; i++)
                                matrix[top, i] = broj++;

                            top++;
                        }
                    }
                    break;

                case 5: // Dolje lijevo, kontra smjer kazaljke na satu
                    while (top <= bottom && left <= right)
                    {
                        // Dolje prema gore
                        for (int i = bottom; i >= top; i--)
                            matrix[i, left] = broj++;

                        left++;

                        // Lijevo prema desno
                        for (int i = left; i <= right; i++)
                            matrix[top, i] = broj++;

                        top++;

                        if (left <= right)
                        {
                            // Gore prema dolje
                            for (int i = top; i <= bottom; i++)
                                matrix[i, right] = broj++;

                            right--;
                        }

                        if (top <= bottom)
                        {
                            // Desno prema lijevo
                            for (int i = right; i >= left; i--)
                                matrix[bottom, i] = broj++;

                            bottom--;
                        }
                    }
                    break;

                case 6: // Dolje desno, kontra smjer kazaljke na satu
                    while (top <= bottom && left <= right)
                    {
                        // Desno prema lijevo
                        for (int i = right; i >= left; i--)
                            matrix[bottom, i] = broj++;

                        bottom--;

                        // Gore prema dolje
                        for (int i = bottom; i >= top; i--)
                            matrix[i, left] = broj++;

                        left++;

                        if (left <= right)
                        {
                            // Lijevo prema desno
                            for (int i = left; i <= right; i++)
                                matrix[top, i] = broj++;

                            top++;
                        }

                        if (top <= bottom)
                        {
                            // Dolje prema gore
                            for (int i = top; i <= bottom; i++)
                                matrix[i, right] = broj++;

                            right--;
                        }
                    }
                    break;

                case 7: // Gore lijevo, kontra smjer kazaljke na satu
                    while (top <= bottom && left <= right)
                    {
                        // Gore prema dolje
                        for (int i = top; i <= bottom; i++)
                            matrix[i, left] = broj++;

                        left++;

                        // Lijevo prema desno
                        for (int i = left; i <= right; i++)
                            matrix[bottom, i] = broj++;

                        bottom--;

                        if (left <= right)
                        {
                            // Dolje prema gore
                            for (int i = bottom; i >= top; i--)
                                matrix[i, right] = broj++;

                            right--;
                        }

                        if (top <= bottom)
                        {
                            // Desno prema lijevo
                            for (int i = right; i >= left; i--)
                                matrix[top, i] = broj++;

                            top++;
                        }
                    }
                    break;

                case 8: // Gore desno, kontra smjer kazaljke na satu
                    while (top <= bottom && left <= right)
                    {
                        // Desno prema lijevo
                        for (int i = right; i >= left; i--)
                            matrix[top, i] = broj++;

                        top++;

                        // Gore prema dolje
                        for (int i = top; i <= bottom; i++)
                            matrix[i, left] = broj++;

                        left++;

                        if (top <= bottom)
                        {
                            // Lijevo prema desno
                            for (int i = left; i <= right; i++)
                                matrix[bottom, i] = broj++;

                            bottom--;
                        }

                        if (left <= right)
                        {
                            // Dolje prema gore
                            for (int i = bottom; i >= top; i--)
                                matrix[i, right] = broj++;

                            right--;
                        }
                    }
                    break;




            }
        }

        // Metoda za ispisivanje matrice s formatiranjem  
        static void IspisiMatricu(int[,] matrix)
        {
            int maxBroj = matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
            int maxWidth = maxBroj.ToString().Length;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(maxWidth) + " ");
                }
                Console.WriteLine();
            }
        }

        //******************************************************************************************


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
            Console.WriteLine("Unesite prvo ime (MARTA): ");
            string ime1 = Console.ReadLine().ToUpper();

            Console.WriteLine("Unesite drugo ime (MANUEL): ");
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



    //Kada završite sve zadatke s svim opcijama javite se na email pa ću poslati nove :)




}
}
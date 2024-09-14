using System;

namespace UcenjeCS
{
    internal class Ciklicna
    {
        public static void Izvedi()
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
                Console.WriteLine($"Unesite broj između {min} in {max}:");
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

        // Metoda za ispisivanje matrice s formatiranjem na 3 znamenke s praznim mjestima
        static void IspisiMatricu(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // Formatiraj broj na 3 znaka, koristeći razmake za popunjavanje
                    Console.Write(matrix[i, j].ToString().PadLeft(3, ' ') + " ");
                }
                Console.WriteLine(); // Prelazak u novi red nakon svake iteracije kroz kolone
            }
        }
    }
}
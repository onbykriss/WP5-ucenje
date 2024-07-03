using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class vjezbanje
    {
        public static void Izvedi() 
        {

                int n = 5;
                int[,] tablica = new int[5, 5];

                int broj = 1;
                int red = n - 1, stupac = n - 1;
                int smjer = 0;                      // 0 = lijevo, 1 = gore, 2 = desno, 3 = dolje

                while (broj <= n * n)
                {
                    tablica[red, stupac] = broj;
                    broj++;

                    switch (smjer)
                    {
                        case 0: // Lijevo
                            if (stupac > 0 && tablica[red, stupac - 1] == 0)
                            {
                                stupac--;
                            }
                            else
                            {
                                smjer = 1;
                                red--;
                            }
                            break;
                        case 1: // Gore
                            if (red > 0 && tablica[red - 1, stupac] == 0)
                            {
                                red--;
                            }
                            else
                            {
                                smjer = 2;
                                stupac++;
                            }
                            break;
                        case 2: // Desno
                            if (stupac < n - 1 && tablica[red, stupac + 1] == 0)
                            {
                                stupac++;
                            }
                            else
                            {
                                smjer = 3;
                                red++;
                            }
                            break;
                        case 3: // Dolje
                            if (red < n - 1 && tablica[red + 1, stupac] == 0)
                            {
                                red++;
                            }
                            else
                            {
                                smjer = 0;
                                stupac--;
                            }
                            break;
                    }
                }

                // Ispis tablice
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(tablica[i, j].ToString("D2") + " ");
                    }
                    Console.WriteLine();
                }
            
        }


    }

}


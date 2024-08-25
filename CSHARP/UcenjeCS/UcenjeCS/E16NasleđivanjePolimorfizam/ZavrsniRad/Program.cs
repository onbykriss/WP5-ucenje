using System;

namespace ZavrsniRad
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kreiranje instance razreda Zadatak
            var zadatak = new Zadatak();
            Console.WriteLine("Zadatak:");
            Console.WriteLine(zadatak.Stan.ToString());
            Console.WriteLine(zadatak.Zakupac.ToString());
            Console.WriteLine(zadatak.Najam.ToString());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17GenericiLambdaEkstenzije
{
    internal class Program
    {
        public Program()
        {

            // glavni problem rada s nizovima: Ograničeni s inicialnim brojem elemenata

            // Rješenje: Koristiti generičke klase
            // Klasa List je parametrizirana (TIPA) tipom podatak int i u intregeri variablu mogu iči samo brojevi
            List<int> integeri = new List<int>();

            integeri.Add(1);
            integeri.Add(21);

            Console.WriteLine(integeri[0]);
            // integeri.Add("2); NE MOŽE

            List<string> gradovi = new List<string>();

            gradovi.Add("Osijek");  // mjesto 0
            gradovi.Add("Valpovo");  // mjesto 1

            Console.WriteLine(gradovi[1]);

            List<Smjer> smjerovi = new List<Smjer>();

            smjerovi.Add(new Smjer() { Sifra = 11, Naziv = "WP" });
            smjerovi.Add(new() { Sifra = 7, Naziv = "RR" });
            smjerovi.Add(new() { Sifra = 9, Naziv = "WW" });

            // Zadatak: Iz liste smjerova ispisati broj 7
            Console.WriteLine(smjerovi[1].Sifra);  // "izpiši mi šifru koja se nalazi na 2. mjestu"

            // Zadatak: Iz liste smjerova ispisati naziv "RR"   
            Console.WriteLine(smjerovi[1].Naziv);

            //Obrada<string> p = new Obrada<string>();  // string ne nasleđuje entitet pa ne ide

            Obrada<Smjer> o1 = new Obrada<Smjer>();
            o1.ObjektObrade = new Smjer() { Sifra = 1, Naziv = "WP" };

            Obrada<Polaznik> o2 = new Obrada<Polaznik>();
            o2.ObjektObrade = new Polaznik() { Sifra = 2, Ime = "Pero", Prezime = "Perić" };


            o1.Obradi();
            o2.Obradi();



            // Kreirajte listu datuma i u nju dodajte dva datuma:   
            // 1. datum Vašeg rođenja
            // 2. datum današnji datum

            List<DateTime> datumi = new List<DateTime>();
            datumi.Add(new DateTime(1983, 2, 26, 15, 5, 0));
            datumi.Add(DateTime.Now);

            Console.WriteLine(datumi[0]);
            Console.WriteLine(datumi[1]);



            // Lambda izrazi
            Console.WriteLine(KlasicnaMetoda(2, 3));
            // => je lambda operator
            var Zbroj = (int x, int y) => x + y;

            Console.WriteLine(Zbroj(2, 3));

            var Algoritam = (int x, int y) =>
            {
                var t = x + 1;

                return t - y;
            };

            Console.WriteLine(Algoritam(2, 3));



            // Kreirajte lambda izraz koji za primljeni broj vraća da li je parni ili ne (bool)

            var Parni = (int i) => i % 2 == 0;

            Console.WriteLine(Parni(2));


            // ekstenzije

            var s = "Osijek";

            Console.WriteLine(s.LastOrDefault());

            Console.WriteLine(gradovi.LastOrDefault());

            Console.WriteLine(smjerovi.LastOrDefault());

            smjerovi[0].OdradiPosao();

            o2.ObjektObrade.OdradiPosao();


            o1.PrikazRadaSSuculjem();
            smjerovi[0].PrikazRadaSSuculjem();
            o2.ObjektObrade.PrikazRadaSSuculjem();


            smjerovi.Sort();
            Console.WriteLine(smjerovi.FirstOrDefault()?.Sifra);

            // costum sort brez korištenja implementacije sučulja IComparable

            smjerovi.Sort((s1, s2) => s1.Naziv.CompareTo(s2.Naziv));

            Console.WriteLine(smjerovi.FirstOrDefault()?.Naziv);

            o1.ListaZaObradu = smjerovi;
            o1.IzpisStavaka(TuMeObradi);

            o1.IzpisStavaka(s =>
            {
            Console.WriteLine("I bez poziva metode" + s.Naziv);
            });

            // Domača zadača: poigrati se s Func
            //// https://medium.com/@interviewer.live/func-and-action-in-c-a-complete-guide-dfe8cf31581c


        }

        public void TuMeObradi(Smjer s)
        {
            Console.WriteLine("Obrađujem u Programu smjer s pozivom metode" + s.Naziv);
        }


        public int KlasicnaMetoda(int x, int y)
        {
            return x + y;
        }
      




    }
}

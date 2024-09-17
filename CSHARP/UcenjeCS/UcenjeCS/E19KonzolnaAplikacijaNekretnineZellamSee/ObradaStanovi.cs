﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UcenjeCS.E19KonzolnaAplikacijaNekretnineZellamSee
{
    internal class ObradaStanovi
    {

        public List<model.Stanovi> Stanovi { get; set; }

        public ObradaStanovi()
        {
            Stanovi = new List<model.Stanovi>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Stanovi.Add(new() { Adresa = "Zell am See" });
            Stanovi.Add(new() { Adresa = "Saalfelden" });
            Stanovi.Add(new() { Adresa = "Kaprun" });
            Stanovi.Add(new() { Adresa = "Leogang" });
            Stanovi.Add(new() { Adresa = "Maria Alm" });
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad u stanovima");
            Console.WriteLine("1. Pregled svih stanova");
            Console.WriteLine("2. Pregled detalja pojedinog stana");
            Console.WriteLine("3. Dodaj novi stan");
            Console.WriteLine("4. Promjena podataka postoječeg stana");
            Console.WriteLine("5. Brisanje stana");
            Console.WriteLine("6. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (E11Metode.UcitajCijeliBroj("Odaberi stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziStanove();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PregledDetaljaPojedinogStana();
                    PrikaziIzbornik();
                    break;
                case 3:
                    UnosNovogStana();
                    PrikaziIzbornik();
                    break;
                case 4:
                    PromjeniPostojeciStan();
                    PrikaziIzbornik();
                    break;
                case 5:
                    break;
            }
        }

        private void PromjeniPostojeciStan()
        {
            PrikaziStanove();
            var odabrani = Stanovi[Pomocno.UcitajRasponBroja("Odaberi redni broj stana za promjenu",
                1, Stanovi.Count) - 1];

            if (Pomocno.UcitajRasponBroja("1. Mjenjaš sve\n2. Pojedinačna promjena", 1, 2) == 1)
            {
                odabrani.Adresa = Pomocno.UcitajString("Unesi novu adresu", true);
                odabrani.Kvadratura = E11Metode.UcitajCijeliBroj("Unesi novu kvadraturu", 1, int.MaxValue);
                odabrani.Oprema = Pomocno.UcitajString("Unesi novu opremu", true);
                odabrani.Slika = Pomocno.UcitajString("Unesi novu sliku", true);
            }
            else
            {
                odabrani.Kvadratura = E11Metode.UcitajCijeliBroj("Unesi novu kvadraturu", 1, int.MaxValue);
            }
        }

        private void PregledDetaljaPojedinogStana()
        {
            PrikaziStanove();
            var s = Stanovi[
                Pomocno.UcitajRasponBroja("Odaberi redni broj stana za detalje", 1, Stanovi.Count) - 1
                ];
            Console.WriteLine("--------------------");
            Console.WriteLine("Detalji stana:");
            Console.WriteLine("Idstana: " + s.Idstana);
            Console.WriteLine("Kvadratura: " + s.Kvadratura);
            Console.WriteLine("Adresa: " + s.Adresa);
            Console.WriteLine("Oprema: " + s.Oprema);
            Console.WriteLine("Slika: " + s.Slika);
            Console.WriteLine("--------------------");
        }

        private void ObrisiPostojeciStan()
        {
            PrikaziStanove();
            var odabrani = Stanovi[Pomocno.UcitajRasponBroja("Odaberi redni broj stana za Brisanje",
                1, Stanovi.Count) - 1];

            if (Pomocno.UcitajBool("Sigurno obrisati " + odabrani.Idstana + "? (DA/NE)", "da"))
            {
                Stanovi.Remove(odabrani);
            }

        }


        private void UnosNovogStana()
        {
            Stanovi.Add(new()
            {
                Sifra = E11Metode.UcitajCijeliBroj("Unesi adresu stana",1,int.MaxValue),
                Adresa = Pomocno.UcitajString("Unesi adresu stana"),
            });
        }

        private void PrikaziStanove()
        {
            if (Stanovi.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nema stanova u bazi");
                Console.ResetColor();
                return;
            }

            foreach (var s in Stanovi)
            {
                Console.WriteLine(s.Adresa);
            }
        }
}   }
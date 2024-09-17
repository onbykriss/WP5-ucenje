using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.E18KonzolnaAplikacija;

namespace UcenjeCS.E19KonzolnaAplikacijaNekretnineZellamSee
{
    internal class Izbornik
    {
        public ObradaStanovi ObradaStanovi { get; set; }

        //public ObradaNajmovi ObradaNajmovi { get; set; }

        //public ObradaZakupci ObradaZakupci { get; set; }

        public Izbornik()
        {
            Pomocno.DEV = true;
            ObradaStanovi = new ObradaStanovi();
            //ObradaNajmovi = new ObradaNajmovi();
            //ObradaZakupci = new ObradaZakupci();
            UcitajPodatke();
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        private void UcitajPodatke()
        {
            string docPath =
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (File.Exists(Path.Combine(docPath, "stanovi.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "stanovi.json"));
                ObradaStanovi.Stanovi = JsonConvert.DeserializeObject<List<model.Stanovi>>(file.ReadToEnd());
                file.Close();

            }
        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni Izbornik");
            Console.WriteLine("1. Stanovi");
            Console.WriteLine("2. Najmovi");
            Console.WriteLine("3. Zakupci");
            Console.WriteLine("4. Izlaz iz izbornika");
            OdabirOpcijeIzbornika();

        }

        private void OdabirOpcijeIzbornika()
        {
            
            switch (E11Metode.UcitajCijeliBroj("Odaberite stavku izbornika", 1, 4))
            {
                
                case 1:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    ObradaStanovi.PrikaziIzbornik();
                    Console.Clear();
                    PrikaziIzbornik();
                    break;
                    Console.ResetColor();
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hvala na korištenju aplikacije, doviđenja!");
                    break;
                    Console.ResetColor();
            }
            
        }
        private void PozdravnaPoruka()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************");
            Console.WriteLine("*** Nekretnine Console App v 1.0 ***");
            Console.WriteLine("************************************");
            Console.ResetColor();
        }
    }

}

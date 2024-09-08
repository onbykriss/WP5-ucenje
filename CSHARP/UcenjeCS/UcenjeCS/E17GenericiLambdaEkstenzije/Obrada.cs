﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E17GenericiLambdaEkstenzije
{
    internal class Obrada<T>:ISucelje where T : Entitet
    {
        public T? ObjektObrade { get; set; }

        public List<T>? ListaZaObradu { get; set; }

        public void Obradi()
        {
            Console.WriteLine(ObjektObrade?.Sifra);


        }

        public void Posao()
        {
            Console.WriteLine("Odrađujem posao u Obradi");
        }

        public void IzpisStavaka(Action<T> akcija)
        {
            ListaZaObradu?.ForEach(e => akcija(e));
        }

        public string PrimjerFunc(Func<T, string> func)
        {
            ListaZaObradu?.ForEach(e => Console.WriteLine(func(e)));
            return string.Empty;
        }
        

      


    }

}

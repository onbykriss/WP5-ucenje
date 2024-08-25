using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam
{
    internal class Entitet : Object  // ovo se podrazumjeva i ne mora se pisati
    {

        public int? Sifra { get; set; }

        public override string ToString()
        {
            return Sifra.ToString();
        }
    }
}
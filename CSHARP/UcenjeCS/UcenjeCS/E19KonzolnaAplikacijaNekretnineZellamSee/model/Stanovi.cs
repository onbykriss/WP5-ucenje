using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E19KonzolnaAplikacijaNekretnineZellamSee.model
{
    public class Stanovi : Entitet
    {
        public decimal Kvadratura { get; set; } 
        public string? Adresa { get; set; } 
        public string? Oprema { get; set; } 
        public string? Slika { get; set; }
    }
}

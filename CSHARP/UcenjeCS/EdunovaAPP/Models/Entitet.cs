using System.ComponentModel.DataAnnotations;

namespace EdunovaAPP.Models
{
    public abstract class Entitet
    {
        [Key] // dio EF ORM-a (EF = Entity framework), ORM = Object Relational Mapping
        public int? Sifra { get; set; }
    }
}

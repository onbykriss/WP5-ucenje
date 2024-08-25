using System;

namespace ZavrsniRad
{
    public class OsnovnaKlasa
    {
        
            public int Id { get; set; }

            public OsnovnaKlasa(int id)
            {
                Id = id;
            }

            public override string ToString()
            {
                return $"ID: {Id}";
            }
    }
}



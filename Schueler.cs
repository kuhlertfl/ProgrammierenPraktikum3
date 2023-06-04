using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammierenPraktikum3
{
    internal class Schueler : Person,ILernend
    {
        public string KlassenStufe { get; set; }
        public Schueler(string name , int alter , string stufe) : base(name, alter)
        {
            KlassenStufe = stufe;
        }
        public override string ToString()
        {
            return $"Name:{Name},Alter:{Alter},Stufe:{KlassenStufe}";
        }

    }
}

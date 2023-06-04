using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProgrammierenPraktikum3
{
    internal class Lehrer : Person
    {
        public string Fach { get; set; }
        public Lehrer(string name , int alter , string fach) : base(name, alter)
        {
            Fach = fach;
        }
        public override string ToString()
        {
            return $"Name:{Name},Alter:{Alter},Fach:{Fach}";
        }
    }
}

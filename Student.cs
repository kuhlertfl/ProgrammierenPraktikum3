using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammierenPraktikum3
{
    internal class Student : Person,ILernend
    {
        public string StudienGang { get; set; }
        public Student(string name , int alter , string studiengang) : base(name, alter)
        {
            StudienGang = studiengang;
        }
        public override string ToString()
        {
            return $"Name:{Name}, Alter:{Alter}, Studiengang:{StudienGang}";
        }
    }
}

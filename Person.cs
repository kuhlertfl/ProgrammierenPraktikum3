using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammierenPraktikum3
{
    internal class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Alter { get; set; }
        public Person(string name , int alter)
        {
            Name = name;
            Alter = alter;
        }
        public int CompareTo(Person p)
        {
            return Name.CompareTo(p.Name);
        }
        public override string ToString()
        {
            return $"Name:{Name}, Alter:{Alter}";
        }
    }
}

using System.Collections.Generic;

namespace ProgrammierenPraktikum3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Beispielelemente hinzufügen
            Schueler schueler1 = new Schueler("Max Mustermann", 15, "9A");
            Schueler schueler2 = new Schueler("Lisa Müller", 14, "8B");
            Student student1 = new Student("Peter Schmidt", 20, "Informatik");
            Student student2 = new Student("Sarah Meyer", 21, "Wirtschaft");
            Lehrer lehrer1 = new Lehrer("Hans Fischer", 35, "Mathematik");
            Lehrer lehrer2 = new Lehrer("Julia Weber", 40, "Geschichte");
            Person person1 = new Person("Michaela Schneider", 30);
            Person person2 = new Person("Markus Wagner", 45);
            

            SortedLinkedList<Person> list = new SortedLinkedList<Person>();
            // Elemente zur Liste hinzufügen
            list.Add(schueler1);
            list.Add(schueler2);
            list.Add(student1);
            list.Add(student2);
            list.Add(lehrer1);
            list.Add(lehrer2);
            list.Add(person1);
            list.Add(person2);
            
            foreach (Person p in list)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------");
            foreach (Person p in list)
            {
                if(p is ILernend)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
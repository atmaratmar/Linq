using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        public class Person
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }

        }
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>
            {
            new Person{ID=1,Name="Atmar",Gender="Male"},
            new Person{ID=2,Name="Mustafa",Gender="Male"},
            new Person{ID=1,Name="Mursal",Gender="Female"},
            new Person{ID=4,Name="Jazmin",Gender="Female"}
            };

            // The "Where" LINQ operator filters a sequence
            var highEarners =
                from Person in list
                where
                Person.Gender == "Female"
                select Person;

            foreach (var person in highEarners)
            {
                Console.WriteLine(person.Name);
            }

        }
    }
}

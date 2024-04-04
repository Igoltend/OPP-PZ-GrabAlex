// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Person {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public DateTime Birthday { get; set; }

//     public Person(string firstName, string lastName, DateTime birthday) {
//         FirstName = firstName;
//         LastName = lastName;
//         Birthday = birthday;
//     }
// }

// class Program {
//     static void Main(string[] args) {
//         List<Person> people = new List<Person>();


//         people.Add(new Person("John", "Doe", new DateTime(2002, 5, 10)));
//         people.Add(new Person("Alice", "Smith", new DateTime(1998, 8, 15)));
//         people.Add(new Person("Bob", "Johnson", new DateTime(2005, 3, 20)));
//         people.Add(new Person("Emily", "Brown", new DateTime(2001, 10, 5)));


//         var selectedPeople = people.Where(person => person.Birthday.Year > 2000)
//                                     .OrderBy(person => person.LastName)
//                                     .ThenBy(person => person.FirstName);

//         Console.WriteLine("Люди, які народилися після 2000 року:");
//         foreach (var person in selectedPeople) {
//             Console.WriteLine($"{person.LastName}, {person.FirstName} - {person.Birthday.ToShortDateString()}");
//         }
//     }
// }


using System;
using System.Collections.Generic;
using System.Linq;

record Person(string FirstName, string LastName, DateTime Birthday);

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

  
        people.Add(new Person("John", "Doe", new DateTime(1995, 5, 15)));
        people.Add(new Person("Jane", "Smith", new DateTime(2002, 3, 25)));
        people.Add(new Person("Alice", "Johnson", new DateTime(1998, 12, 10)));
        people.Add(new Person("Bob", "Brown", new DateTime(2005, 8, 5)));

    
        var filteredPeople = people.Where(p => p.Birthday.Year <= 2000)
                                    .OrderBy(p => p.LastName)
                                    .ThenBy(p => p.FirstName);

    
        foreach (var person in filteredPeople)
        {
            Console.WriteLine($"{person.LastName} {person.FirstName} - {person.Birthday.ToShortDateString()}");
        }
    }
}

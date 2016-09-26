using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> namesList = InitList();

            //IEnumerable<Person> queriedString =
            //    from person in namesList
            //    where person.Name.Equals("Lóránt")
            //    select person;

            //foreach (Person p in queriedString)
            //    Console.WriteLine(p);


            //namesList.Add(new Person { Name = "Lóránt", Speciality = "C#" });


            //var queriedStringToNewClass =
            //    from person in namesList
            //    where person.Name.Equals("Lóránt")
            //    select new { Name = "Csonka" + person.Name, Hates = "FUCK" + person.Speciality };

            //foreach (Person p in queriedString)
            //    Console.WriteLine(p);

            //IEnumerable<IGrouping<string, Person>> groupQuery =
            //    from person in namesList
            //    group person by person.Name;

            //foreach (var stateGroup in groupQuery)
            //{
            //    Console.WriteLine("******" + stateGroup.Key);
            //    foreach (var item in stateGroup)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //var namesWithIndex = namesList.Select((p, i) => new { person = p, index = i }).ToList();
            //foreach (var name in namesWithIndex)
            //{
            //    Console.WriteLine(name);
            //}

            //IEnumerable<Person> takeFirstThreeElement = namesList.Take(3);
            //PrintToConsolePersonEnumerable(takeFirstThreeElement);

            //var skipFirstThreeElement = namesList.Skip(3);
            //PrintToConsolePersonEnumerable(skipFirstThreeElement);

            //IOrderedEnumerable<Person> orderedCollection = namesList.OrderBy(n => n.Name);
            //orderedCollection.Print();

            //IEnumerable<IGrouping<string, Person>> groupQuery =
            //   namesList.GroupBy(x => x.Speciality);

            //foreach (var stateGroup in groupQuery)
            //{
            //    Console.WriteLine("******" + stateGroup.Key);
            //    foreach (var item in stateGroup)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //var firstThreeElement = namesList.Take(3);

            //var orderByName = firstThreeElement.OrderBy(x => x.Name);

            //orderByName.Print();

            var topQuery =
                from p in namesList
                let firstTwoChar = p.Speciality.ToString().Substring(0, 2)
                where firstTwoChar.ToString().StartsWith("A")
                orderby p.Name
                select new { p.Name, p.Speciality, firstTwoChar };

            foreach (var item in topQuery)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static List<Person> InitList()
        {
            return new List<Person> {
                    new Person {Name= "Roland", Speciality = "Android" },
                    new Person {Name= "Gergely", Speciality = "ASP" },
                    new Person {Name= "Zsolt", Speciality = "C#" },
                    new Person {Name= "Norbert", Speciality = "Windows Phone" },
                    new Person {Name= "Ferenc", Speciality = "Csócsó" },
                    new Person {Name= "Lóránt", Speciality = "Rendszergizda" },
                    new Person {Name= "Zsóót", Speciality = "C#" },
                    new Person {Name= "Robert", Speciality = "C#" },
                    new Person {Name= "Nobert", Speciality = "ASP" },
                    new Person {Name= "Roland", Speciality = "Csócsó" },
                    new Person {Name= "Ádám", Speciality = "Bűz" },};
        }
        static void PrintToConsolePersonEnumerable(IEnumerable<Person> personCollection)
        {
            foreach (var name in personCollection)
            {
                Console.WriteLine(name);
            }
        }
    }



    public class Person
    {
        public string Name { get; set; }

        public string Speciality { get; set; }

        public override string ToString()
        {
            return $"Hello!  My name is {Name}  and I'm great in :  {Speciality}. I will prove it to my new workplace.";
        }
    }

}

using System;
using System.Collections.Generic;

namespace SampleProject
{
    public static class MyExtension
    {

        public static void Print(this IEnumerable<Person> collection)
        {
            foreach (var person in collection)
            {
                Console.WriteLine("***********");
                Console.WriteLine(person);
            }
        }

    }
}

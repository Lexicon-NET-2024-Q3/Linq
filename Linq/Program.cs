﻿using System;

namespace Linq
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            IEnumerable<Person> people = GetPeople();

            //var allPeopleOver30 = people.Where(p => p.Age > 30).Select(p => p.Name); 
            var allPeopleOver30b = people.Where(IsOver30).Select(person => person.Name);

            var allPeopleOver30 = people.OursWhere(p => p.Age > 30).Select(p=>p.Name);
            var allPeopleOver30c = people.OursWhere(IsOver30).Select(p=>p.Name);


            //foreach (var person in allPeopleOver30)
            //{
            //    Console.WriteLine(person);
            //}
            //foreach (var person in allPeopleOver30b)
            //{
            //    Console.WriteLine(person);
            //}

            var sumOfAges = people.Where(p => p.Name == "Pelle")
                                  .Select(p => p.Age)
                                  .Sum();

            //Console.WriteLine(sumOfAges);

            IEnumerable<PersonDto> dtos = people.Where(p => p.Name == "Pelle")
                                   .Select(p => new PersonDto
                                   {
                                       Name = p.Name,
                                       NameLength = p.Name.Length
                                   });

            //foreach (var item in dtos)
            //{
            //    Console.WriteLine($"Name: {item.Name} NameLength: {item.NameLength}");
            //}

            var people2 = GetPeople();

            //people2.ForEach(p => Console.WriteLine(p));
            people2.ForEach(Console.WriteLine);
            //people2.ForEach(Test);

        }

        private static bool IsOver30(Person person)
        {
            return person.Age > 30; 
        }
        private static void Test(Person person)
        {
            Console.WriteLine(person);
        }
        private static List<Person> GetPeople()
        {
            return new List<Person>
            {
                new("Nisse", 20),
                new("Nisse", 21),
                new("Nisse", 22),
                new("Nisse", 23),
                new("Nisse", 24),
                new("Nisse", 25),
                new("Nisse", 26),
                new("Pelle", 65),
                new("Pelle", 60),
                new("Pelle", 62),
                new("Olle", 66),
                new("Sara", 54),
                new("Ida", 36),
                new("Fia", 45),
                new("Lisa", 45),
                new("Sophia-Magdalena", 32)
            };
        }
    }
}

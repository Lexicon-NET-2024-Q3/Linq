using System;

namespace Linq
{
    internal class Program
    {

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

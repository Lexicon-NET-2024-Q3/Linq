using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal static class Extensions
    {
        //internal static IEnumerable<Person> OursWhere(this List<Person> source, Func<Person, bool> predicate)
        //{
        //    foreach (Person person in source)
        //    {
        //        if (predicate(person))
        //        {
        //            yield return person; 
        //        }
        //    }
        //} 
        internal static IEnumerable<T> OursWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T item in source)
            {
                if (predicate(item))
                {
                    yield return item; 
                }
            }
        }
    }
}

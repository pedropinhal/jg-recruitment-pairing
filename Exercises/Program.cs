using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Create a custom generic pair, instantiate with two parameters, get the first parameter */
            var myPair = new Pair<string, int>("age", 28);

            Console.WriteLine(myPair.First);

            /* 2. Create a generic implementation of the linq WHERE clause */
            
            Func<int, bool> pred = (x) => x % 2 == 0;
            var list = new List<int> {1, 2, 3, 4, 5, 6};
            var result = list.MyWhere(pred);

            Console.WriteLine(pred(2));
            Console.WriteLine(string.Join(",", result.ToList()));


            /* 3. Implement FizzBuzz*/

            var fizzBuzz = new FizzBuzz();
            var resultBuzz = fizzBuzz.Run();
            Console.WriteLine(string.Join(",", resultBuzz.ToList()));


        }
    }

    static class WhereExtensions
    {
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> list, Func<T, bool> pred )
        {
            foreach (var item in list)
            {
                if (pred(item)) yield return item;
            }
        }
        
    }


    internal class Pair<T1, T2>
    {
        public T1 First { get; private set; }
        public T2 Second { get; private set; }
        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }
    }
    
}

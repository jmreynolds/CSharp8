using System;
using System.Collections.Generic;
using static System.Console;

namespace RangesAndIndices
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Names 1-3:");
            foreach (var name in GetRangeOfNames(1..4))
            {
                // Endpoint of range is EXCLUSIVE
                WriteLine(name);
            }

            WriteLine("Names 1-3 - using end index:");
            foreach (var name in GetRangeOfNames(1..^1))
            {
                WriteLine(name);
            }
        }
        static string[] names =
        {
            "Archimedes", "Pythagoras", "Euclid", "Socrates", "Plato"
        };
        static IEnumerable<string> GetRangeOfNames(Range range)
        {

            foreach (var name in names[range])
            {
                yield return name;
            }
        }
    }
}

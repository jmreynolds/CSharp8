using System;
using System.Collections.Generic;
using static System.Console;

namespace RangesAndIndices
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var name in GetNames())
            {
                WriteLine(name);
            }
        }

    static IEnumerable<string> GetNames()
    {
        string[] names =
        {
            "Archimedes", "Pythagoras", "Euclid", "Socrates", "Plato"
        };
        foreach (var name in names[1..4])
        {
            yield return name;
        }
    }
    }
}

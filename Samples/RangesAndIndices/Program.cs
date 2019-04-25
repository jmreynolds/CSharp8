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


            var words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };
            WriteLine($"The last word is: {words[^1]}");
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

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AsyncStream
{
    class Program
    {
        static string[] names ={"Archimedes", "Pythagoras", "Euclid", "Socrates", "Plato"};
        static async Task Main(string[] args)
        {
            // Must have the await foreach
            await foreach (var name in GetNamesAsync())
            {
                Console.WriteLine(name);
            }
        }
        
        // New return type - IASyncEnumerable
        public static async IAsyncEnumerable<string> GetNamesAsync()
        {
            foreach (var name in names)
            {
                await Task.Delay(1000);
                yield return name;
            }

        }
    }
}

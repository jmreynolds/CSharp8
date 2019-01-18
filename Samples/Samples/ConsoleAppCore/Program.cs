using System;

namespace ConsoleAppCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string foo = "foo";
            // string notnull = null;
            Console.WriteLine($"First Character of Foo is {foo[0]}");

            string? fooNull = null;
            if(!string.IsNullOrEmpty(fooNull))
                Console.WriteLine($"First Character of Foo is {fooNull[0]}");

            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}

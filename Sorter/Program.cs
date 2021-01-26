using System;

namespace Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            var sorter = new SorterLibrary.Sorter();
            Console.WriteLine("Hello! Please enter the one-liner string you would like to sort: (leave input blank to quit)");
            string stringToSort = Console.ReadLine();
            while (!string.IsNullOrEmpty(stringToSort))
            {
                Console.WriteLine($"Sorted: {sorter.SortHandCoded(stringToSort)}");
                Console.WriteLine("");
                Console.WriteLine("Please enter the one-liner string you would like to sort: (leave input blank to quit)");
                stringToSort = Console.ReadLine();
            }
            Console.WriteLine("Bye.");
        }
    }
}

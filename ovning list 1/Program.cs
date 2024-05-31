using System;
using System.Collections.Generic;

namespace övning_list._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            Console.WriteLine("Skriv in namn (tryck Enter för att avsluta):");

            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                names.Add(input);
                input = Console.ReadLine();
            }

            Console.WriteLine("\nNamn med bokstäverna baklänges:");
            foreach (var name in names)
            {
                char[] charArray = name.ToCharArray();
                Array.Reverse(charArray);
                string reversedName = new string(charArray);
                Console.WriteLine(reversedName);
            }
        }
    }
}

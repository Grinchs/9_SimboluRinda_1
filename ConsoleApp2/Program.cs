using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet simbolu rindu: ");
            string input = Console.ReadLine();

            foreach (char c in input)
            {
                int asciiCode = (int)c;
                Console.WriteLine($"{c}={asciiCode}");
            }

            int totalAsciiSum = 0;
            foreach (char c in input)
            {
                totalAsciiSum += (int)c;
            }

            Console.WriteLine($"Kodu summa: {totalAsciiSum}");

            Console.WriteLine("Ievadiet simbolu: ");
            char searchChar = Console.ReadKey().KeyChar;
            int charCount = CountCharOccurrences(input, searchChar);

            Console.WriteLine($"\nSimbols '{searchChar}' ir sastopams rindā {charCount} reizes");
        }

        // Metode, kas skaita simbola sastopamību rindā
        static int CountCharOccurrences(string input, char targetChar)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == targetChar)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
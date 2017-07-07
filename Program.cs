using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input numbers to equal out: ");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            EqualizeNumbers(first, second, third);
        }

        public static void EqualizeNumbers(int first, int second, int third)
        {
            while (first > second)
            {
                first--;
            }
            while (first > third)
            {
                first--;
            }
            while (second > first)
            {
                second--;
            }
            while (second > third)
            {
                second--;
            }
            while (third > first)
            {
                third--;
            }
            while (third > second)
            {
                third--;
            }

            Console.WriteLine($"{first} {second} {third}");
        }
    }
}

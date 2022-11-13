using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGB_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1-е целое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2-е целое число: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"Большим из двух чисел является: {a}" + $"\nМеньшим из двух чисел является: {b}");
            }
            else if (a < b)
            {
                Console.WriteLine($"Большим из двух чисел является: {b}" + $"\nМеньшим из двух чисел является: {a}");
            }
            else
            { 
                Console.WriteLine($"Числа {a} и {b} равны");
            }
        }
    }
}

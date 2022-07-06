using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Numeros pares de 1 a 100");

                for (int i = 0; i <= 100; i += 2)

                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"Number: {i}");

                }
                Console.ReadKey();
            }
        }
    }
}

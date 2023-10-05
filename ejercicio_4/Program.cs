using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Write("Ingresa un número: ");
            int num1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < num1; i++)
            {
                for (int j = 0; j < num1; j++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Write("Ingresa un número: ");
            int num2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < num2; i++)
            {
                for (int j = 0; j < num2; j++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    }


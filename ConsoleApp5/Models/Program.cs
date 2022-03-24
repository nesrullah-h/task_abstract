using ConsoleApp5.Models;
using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Menu----");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangular");
            Console.WriteLine("0. Quit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Kvadratin terefi:");
                    int side = Convert.ToInt32(Console.ReadLine());

                    Square num = new Square(side);

                    Console.WriteLine("Kvadratin sahesi:");
                    Console.WriteLine(num.CalcArea());
                    break;
                case "2":
                    Console.WriteLine("Uzunluq:");
                    Console.WriteLine("En:");
                    int length = Convert.ToInt32(Console.ReadLine());
                    int width = Convert.ToInt32(Console.ReadLine());
                    Rectangular sides = new Rectangular(width, length);
                    Console.WriteLine("Duzbucaqlinin sahesi");
                    Console.WriteLine(sides.CalcArea());




                    break;
                default:
                    break;
            }

        }
    }
}

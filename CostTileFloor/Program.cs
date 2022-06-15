using System;

namespace CostTileFloor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the shape of room - 1: Rectangle  2: Triangle");
            string userInput = Console.ReadLine();

            Console.Write("Please enter the width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the cost per unit: ");
            int unit = Convert.ToInt32(Console.ReadLine());

            double rectangleArea = Convert.ToDouble(width * length * unit);
            double triangleArea = Convert.ToDouble(width * length / 2) * unit ;

            if (userInput == "1")
            {
                Console.WriteLine($"If the spate of room is rectangle , the price is : {rectangleArea}");
            }
            else
            {
                Console.WriteLine($"The price for flooring it cost : ${triangleArea}");
            }        
        }
    }
}
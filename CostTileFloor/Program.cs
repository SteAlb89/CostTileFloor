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

            if (userInput == "1")
            {
                double rectangleArea = Convert.ToDouble(width * length);
                Console.WriteLine($"The total cost of labor is : $ {rectangleArea}  ");
            }
            else
            {
                double triangleArea = Convert.ToDouble(width * length) / 2;
                Console.WriteLine($"The total cost of labor is : $ {triangleArea}  ");

            }      
        }
    }
}
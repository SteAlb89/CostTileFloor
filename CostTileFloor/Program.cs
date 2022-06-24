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
            double triangleArea = Convert.ToDouble((width * length / 2) * unit);
            double rectangleTotal = Convert.ToDouble(rectangleArea / 20 * 86);
            double triangleTotal = Convert.ToDouble(triangleArea / 20 * 86);

            if (userInput == "1")
            {
                Console.WriteLine($"If the shape of room is rectangle , the price is : $ {rectangleArea}");
                Console.WriteLine($"The price for the labor cost : $ {rectangleArea} " );
            }
            else
            {
                Console.WriteLine($"If the shape of room is rectangle , the price is : $ {triangleArea}");
                Console.WriteLine($"The price for the labor cost : $ {triangleTotal}" );
            }       
           
        }

    }
}
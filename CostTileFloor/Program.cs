using System;

namespace CostTileFloor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Rectangle  2: Triangle");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.Write("Please enter the width: ");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the length: ");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter how many units you need: ");
                int unitCount = Convert.ToInt32(Console.ReadLine());
                Console.Write($"The total price for units is:  $ ");
                Console.WriteLine(width * length * unitCount);

                int rectangleArea = width * length;

                int hourPrice = 86;
                int priceLabor = (width * length * rectangleArea * hourPrice);
                Console.WriteLine($"The total cost of labor is : $ {priceLabor}  ");
            }
            else
            {

                Console.Write("Please enter the width: ");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the length: ");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter how many units you need: "); ;
                int unit = Convert.ToInt32(Console.ReadLine());
                Console.Write($"The total price for units is:  $ ");
                Console.WriteLine(width * length * unit);

                int triangleArea = (width * length) / 2;

                int hourPrice = 86;
                int priceLabor = (width * length * triangleArea * hourPrice);
                Console.WriteLine($"The total cost of labor is : $ {priceLabor}  ");


            }
         
        }
    }  
}
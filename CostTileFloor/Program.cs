using System;

namespace CostTileFloor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Rectangle  2: Triangle");
            string userInput = Console.ReadLine();

            if ( userInput == "1"  )
            {
                

                Console.Write("Please enter the width: ");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the length: ");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter how many units you need: ");
                int unit = Convert.ToInt32(Console.ReadLine());
                Console.Write($"The total price for units is:  $ ");
                Console.WriteLine(width * length * unit);

                int rectangle = width * length;

                int hourPrice = 86;
                int priceLabor = (width * length * rectangle * hourPrice);
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

                int triangle = (width * length) / 2;

                int hourPrice = 86;
                int priceLabor = (width * length * triangle * hourPrice);
                Console.WriteLine($"The total cost of labor is : $ {priceLabor}  ");


            }


            
           

         
        }
    }  
}
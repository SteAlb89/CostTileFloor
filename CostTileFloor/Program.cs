using System;

namespace CostTileFloor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Please enter the width: " );
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the length: " );
            int length  = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter how many units you need: "); ;
            int unit = Convert.ToInt32(Console.ReadLine());
            Console.Write($"The total price for units is:  $ ") ;
            Console.WriteLine(width * length * unit);

            double nonRectangle = (width * length) / 2;
            Console.WriteLine($"Flooring for non-rectangle rooms are :  {nonRectangle}");

            int hourPrice = 86;
            int priceLabor = (width * length * hourPrice);
            Console.WriteLine($"The total cost of labor is : $ {priceLabor}  ");
            
           

         
        }
    }  
}
using System;

namespace Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int numChildren;
            int numAdults;
            string destination;
            decimal childPrice;
            decimal adultPrice;
            decimal totalPrice;



            //Inputs
            Console.WriteLine("Please enter your destination (Enter P for Paris, B for Brussels, L for London)");
            destination = Console.ReadLine();

            Console.WriteLine("Please enter your number of adult tickets");
            numAdults = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your number of child tickets");
            numChildren = int.Parse(Console.ReadLine());

            //Process input
            switch (destination)    
            {
                case "P":
                adultPrice = 79.9M;
                childPrice = 49.9M;
                break;
                
                case "B":
                adultPrice = 109.90M;
                childPrice = 69.90M;
                break;
                
                case "L":
                adultPrice = 29.90M;
                childPrice = 14.9M;
                break;
                
                default:
                adultPrice = 0.0M;
                childPrice = 0.0M;
                break;
              }

            
            totalPrice = (adultPrice * numAdults) + (childPrice * numChildren);
            //Discount for buying 4 or more tickets
            if (numAdults + numChildren >=4)
            {
                totalPrice = totalPrice * (90M / 100M);
            }

            //Output

            Console.WriteLine("The price for an adult ticket is " + adultPrice);
            Console.WriteLine("The price for a child ticket is " + childPrice);

            Console.Write("The total price is " + totalPrice);
        }
    }
}

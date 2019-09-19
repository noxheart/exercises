using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
			Console.WriteLine("Är det fint väder?");
            input = Console.ReadLine();
            input = input.ToUpper();

            if (input == "J")
            {
                Console.WriteLine("Vi går på picknick!");
            }
            else if (input == "N")
            {
                Console.WriteLine("Vi stannar inne och läser en bok");
            }
            else 
            {
                Console.WriteLine("Jag förstår inte");
            }
        }
    }
}

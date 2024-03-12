using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random Number Generator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Random Number Generator!");
            Console.WriteLine("Choose The Least Number You Want:");
            string leastNum = Console.ReadLine();  
            Int32.TryParse(leastNum, out minValue);
            int minValue = 0;

            Console.WriteLine("Choose The Biggest Number You Want:");
            string biggestNum = Console.ReadLine();
            Int32.TryParse(biggestNum, out maxValue);
            int maxValue = 0; 

            Random rb = new Random();
            
            int randomNum = rb.Next(1, 201);
            Console.WriteLine(randomNum);
            
            if (randomNum == 69)
            {
                Console.WriteLine("NICE! Clearly You Won");
            }
            else if (randomNum % 2 == 0)
            {
                Console.WriteLine("Number is even!");
            }
            else if (randomNum % 2 > 0)
            {
                Console.WriteLine("Number is Odd! (just like your chances lol)");
            }

		}
	}
}

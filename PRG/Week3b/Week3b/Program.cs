using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random numbers
            // We need to create what's called a "Random" object and we can use that to create random numbers
            var rand = new Random();
            int firstNumber = rand.Next();
            Console.WriteLine("Result: {0}", firstNumber);

            int secondNumber = rand.Next(10);
            Console.WriteLine("Result: {0}", secondNumber);

            int thirdNumber = rand.Next(10) + 5;
            Console.WriteLine("Result: {0}", thirdNumber);

            int fourthNumber = rand.Next(100);
            Console.WriteLine(fourthNumber);

            int fifthNumber = rand.Next(11 - 10) + 10;
            Console.WriteLine(fifthNumber);

            int sixthNumber = rand.Next(51 - 25) + 25;
            Console.WriteLine(sixthNumber);

            int seventhNumber = rand.Next(501 - (-500)) - 500;
            Console.WriteLine(seventhNumber);

            int eighthNumber = rand.Next(1001);
            Console.WriteLine(eighthNumber);


            string input;
            int randomNumber = rand.Next(51);
        
            do
            {
                Console.WriteLine("Please guess a number");
                input = Console.ReadLine();
                var inputP = int.Parse(input);

                if (inputP > randomNumber && inputP != randomNumber)
                {
                    Console.WriteLine("Lower");
                } else if (inputP < randomNumber && inputP != randomNumber)
                {
                    Console.WriteLine("Higher");
                }

            } while (inputP != randomNumber);
                Console.WriteLine("You guessed correctly!");

            Console.ReadLine(); // pause
        }
    }
}



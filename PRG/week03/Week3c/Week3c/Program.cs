using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3c
{
    class Program
    {
        static void Main(string[] args)
        {

            /* A while loop checks a condition and runs the code
             * within the brackets until that condition is no longer true
             */

            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++; //increase by one otherwise it will never break out of the loop
            }

            Console.WriteLine("--------------"); 

            counter = 0;
            while (counter <= 25)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("--------------");

            counter = 10;
            while(counter <= 100)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("--------------");

            counter = 100;
            while(counter <= 1000)
            {
                Console.WriteLine(counter);
                counter = counter + 100;
            }

            Console.WriteLine("--------------");

            counter = -10;
            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("--------------");

            counter = 0;
            while (counter <= 100)
            {
                Console.WriteLine(counter);
                counter = counter + 25;
            }

            Console.WriteLine("--------------");

            counter = 0;
            while (counter <= 100)
            {
                Console.WriteLine(counter);
                if (counter < 50)
                {
                    counter = counter + 2;
                } else
                {
                    counter = counter + 5;
                }
            }


            const string USERNAME = "emiliokyp";
            const string PASSWORD = "password";



            var _signedIn = false;
            counter = 0;
            while (counter < 3)
            {
                Console.WriteLine("Please enter your username and password");
                var username = Console.ReadLine();
                var password = Console.ReadLine();

                if (username == USERNAME && password == PASSWORD)
                {
                    Console.WriteLine("Welcome, {0}", username);
                    _signedIn = true;
                    break;
                } else if (counter >= 3 && _signedIn)
                {
                    Console.WriteLine("You have been locked out for 24hours");
                } 
                counter++;
            } 

            
           


        }
    }
}

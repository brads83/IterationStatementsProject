using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO


            var numbers = new List<int>(); //Create a List called "numbers"
            var init = 0; //Create a variable of type int with an initializer of 0



            // Create a do-while loop

            do
            {
                // Increment your variable by 1
                init++;
                // Then add your variable to "numbers"
                numbers.Add(init);
            } while (init < 100);// While your variable is less than 100




            // Create a while loop
            // While your variable is less than 200
            while (init < 200)
            {
                init++;// Increment your variable by 1
                numbers.Add(init); // Then add your variable to "numbers"
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            foreach (var num in numbers)
            {
                Console.WriteLine(num); // Write your variable to the console
            }


            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            for (var i = 199; i <= numbers.Count && i >= 0; i--)

            {
                Console.WriteLine(numbers[i]);// Write to the console "numbers" at index i
            }
        }
    }
}

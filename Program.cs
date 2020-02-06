/*
  Programmer: Shane Scallon
  Date: 2/6/2020
  Description: This C# console application creates an array and then uses a for loop to 
  pass each array element individually and display values to the user.
 */
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //create an array consisting of numbers 1 through 25
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18,
                19, 20, 21, 22, 23, 24, 25 };

            //For loop that passes array element individually and then displays each element value to the user
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine("Element Value= " + numbers[index]);
            }
            //prompts the user to exit the program by pressing any key
            Console.WriteLine("Press any button to exit the program...");
            Console.ReadKey(true);
        }
    }
}

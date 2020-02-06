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

            //a for loop that passes array element individually and then displays each element value to the user
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine("Element Value= " + numbers[index]);
            }
        }
    }
}

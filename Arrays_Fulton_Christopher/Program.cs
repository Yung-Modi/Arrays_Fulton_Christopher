using System;

namespace Arrays_Fulton_Christopher
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompts the user to enter the size of the array
            Console.WriteLine("Enter a whole number for the array size.");

            // Reads user input for the array size and convert it to an integer
            int arraySize = Convert.ToInt32(Console.ReadLine());

            // Initializes an array of integers with the specified size
            int[] numbers = new int[arraySize];

            // Variable to hold the sum of the numbers in the array
            int sum = 0;

            // Loops through the array and prompt the user to enter numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                // Asks the user to input a number for the array
                Console.WriteLine($"Enter a whole number to add to the array.");

                // Converts the user's input to an integer and store it in the array
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                // Adds the current number to the sum
                sum += numbers[i];
            }

            // Output the sum of the numbers in the array
            Console.WriteLine($"The sum of the array is {sum}");

            // Sorts the array in ascending order
            Array.Sort(numbers);

            // Output the sorted array
            Console.WriteLine("Array:");

            // Iterate over each element in the sorted array and display it
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

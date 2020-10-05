using System;

namespace part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);
        }

        /// Generates an array of 10 numbers.
        static int[] GenerateNumbers()
        {
            int[] numbers = new int[10];

            for (int index = 0; index < 10; index++)
            {
                // We add 1 here, because the index starts
                // at 0, but we want to start with 1, we add
                // 1 here.
                numbers[index] = index + 1;
            }
            return numbers;
        }//end of generate numbers


        /// Reverses the contents of an array that is passed in.
        static void Reverse(int[] numbers)
        {
            // Initialize one index at the start of the array, and another
            // at the end of the array. The index of the last item in the
            // array is the length of the array - 1.
            int firstIndex = 0;
            int secondIndex = numbers.Length - 1;

            while (firstIndex < secondIndex)
            {
                // To swap two numbers, we need to copy one value out
                // to a safe place so that it doesn't get overwritten.
                int temp = numbers[firstIndex];
                numbers[firstIndex] = numbers[secondIndex];
                numbers[secondIndex] = temp;

                // Move on to the next pair.
                firstIndex++;
                secondIndex--;
            }
        }//end of reverse int


        /// Prints any array of numbers in order.
        static void PrintNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
        }//end of print numbers


    }
}

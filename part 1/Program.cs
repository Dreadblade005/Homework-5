/// Lab 5
/// File Name: Guessing Game
/// @author: Dakota Durst
/// Date: October 2, 2020
///
/// Problem Statement: 
/// Code will produce a random number between 1-100. User will try to guess number while machine says if number is lower or higher then the guess. 
///
///
/// Overall Plan:
/// 1) 
/// 2)
/// 3) 
/// 4) 
/// 5) 

using System;

namespace part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int lengthofnumbers = numbers.Length;
            int[] copy = new int[lengthofnumbers];
            for (int i = 0; i < numbers.Length; i++)
            {
                copy[i] = numbers[i];
                Console.WriteLine("This is the number in array number: " + numbers[i] + " and this is the number in the copy: " + copy[i]);
            }
            
        }
    }
}

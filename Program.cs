/* Jacob Broerman
 Feb 9 2023
 Description: Create a C# console application that computes the first 25 numbers of the Fibonacci sequence with no user input.
*/

using System;

namespace Deliv4Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25];

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < 25; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Fibonacci number ({0}) = {1}", i, fibonacci[i]);
            }
            Console.ReadLine();
        }
    }
}

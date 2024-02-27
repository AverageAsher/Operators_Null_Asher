using System;

namespace Operators_Null_Asher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Declare and initialize a variable that multiplies two integer numbers together.
            int multiplyStuff = 5 * 5;

            // Declare and initialize a variable that adds two integer numbers together.
            int addStuff = 5 + 5;

            // Find the min and max of the two variables and output it to the console.
            int maxResult = Math.Max(multiplyStuff, addStuff);
            int minResult = Math.Min(multiplyStuff, addStuff);
            Console.WriteLine($"The max of {multiplyStuff} and {addStuff} is {maxResult}. The min of {multiplyStuff} and {addStuff} is {minResult}.");

            // Using a comparison operator to find which number is greater by assigning it to a boolean, isIntGreater.
            bool isIntGreater = multiplyStuff > addStuff;
            Console.WriteLine($"{multiplyStuff} is greater than {addStuff}, {isIntGreater}");
        }
    }
}
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

            // For shorts
            short shortMultiply = 5 * 5;
            short shortAdd = 5 + 5;
            short shortMax = Math.Max(shortMultiply, shortAdd);
            short shortMin = Math.Min(shortMultiply, shortAdd);
            bool isShortGreater = shortMultiply > shortAdd;
            Console.WriteLine($"Short Results: Max = {shortMax}, Min = {shortMin}, isShortGreater = {isShortGreater}");

            // For longs
            long longMultiply = 5L * 5L;
            long longAdd = 5L + 5L;
            long longMax = Math.Max(longMultiply, longAdd);
            long longMin = Math.Min(longMultiply, longAdd);
            bool isLongGreater = longMultiply > longAdd;
            Console.WriteLine($"Long Results: Max = {longMax}, Min = {longMin}, isLongGreater = {isLongGreater}");

            // For floats
            float floatMultiply = 5.5f * 5.5f;
            float floatAdd = 5.5f + 5.5f;
            float floatMax = Math.Max(floatMultiply, floatAdd);
            float floatMin = Math.Min(floatMultiply, floatAdd);
            bool isFloatGreater = floatMultiply > floatAdd;
            Console.WriteLine($"Float Results: Max = {floatMax}, Min = {floatMin}, isFloatGreater = {isFloatGreater}");

            // For doubles
            double doubleMultiply = 5.5 * 5.5;
            double doubleAdd = 5.5 + 5.5;
            double doubleMax = Math.Max(doubleMultiply, doubleAdd);
            double doubleMin = Math.Min(doubleMultiply, doubleAdd);
            bool isDoubleGreater = doubleMultiply > doubleAdd;
            Console.WriteLine($"Double Results: Max = {doubleMax}, Min = {doubleMin}, isDoubleGreater = {isDoubleGreater}");

            // For Decimals
            decimal decimalMultiply = 5.5m * 5.5m;
            decimal decimalAdd = 5.5m + 5.5m;
            decimal decimalMax = Math.Max(decimalMultiply, decimalAdd);
            decimal decimalMin = Math.Min(decimalMultiply, decimalAdd);
            bool isDecimalGreater = decimalMultiply > decimalAdd;
            Console.WriteLine($"Decimal Results: Max = {decimalMax}, Min = {decimalMin}, isDecimalGreater = {isDecimalGreater}");


        }
    }
}
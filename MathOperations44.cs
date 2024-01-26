using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    internal class MathOperations
    {
        // MathOperations.cs



    
        // Create a void method that takes two integers as parameters
        public void PerformMathOperation(int firstNumber, int secondNumber)
        {
            // Do a math operation on the first integer (e.g., add 10)
            int result = firstNumber + 10;

            // Display the result of the math operation and the second integer to the screen
            Console.WriteLine($"Result of {firstNumber} + 10 = {result}. Displaying second integer: {secondNumber}");
        }
    }

}


using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
       //Add Method
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

       //Subtract method that accepts 2 integers
        public int Subtract(int minuend, int subtrahend, int expected)
        {
            return minuend - subtrahend;
        }
      
        // Multiply method that passes 2 integers
        public int Multiply(int num1, int num2, int expected)
        {
            return num1 * num2;
        }

        // Divide method that passes 2 integers
        public double Divide(int num1, int num2, int expected)
        {
            return num1 / num2;
        }

        public int Subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Divide(int num1, int num2)
        {
            return num1 / num2;
        }
      
    }
}

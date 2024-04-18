using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]       //Added test data 
        [InlineData(1, 2, 3, 6)]
        [InlineData(2, 3, 5, 10)]
        [InlineData(3, 2, 2, 7)]
        [InlineData(1, 3, 3, 7)]
        [InlineData(4, 2, 2, 8)]

        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(4, 1, 3)]
        [InlineData(6, 3, 3)]
        [InlineData(5, 4, 1)]
        [InlineData(7, 3, 4)]
        //Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Arrange
            Calculator calculator1 = new Calculator();
            //Act
            int actual = calculator1.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]         //Added test data 
        [InlineData(5, 3, 15)]
        [InlineData(4, 1, 4)]
        [InlineData(6, 3, 18)]
        [InlineData(5, 4, 20)]
        [InlineData(7, 3, 21)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculator2 = new Calculator();
            //Act
            int actual = calculator2.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(4, 1, 4)]
        [InlineData(9, 3, 3)]
        [InlineData(10, 5, 2)]
        [InlineData(2, 1, 2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calculator3 = new Calculator();
            //Act
            double actual = calculator3.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}

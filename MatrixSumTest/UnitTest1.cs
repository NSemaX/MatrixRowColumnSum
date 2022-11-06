using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixSumTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void is_Matrix_Dimension_True()
        {
            Console.WriteLine("is_Matrix_Dimension_True test is running.");
            // Arrange
            int row = 10;
            int column = 10;
            int expectedResult = 5050;
            int actualResult = 0;

            int i, j;
            int[,] exampleMatrix = new int[row, column];

            // Create example the matrix like : 12345....
            int x = 1;
            for (i = 0; i < row; i++)
                for (j = 0; j < column; j++)
                    exampleMatrix[i, j] = x++;

            // Act
            actualResult =MatrixSum.SumFunctions.rowSum(exampleMatrix, row, column);

            // Assert          
            Assert.AreEqual(expectedResult, actualResult, 0, "totalSum not calculated correctly");
        }
    }
}


using System;

namespace MatrixSum
{
    class Program
    {
        // Get the size m and n
        static int row = 10;
        static int column = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("Calculates sum of 10x10 matrix rows and coloumns");
            int i, j;
            int[,] exampleMatrix = new int[row, column];

            // Create example the matrix like : 12345....
            int x = 1;
            for (i = 0; i < row; i++)
                for (j = 0; j < column; j++)
                    exampleMatrix[i, j] = x++;

            // Get each row sum
            SumFunctions.rowSum(exampleMatrix, row, column);

            // Get each column sum
            SumFunctions.columnSum(exampleMatrix, row, column);
        }
    }
}


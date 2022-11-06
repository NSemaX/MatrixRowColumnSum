using System;
namespace MatrixSum
{
    public class SumFunctions
    {
        // Function to calculate sum of each row
        public static int rowSum(int[,] arr,int m, int n)
        {

            int i, j, sum = 0;
            int totalSum = 0;

            Console.Write("\nFinding Sum of each row:\n\n");

            // finding the row sum
            for (i = 0; i < m; ++i)
            {
                for (j = 0; j < n; ++j)
                {

                    // Add the element
                    sum = sum + arr[i, j];
                }

                // Print the row sum
                Console.WriteLine("Sum of the row " + i + " = "
                                  + sum);

                //Find total sum: An example scenario for unit test
                totalSum += sum;

                // Reset the sum
                sum = 0;
            }

            return totalSum;
        }

        // Function to calculate sum
        // of each column
        public static void columnSum(int[,] arr, int m, int n)
        {

            int i, j, sum = 0;

            Console.Write("\nFinding Sum of each"
                          + " column:\n\n");

            // finding the column sum
            for (i = 0; i < m; ++i)
            {
                for (j = 0; j < n; ++j)
                {

                    // Add the element
                    sum = sum + arr[j, i];
                }

                // Print the column sum
                Console.WriteLine("Sum of the column " + i
                                  + " = " + sum);

                // Reset the sum
                sum = 0;
            }
        }
    }
}


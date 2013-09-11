/*Task 2: Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. 
 * Get N and M from the user and initiate the array. */


using System;

class MatrixSum3x3
{
    static int[,] integersArray;

    static void Print3x3Square(int startRow, int startCol)
    {
        for (int row = startRow; row <= (startRow + 2); row++)
        {
            for (int col = startCol; col <= (startCol + 2); col++)
            {
                Console.Write(" {0, 3}", integersArray[row, col]);
            }

            Console.WriteLine();
        }
    }

    static void PrintArray()
    {
        for (int row = 0; row < integersArray.GetLength(0); row++)
        {
            for (int col = 0; col < integersArray.GetLength(1); col++)
            {
                Console.Write(" {0, 3}", integersArray[row, col]);
            }

            Console.WriteLine();
        }
    }

    static int CalculateSumOf3x3Square(int startRow, int startCol)
    {
        int currentSum = 0;

        for (int row = startRow; row <= (startRow + 2); row++)
        {
            for (int col = startCol; col <= (startCol + 2); col++)
            {
                currentSum += integersArray[row, col];
            }
        }

        return currentSum;
    }

    static void Main()
    {
        
        Console.Write("Enter rows: ");
        int arrayRows = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nEnter columns: ");
        int arrayCols = Convert.ToInt32(Console.ReadLine());

        integersArray = new int[arrayRows, arrayCols];

        
        for (int row = 0; row < integersArray.GetLength(0); row++)
        {
            Console.Write("\nEnter the number in Row {0}: \n", (row + 1));

            for (int col = 0; col < integersArray.GetLength(1); col++)
            {
                int currentNumber = Convert.ToInt32(Console.ReadLine());
                integersArray[row, col] = currentNumber;
            }
        }

        
        Console.WriteLine("\nMatrix: \n");
        PrintArray();

        int highestSumRow = 0;
        int highestSumCol = 0;
        int highestSum = 0;

        for (int row = 0; row <= (arrayRows - 3); row++)
        {
            for (int col = 0; col <= (arrayCols - 3); col++)
            {
                int currentSum = CalculateSumOf3x3Square(row, col);

                if (currentSum >= highestSum)
                {
                    highestSum = currentSum;
                    highestSumRow = row;
                    highestSumCol = col;
                }
            }
        }

        Console.WriteLine("\nThe highest sum is {0} and it belongs to the:\n", highestSum);
        Print3x3Square(highestSumRow, highestSumCol);
        Console.WriteLine();
    }
}
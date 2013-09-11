/*Task 1: Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4) */

using System;

class CreatingMatrices
{
    static void Main()
    {
        Console.WriteLine("Enter rows and columns for the matrix:");
        int rows = int.Parse(Console.ReadLine());
        int columns = rows;
        int digit = 1;
        int[,] matrix = new int[rows, columns];
        
        //Subsection A
        for (int col = 0; col < columns; col++)
        {
            for (int row = 0; row < rows; row++)
            {
                matrix[row, col] = digit;      //Just filling the matrix.
                digit++;
            }
        }

        Console.WriteLine("Subsection A:");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns ; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);     //Printing the matrix.
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();


        //Subsection B

        for (int col = 0; col < columns; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrix[row, col] = digit;      
                    digit++;
                }
            }
            else
            {
                for (int row = rows - 1; row >= 0; row--)
                {
                    matrix[row, col] = digit;       
                    digit++;
                }
            }
        }

        Console.WriteLine("Subsection B:");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);     
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();

        //Subsection C
        int size;
        int rowNew = size - 1;
        int column = 0;

        int counter = 0;

        int[,] matrixNew = new int[size, size];
        bool[,] isVisited = new bool[size, size];
        bool IsTraversable   (rowNew, column, size, isVisited);
        while (rowNew >= 0) // fill left diagonals up to and including the midle diagonal
        {
            if ( IsTraversable (rowNew, column, size, isVisited))
            {
                counter++;
                matrix[rowNew, column] = counter;
                isVisited[rowNew, column] = true;

                rowNew++;
                column++;
            }
            else
            {
                rowNew--;
                column = 0;
            }
        }

        //set starting row and column for second part
        int currentCol = 1;
        rowNew = 0;
        column = 1;

        while (counter <= size * size && column < size) // fill right diagonals
        {            
            if (IsTraversable (rowNew, column, size, isVisited))
            {
                counter++;
                matrix[rowNew, currentCol] = counter;                
                isVisited[rowNew, currentCol] = true;

                rowNew++;
                currentCol++;
            }
            else
            {
                rowNew = 0;
                column++;
                currentCol = column;
            }
        }

        
      
    }
    
}

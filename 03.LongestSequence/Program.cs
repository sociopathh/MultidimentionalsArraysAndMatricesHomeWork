/* Task 3: We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements 
 * located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.*/

using System;
using System.Collections.Generic;

class LongestSequence
{
    static void Main()
    {
        Console.WriteLine("Enter martix size: ");
        int rowN = int.Parse(Console.ReadLine());
        int colM = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rowN, colM];
        List<string> listMaxSeq = new List<string>();
        int curSum = 1, maxSum = 0, tempRow = 1, tempCol = 0;

        for (int row = 0; row < rowN; row++)
        {
            for (int coll = 0; coll < colM; coll++)
            {
                matrix[row, coll] = Console.ReadLine();
            }
        }

        Console.WriteLine("Main matrix");
        for (int row = 0; row < rowN; row++)
        {
            for (int coll = 0; coll < colM; coll++)
            {
                Console.Write("{0,5}", matrix[row, coll]);
            }
            Console.WriteLine();
        }

        for (int row = 0; row < rowN; row++)
        {
            for (int coll = 0; coll < colM - 1; coll++)
            {
                curSum = ((matrix[row, coll] == matrix[row, coll + 1]) ? ++curSum : 1);
                if (curSum == maxSum)
                {
                    listMaxSeq.Add(matrix[row, coll]);
                }
                else if (curSum > maxSum)
                {
                    maxSum = curSum;
                    listMaxSeq.Clear();
                    listMaxSeq.Add(matrix[row, coll]);
                }
            }
            curSum = 1;
        }

        for (int coll = 0; coll < colM; coll++)
        {
            for (int row = 0; row < rowN - 1; row++)
            {
                curSum = ((matrix[row, coll] == matrix[row + 1, coll]) ? ++curSum : 1);
                if (curSum == maxSum)
                {
                    listMaxSeq.Add(matrix[row, coll]);
                }
                else if (curSum > maxSum)
                {
                    maxSum = curSum;
                    listMaxSeq.Clear();
                    listMaxSeq.Add(matrix[row, coll]);
                }
            }
            curSum = 1;
        }

        for (int i = 0; i < colM - 1; i++)
        {
            for (int row = 0, coll = tempCol; row < rowN - 1 && coll < colM - 1; row++, coll++)
            {
                curSum = ((matrix[row, coll] == matrix[row + 1, coll + 1]) ? ++curSum : 1);
                if (curSum == maxSum)
                {
                    listMaxSeq.Add(matrix[row, coll]);
                }
                else if (curSum > maxSum)
                {
                    maxSum = curSum;
                    listMaxSeq.Clear();
                    listMaxSeq.Add(matrix[row, coll]);
                }
            }
            tempCol++;
            curSum = 1;
        }

        for (int i = 0; i < rowN - 1; i++)
        {
            for (int row = tempRow, coll = 0; row < rowN - 1 && coll < colM - 1; row++, coll++)
            {
                curSum = ((matrix[row, coll] == matrix[row + 1, coll + 1]) ? ++curSum : 1);
                if (curSum == maxSum)
                {
                    listMaxSeq.Add(matrix[row, coll]);
                }
                else if (curSum > maxSum)
                {
                    maxSum = curSum;
                    listMaxSeq.Clear();
                    listMaxSeq.Add(matrix[row, coll]);
                }
            }
            tempRow++;
            curSum = 1;
        }


        Console.WriteLine("Max sequence is of {0} elemets", maxSum);
        for (int i = 0; i < listMaxSeq.Count; i++)
        {
            Console.Write(listMaxSeq[i] + " ");
        }
        Console.WriteLine();
    }
}
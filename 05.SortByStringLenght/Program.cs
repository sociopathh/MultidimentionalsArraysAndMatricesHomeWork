/*Task 5: You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
 * Get the array from the console */

using System;
using System.Collections.Generic;

class SortByStringLength
{
    static string[] SortArrayByStringLength(string[] arrayToSort)
    {
        List<int> lengthsOfElements = new List<int>();

        for (int index = 0; index < arrayToSort.Length; index++)
        {
            int lenghtOfCurrentElement = arrayToSort[index].Length;
            lengthsOfElements.Add(lenghtOfCurrentElement);
        }

        lengthsOfElements.Sort();

        for (int index = (lengthsOfElements.Count - 1); index > 0; index--)
        {
            if (lengthsOfElements[index] == lengthsOfElements[index - 1])
            {
                lengthsOfElements.RemoveAt(index);
            }
        }

        string[] sortedArray = new string[arrayToSort.Length];
        int nextAvailablePositionInSortedArray = 0;

        for (int listIndex = 0; listIndex < lengthsOfElements.Count; listIndex++)
        {
            for (int arrayIndex = 0; arrayIndex < arrayToSort.Length; arrayIndex++)
            {
                int lenghtOfCurrentElement = arrayToSort[arrayIndex].Length;

                if (lenghtOfCurrentElement == lengthsOfElements[listIndex])
                {
                    sortedArray[nextAvailablePositionInSortedArray] = arrayToSort[arrayIndex];
                    nextAvailablePositionInSortedArray++;
                }
            }
        }

        return sortedArray;
    }

    static void Main()
    {
        
        Console.Write("How many words do you want to compare: ");
        int numberOfWords = Convert.ToInt32(Console.ReadLine());

        string[] stringsArray = new string[numberOfWords];

        Console.WriteLine("\nEnter the word you wish to compare: \n");
        for (int index = 0; index < stringsArray.Length; index++)
        {
            string currentSring = Console.ReadLine();

            stringsArray[index] = currentSring;
        }

        stringsArray = SortArrayByStringLength(stringsArray);

        Console.WriteLine("\nThe words you have entered sorted by their length are: \n");

        for (int index = 0; index < stringsArray.Length; index++)
        {
            Console.WriteLine("\"{0}\" ", stringsArray[index]);
        }

        Console.WriteLine();
    }
}
/* Write a program, that reads from the console an array of N integers and an integer K, sorts the array and 
        * using the method Array.BinSearch() finds the largest number in the array which is ≤ K */

using System;

class ArrayBinarySearch
{
    static void Main()
    {
        Console.Write("Enter number K: ");
        int numberK = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nEnter integers in the array: ");
        int numberOfIntegers = Convert.ToInt32(Console.ReadLine());

        int[] integersArray = new int[numberOfIntegers];

        Console.WriteLine("\nEnter the number in the array: ");
        for (int index = 0; index < integersArray.Length; index++)
        {
            int currentInteger = Convert.ToInt32(Console.ReadLine());
            integersArray[index] = currentInteger;
        }

        Array.Sort(integersArray);

        bool numberInArray = false;
        int answer = 0;

        for (int i = numberK; i >= integersArray[0]; i--)
        {
            if (Array.BinarySearch(integersArray, i) >= 0)
            {
                answer = integersArray[Array.BinarySearch(integersArray, i)];
                numberInArray = true;
                break;
            }
        }

        if (numberInArray)
        {
            Console.WriteLine("\nThe largest number in the array that is <= K is {0}\n", answer);
        }
        else
        {
            Console.WriteLine("\nThere is no number in the array that is <= K\n");
        }

    }
}
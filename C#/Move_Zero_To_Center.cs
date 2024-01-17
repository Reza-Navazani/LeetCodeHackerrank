using System;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        int[] inputArray = { 1, 0, 5, 0, 3, 0, 7, 2 };

        int splitIndex = inputArray.Length/2; // Index at which to split the array

        // Split the array
        int[] firstPart = new int[splitIndex];
        int[] secondPart = new int[inputArray.Length - splitIndex];

        Array.Copy(inputArray, 0, firstPart, 0, splitIndex);
        Array.Copy(inputArray, splitIndex, secondPart, 0, inputArray.Length - splitIndex);
        // Display the results

        MoveZerosToRight(firstPart);
        MoveZerosToLeft(secondPart);
        Console.WriteLine("First Part: " + 
            string.Join(", ", firstPart) + ", "+
            string.Join(", ", secondPart) );

    }

    static void  MoveZerosToLeft(int[] arr)
    {
        var newArray = arr.OrderBy(num => num == 0 ? 0 : 1).ToArray();
        Array.Copy(newArray, arr, arr.Length);
    }
    static void MoveZerosToRight (int[] arr)
    {
        var newArray = arr.OrderBy(num => num == 0 ? 1:0).ToArray();
        Array.Copy(newArray, arr, arr.Length);
    }
}


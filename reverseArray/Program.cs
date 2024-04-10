using System;
class Program
{
    static void Main(string[] args)
    {
        int[] originalArray = { 1, 2, 3, 4, 5, };

        Console.WriteLine("Original array:");
        PrintArray(originalArray);

        ReverseArray(originalArray);

        Console.WriteLine("\nReversed array:");
        PrintArray(originalArray);

    }

    static void ReverseArray(int[] arr)
    {
        int startArr = 0;
        int endArr = arr.Length - 1;

        while (startArr < endArr)
        {
            int temp = arr[startArr];
            arr[startArr] = arr[endArr];
            arr[endArr] = temp;

            startArr++;
            endArr--;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach(var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
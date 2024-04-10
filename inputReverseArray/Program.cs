using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the array:  ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine($"Enter {size} elements:");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}:");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }


        Console.WriteLine("Original array:");
        PrintArray( array );

        ReverseArray( array );

        Console.WriteLine("\nReversed array:");
        PrintArray( array );

    }

    static void ReverseArray(int[] arr)
    {
        int startArr = 0;
        int endArr = arr.Length - 1;

        while (startArr < endArr)
        {
            int temp = arr[startArr];
            arr [startArr] = arr[endArr];
            arr [endArr] = temp;

            startArr++;
            endArr-- ;

        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item + " ");
        }
        Console.WriteLine();
    }
}
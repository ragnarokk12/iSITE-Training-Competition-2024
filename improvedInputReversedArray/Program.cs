using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine($"Enter {size} element: ");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1} :");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Original array: ");
        PrintArray(array);

        ReverseArray(array);

        Console.WriteLine("Reversed array: ");
        PrintArray(array);
    }

    static void ReverseArray(int[] arr)
    {
        int startIndex = 0;
        int endIndex = arr.Length -1;

        while (startIndex < endIndex)
        {
            int temp = arr[startIndex];
            arr[startIndex] = arr[endIndex];
            arr[endIndex] = temp;

            startIndex++;
            endIndex--;

            

        }
    }

    static void PrintArray(int[] arr)
    {
        foreach(var item in arr)
        {
            Console.WriteLine(item + " ");
        }
        Console.WriteLine();
    }
}
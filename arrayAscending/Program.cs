using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32 (Console.ReadLine());

        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter element {i + 1}: ");
            array[i] = Convert.ToInt32 (Console.ReadLine());
        }

        Console.WriteLine(" ");

        Array.Sort (array);
        Console.WriteLine("Sorted numbers: ");
        foreach(int i in array)
        {
            Console.WriteLine (i);
        }
    }
}
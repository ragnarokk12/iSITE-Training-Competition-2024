using System;

class Program
{
    static void Main(string[] args)
    {
        // Array of pairs representing (name, score)
        Tuple<string, int>[] pairs = {
            Tuple.Create("Alice", 85),
            Tuple.Create("Bob", 70),
            Tuple.Create("Charlie", 85),
            Tuple.Create("David", 90),
            Tuple.Create("Eve", 70)
        };

        // Sort the array based on score using stable sort (Merge Sort)
        MergeSort(pairs);

        // Print the sorted array
        Console.WriteLine("Sorted array based on score (ascending):");
        foreach (var pair in pairs)
        {
            Console.WriteLine($"Name: {pair.Item1}, Score: {pair.Item2}");
        }
    }

    static void MergeSort(Tuple<string, int>[] arr)
    {
        if (arr.Length <= 1)
            return;

        int mid = arr.Length / 2;
        Tuple<string, int>[] left = new Tuple<string, int>[mid];
        Tuple<string, int>[] right = new Tuple<string, int>[arr.Length - mid];

        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);

        MergeSort(left);
        MergeSort(right);

        Merge(arr, left, right);
    }

    static void Merge(Tuple<string, int>[] arr, Tuple<string, int>[] left, Tuple<string, int>[] right)
    {
        int leftIndex = 0, rightIndex = 0, mergeIndex = 0;

        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (left[leftIndex].Item2 <= right[rightIndex].Item2)
            {
                arr[mergeIndex] = left[leftIndex];
                leftIndex++;
            }
            else
            {
                arr[mergeIndex] = right[rightIndex];
                rightIndex++;
            }
            mergeIndex++;
        }

        while (leftIndex < left.Length)
        {
            arr[mergeIndex] = left[leftIndex];
            leftIndex++;
            mergeIndex++;
        }

        while (rightIndex < right.Length)
        {
            arr[mergeIndex] = right[rightIndex];
            rightIndex++;
            mergeIndex++;
        }
    }
}

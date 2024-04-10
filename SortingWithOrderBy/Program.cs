using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Array of pairs representing (name, score)
        (string Name, int Score)[] pairs = {
            ("Alice", 85),
            ("Bob", 70),
            ("Charlie", 85),
            ("David", 90),
            ("Eve", 70)
        };

        // Sort the array based on score in ascending order, maintaining relative order for equal scores
        var sortedPairs = pairs.OrderBy(pair => pair.Score).ThenBy(pair => pair.Name);

        // Print the sorted array
        Console.WriteLine("Sorted array based on score (ascending):");
        foreach (var pair in sortedPairs)
        {
            Console.WriteLine($"Name: {pair.Name}, Score: {pair.Score}");
        }
    }
}

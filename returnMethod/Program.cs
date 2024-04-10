using System;
class Program
{
    static void Main(string[] args)
    {
        double x;
        double y;
        double results;

        Console.WriteLine("Enter in number 1: ");
        x= Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter in number 2: ");
        y= Convert.ToDouble(Console.ReadLine()); 

        results = Multiply(x, y);
        Console.WriteLine(results);

        Console.ReadKey();
    }

    static double Multiply(double a, double b)
    {
        double z = a * b;
        return z;
    }
}
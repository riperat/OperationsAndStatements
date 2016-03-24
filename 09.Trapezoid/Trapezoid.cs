using System;

class Trapezoid
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int check = (((a + b)/2) * h);
        Console.WriteLine("Area = {0}",check);
    }
}


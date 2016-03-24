using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double distance = Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1)));
        if (distance <= 1.5 && y > 1)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
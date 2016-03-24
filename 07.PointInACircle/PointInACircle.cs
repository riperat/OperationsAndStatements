using System;

class PointInACircle
{
    static void Main()
    {
        int x = Int32.Parse(Console.ReadLine());
        int y = Int32.Parse(Console.ReadLine());
        int rCirc = 3;
        int xCirc = 1;
        int yCirc = 1;
        bool checkCirc = (x - xCirc) * (x - xCirc) + (y - yCirc) * (y - yCirc) <= rCirc * rCirc;
        Console.WriteLine(checkCirc);
    }
}


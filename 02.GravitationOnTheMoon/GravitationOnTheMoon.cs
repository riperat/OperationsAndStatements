using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        double weightOnMoon = (weight * 17.0) / 100;
        Console.WriteLine(weightOnMoon);
    }
}
using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter wight");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height");
        double h = double.Parse(Console.ReadLine());

        double Perimether = 2 * b + 2 * h;
        double Area = b * h;
        Console.WriteLine("Perimether ={0}", Perimether);
        Console.WriteLine("Area ={0}", Area);
    }
}
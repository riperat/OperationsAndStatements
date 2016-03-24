using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if (a % 7 == 0 || a / 5 == 0)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}


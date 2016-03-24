using System;

class ThirdDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int numberHundred = number / 100;
        int conclusion = numberHundred % 10;
        bool theNumber = (conclusion == 7);
        Console.WriteLine(theNumber);
    }
}


using System;

class FourDigitNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int a = (number / 10) % 10;//3
        int b = (number / 100) % 10;//2
        int c = (number / 1000) % 10;//1
        int d = (number / 1) % 10;//4
        Console.WriteLine(a +b + c +d);
        Console.WriteLine("{3}{0}{1}{2}",a ,b ,c ,d);
        Console.WriteLine("{3}{2}{1}{0}", a, b, c, d);
        Console.WriteLine("{2}{0}{1}{3}",a ,b ,c ,d);
    }
}


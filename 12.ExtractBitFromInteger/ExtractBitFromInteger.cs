using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("number =");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("position =");
        int p = int.Parse(Console.ReadLine());
        int move = n >> p;
        int bit = move & 1;
        Console.WriteLine(bit);
    }
}

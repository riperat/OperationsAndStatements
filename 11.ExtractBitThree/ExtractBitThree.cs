using System;

class ExtractBitThree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int move = n >> 3;
        int bit = move & 1;
        Console.WriteLine(bit);
    }
}


using System;

class ModifyBit
{
    static void Main()
    {
        int numberInput = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int valueInput = int.Parse(Console.ReadLine());
        int result = 0;
        bool retry = true;
        while (retry)
        {
            retry = false;
            if (valueInput == 0)
            {
                int mask = ~(1 << position);
                result = numberInput & mask;
                break;
            }
            else if (valueInput == 1)
            {
                int mask = 1 << position;
                result = numberInput | mask;
                break;
            }
            else
            {
                Console.WriteLine("You have to enter value 0 or 1:");
                valueInput = int.Parse(Console.ReadLine());
                retry = true;
            }
        }

        Console.WriteLine(result);
    }
}


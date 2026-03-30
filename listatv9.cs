using System;

class listatv9
{
    static void Main2(string[] arg)
    {
        int num = 480;
        int total = 0;
        int i = 1;

        while(i <= 30)
        {
            if (i % 2 != 0)
            {
                total += num; 
            }
            else
            {
                total -= num;
            }

            num -= 5; 
            i++;
        }
        
        Console.Clear();
        Console.WriteLine($"Valor Total: {total}");
    }
}  
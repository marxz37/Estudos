using System;

class Program
{
    static bool EhPrimo(int num)
    {
        if(num <= 1) 
        {
            Console.WriteLine("Numero invalido!");
            return false;
        }

        bool Primo(int num, int index)
        {
            if(index == num) return true;

            if(num % index == 0) return false;

            return Primo(num,index+1);
        }

        return Primo(num,2);
    }
    static void Main()
    {
        Console.WriteLine(EhPrimo(2));
    }
}
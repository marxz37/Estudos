using System;
class dowhile1
{
    static void Main(string[] arg)
    {
        int userNumber;
        do
        {
            Console.WriteLine("Escreva apenas números de 0 a 10:");
            userNumber = int.Parse(Console.ReadLine());
        }
        while(userNumber < 0 && userNumber > 10);
    }
}
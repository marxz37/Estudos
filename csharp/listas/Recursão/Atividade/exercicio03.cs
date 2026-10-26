using System;
class Program
{
    static int FatorialDuploImpar(int i)
    {
        if(i <= 0)
        {
            return 1;
        }
        else
        {
            return i * FatorialDuploImpar(i-2);
        }
    }
    static void Main(string[] arg)
    {
        Console.WriteLine(FatorialDuploImpar(7));
    }
}
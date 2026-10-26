using System;
class Program
{
    static int SomaSerie(int i, int j, int k)
    {
        if(i > j)
        {
            return 0;
        }
        else
        {
            return i + SomaSerie(i+k,j,k);
        }
    }
    static void Main(string[] arg)
    {
        Console.WriteLine(SomaSerie(2,20,3));
    }
}
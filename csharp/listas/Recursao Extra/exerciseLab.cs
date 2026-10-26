using System;
using System.Threading;
public class Neighbor
{
    public int[,] visits;

    public Neighbor(int n, int m)
    {
        visits = new int[n, m];
    }

    public void UpdateVisit(int l, int c)
    {
        visits[l, c]++;
    }
}
class Program
{
    static bool HaveExit(char[,] lab, int line, int colunm, int i = 0, int j = 0, int check = 0)
    {
        if(i == line) return false;
        if(check == 2) return true;

        if(j == colunm-1) return HaveExit(lab,line,colunm,i+1,0,check);

        if(lab[i,j] == 'S') check++;
        if(lab[i,j] == 'E') check++;

        return HaveExit(lab,line,colunm,i,j+1,check);
    }

    static void ShowMatrix(char[,] lab, int l, int c)
    {
        for(int i = 0; i < l; i++)
        {
            for(int j = 0; j < c; j++)
            {
                Console.Write($"{lab[i,j]} ");
            }
            Console.WriteLine();
        }
    }

    static void GenerateMatrix(char[,] lab, int l, int c)
    {
        for(int i = 0; i < l; i++)
        {
            for(int j = 0; j < c; j++)
            {
                lab[i,j] = '0';
            }
        }
        for(int j = 0; j < c; j++)
        {
            lab[0,j] = '1';
            lab[j,0] = '1';
            lab[j,c-1] = '1';
            lab[l-1,j] = '1';
        }
        lab[1,1] = 'S';
        lab[l-2,c-2] = 'E';
    }

    static void WalkLab(char[,] lab, int l, int c)
    {
        Neighbor n1 = new Neighbor(l, c);

        int i = 1, j = 1;

        Console.WriteLine("Before starting, press any key!");
        Console.ReadKey();

        while (lab[l - 2, c - 2] != 'R')
        {
            Console.Clear();
            ShowMatrix(lab, l, c);

            n1.UpdateVisit(i, j);

            Thread.Sleep(200);
        }

        Console.Clear();
        ShowMatrix(lab, l, c);

        Console.WriteLine("Exit reached!");
        }
    static void Main()
    {
        Console.WriteLine("Write the value of N: ");
        int.TryParse(Console.ReadLine(), out int n);

        Console.WriteLine("Write the value of M: ");
        int.TryParse(Console.ReadLine(), out int m);

        char[,] lab = new char[n,m];

        GenerateMatrix(lab,n,m);

        bool check = HaveExit(lab,n,m);

        Console.WriteLine($"Check if has Exit: {check}");

        if(!check)
        {
            Console.WriteLine($"Don't have Exit and Start! Fatal Error.");
        }

        ShowMatrix(lab,n,m);
        WalkLab(lab,n,m);
    }
}
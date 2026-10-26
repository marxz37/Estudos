using System;

class Program
{
    static int SumMatrix(int[,] mat)
    {
        int Sum(int[,] mat, int sum, int l, int c)
        {
            sum += mat[l,c];

            if(c == mat.GetLength(1) - 1 && l == mat.GetLength(0) - 1) return sum;

            if(c == mat.GetLength(1) - 1) return Sum(mat,sum,l+1,0);
            
            return Sum(mat,sum,l,c+1);
        }
        return Sum(mat,0,0,0);
    }
    static void Main()
    {
        Console.WriteLine(SumMatrix(new int[,] {{1,2,3},{4,5,6},{7,8,9}}));
    }
}
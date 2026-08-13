using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int[,] mat = new int[500,500];
        
        //DECLARAÇÃO DE VALORES:
        //MATRIZ 1!
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                mat[i,j] = rnd.Next(0,3);
            }
        }  
        
        int valorBase = 0;
        int somaLinha = 0;
        int somaColuna = 0;
        int somaDiagonal = 0;
        int somaDiagonalInvertido = 0;

        //VALOR BASE
        for(int j = 0; j < mat.GetLength(1); j++)
        {
            valorBase += mat[0,j];
        }
        
        bool cubo_magico = true;
        
        //VERIFICAR CADA LINHA INDIVIDUALMENTE
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            somaLinha = 0;
            for(int j = 0; j < mat.GetLength(1); j++)
            {
                somaLinha += mat[i,j];
            }
            if(somaLinha != valorBase)
            {
                cubo_magico = false;
            }
        } 
        
        //VERIFICAR CADA COLUNA INDIVIDUALMENTE
        for(int j = 0; j < mat.GetLength(1); j++)
        {
            somaColuna = 0;
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                somaColuna += mat[i,j];
            }
            if(somaColuna != valorBase)
            {
                cubo_magico = false;
            }
        }
        
        //VERIFICAR DIAGONAL
        for(int i = 0; i < mat.GetLength(0); i++)
        {
            somaDiagonal += mat[i,i];
        }
        if(somaDiagonal != valorBase)
        {
            cubo_magico = false;
        }
        
        //VERIFICAR DIAGONAL SECUNDÁRIA
        for(int i = 0, j = mat.GetLength(1)-1; i < mat.GetLength(0); i++, j--)
        {
            somaDiagonalInvertido += mat[i,j];
        }
        if(somaDiagonalInvertido != valorBase)
        {
            cubo_magico = false;
        }
        
        if(cubo_magico == true)
        {
            Console.WriteLine("É um CUBO MAGICO!");
        }
        else
        {
            Console.WriteLine("Não é um cubo magico.");
        }
    }
}
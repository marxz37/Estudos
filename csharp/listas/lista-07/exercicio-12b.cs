using System;
class Exercicio12b
{
    static void ImprimirTabuleiro(char[,] tab)
    {
        Console.WriteLine("  0 1 2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
                Console.Write(tab[i, j] + " ");
            Console.WriteLine();
        }
    }
    static bool VerificarVitoria(char[,] tab, char simbolo)
    {
        for (int i = 0; i < 3; i++)
        {
            if (tab[i, 0] == simbolo && tab[i, 1] == simbolo && tab[i, 2] == simbolo)
                return true;
            if (tab[0, i] == simbolo && tab[1, i] == simbolo && tab[2, i] == simbolo)
                return true;
        }
        if (tab[0, 0] == simbolo && tab[1, 1] == simbolo && tab[2, 2] == simbolo)
            return true;
        if (tab[0, 2] == simbolo && tab[1, 1] == simbolo && tab[2, 0] == simbolo)
            return true;
        return false;
    }
    static void FazerJogada(char[,] tab, char simbolo, int jogador)
    {
        int linha, coluna;
        Console.WriteLine("\nJogador " + jogador + " (" + simbolo + "), sua vez:");
        do
        {
            Console.Write("Linha (0-2): ");
            linha = int.Parse(Console.ReadLine());
            Console.Write("Coluna (0-2): ");
            coluna = int.Parse(Console.ReadLine());
            if (linha < 0 || linha > 2 || coluna < 0 || coluna > 2)
                Console.WriteLine("Posição fora do tabuleiro!");
            else if (tab[linha, coluna] != '.')
                Console.WriteLine("Posição ocupada!");
            else
                break;
        } while (true);
        tab[linha, coluna] = simbolo;
    }
    static void Main(string[] args)
    {
        char[,] tabuleiro = new char[3, 3];
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                tabuleiro[i, j] = '.';

        int jogadas = 0;
        bool fimDeJogo = false;

        while (!fimDeJogo)
        {
            FazerJogada(tabuleiro, 'X', 1);
            jogadas++;
            ImprimirTabuleiro(tabuleiro);

            if (VerificarVitoria(tabuleiro, 'X'))
            {
                Console.WriteLine("Jogador 1 (X) venceu!");
                fimDeJogo = true;
            }
            else if (jogadas == 9)
            {
                Console.WriteLine("Empate!");
                fimDeJogo = true;
            }
            else
            {
                FazerJogada(tabuleiro, 'O', 2);
                jogadas++;
                ImprimirTabuleiro(tabuleiro);

                if (VerificarVitoria(tabuleiro, 'O'))
                {
                    Console.WriteLine("Jogador 2 (O) venceu!");
                    fimDeJogo = true;
                }
            }
        }
    }
}
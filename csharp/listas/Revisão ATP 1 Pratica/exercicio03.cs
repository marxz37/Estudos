using System;
class Program
{
    static void Main()
    {
        int numeroAtual = 0;
        int numeroAnterior = 0;

        int tamanhoAtual = 0;
        int maiorTamanho = 0;

        bool ehPrimeiroNumero = true;

        Console.WriteLine("Digite os números: (digite -1 para parar):");

        while(true)
        {
            numeroAtual = int.Parse(Console.ReadLine());

            if (numeroAtual == -1)
            {
                break;
            }

            if (ehPrimeiroNumero)
            {
                tamanhoAtual = 1;
                ehPrimeiroNumero = false; 
            }
            else
            {
                if (numeroAtual > numeroAnterior)
                {
                    tamanhoAtual++;
                }
                else
                {
                    tamanhoAtual = 1;
                }
            }

            if (tamanhoAtual > maiorTamanho)
            {
                maiorTamanho = tamanhoAtual;
            }

            numeroAnterior = numeroAtual;
        }
        Console.WriteLine("Resposta correta: " + maiorTamanho);
    }
}

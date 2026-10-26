using System;

class Program
{
    static void InverterVetor(double[] vetor, int inicio, int fim)
    {
        if (inicio >= fim)
            return;

        double auxiliar = vetor[inicio];
        vetor[inicio] = vetor[fim];
        vetor[fim] = auxiliar;

        InverterVetor(vetor, inicio + 1, fim - 1);
    }

    static void Main(string[] arg)
    {
        double[] vetor = { 1.5, 2.5, 3.5, 4.5, 5.5, 6.5, 7.5, 8.5, 9.5, 10.5 };

        InverterVetor(vetor, 0, vetor.Length - 1);

        for (int i = 0; i < vetor.Length; i++)
            Console.WriteLine(vetor[i]);
    }
}

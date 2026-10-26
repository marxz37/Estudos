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
        double[] vetor = new double[100];

        for (int i = 0; i < vetor.Length; i++)
            vetor[i] = i + 1;

        InverterVetor(vetor, 0, vetor.Length - 1);

        for (int i = 0; i < vetor.Length; i++)
            Console.WriteLine(vetor[i]);
    }
}

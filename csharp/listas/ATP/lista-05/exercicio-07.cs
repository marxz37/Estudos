using System;
public class OperacoesVetores
{
    public static void Main(string[] args)
    {
        double[] vetA = new double[10];
        double[] vetB = new double[10];
        string[] vetC = new string[10];
        double[] vetD = new double[10];

        for (int i = 0; i < vetA.Length; i++)
        {
            Console.WriteLine($"\n--- Registro {i + 1} ---");
            
            Console.Write("Digite o primeiro número: ");
            vetA[i] = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            vetB[i] = double.Parse(Console.ReadLine());

            Console.Write("Digite a operação (+, -, *, /): ");
            vetC[i] = Console.ReadLine().Trim();

            switch (vetC[i])
            {
                case "+":
                    vetD[i] = vetA[i] + vetB[i];
                    break;
                case "-":
                    vetD[i] = vetA[i] - vetB[i];
                    break;
                case "*":
                    vetD[i] = vetA[i] * vetB[i];
                    break;
                case "/":
                    // Verificação para evitar erro de divisão
                    if (vetB[i] != 0)
                        vetD[i] = vetA[i] / vetB[i];
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero! Resultado definido como 0.");
                        vetD[i] = 0;
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida! Resultado definido como 0.");
                    vetD[i] = 0;
                    break;
                    //
            }
        }
        Console.WriteLine("\n=== RESULTADOS FINAIS ===");
        for (int i = 0; i < vetD.Length; i++)
        {
            Console.WriteLine($"[{i}] {vetA[i]} {vetC[i]} {vetB[i]} = {vetD[i]}");
        }
    }
}
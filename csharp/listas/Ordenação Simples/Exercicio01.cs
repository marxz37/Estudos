using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;

class Program
{
    const string ArquivoResultados = "resultados_ordenacao.txt";
    const string ArquivoMedias = "medias_ordenacao.txt";
    const string ArquivoTabela = "tabela_relatorio.csv";
    const int LimiteAmostra = 10000;

    static void Main()
    {
        int[] tamanhos = { 1000, 10000, 50000, 100000 };
        string[] metodos = { "Selecao", "Bolha", "Insercao" };
        string[] tipos = { "Aleatorio", "Ordenado", "Inversamente ordenado" };
        Random rnd = new Random(12345);
        CultureInfo br = new CultureInfo("pt-BR");

        Console.Write("Mostrar os vetores antes e depois? (s/n): ");
        bool mostrar = (Console.ReadLine() ?? "").Trim().ToLower() == "s";

        if (!File.Exists(ArquivoResultados))
            File.WriteAllText(ArquivoResultados,
                "Metodo;Tamanho;Tipo;Rodada;Comparacoes;Movimentacoes;Tempo_ms" + Environment.NewLine);
        else
            File.AppendAllText(ArquivoResultados, Environment.NewLine);

        File.WriteAllText(ArquivoMedias, "MEDIAS DAS 10 RODADAS" + Environment.NewLine + Environment.NewLine);
        File.WriteAllText(ArquivoTabela,
            "Metodo;Tamanho;Tipo;Tempo_medio_ms;Comparacoes_medias;Movimentacoes_medias" + Environment.NewLine);

        foreach (int tamanho in tamanhos)
        {
            int[] aleatorio = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
                aleatorio[i] = rnd.Next(0, 100000);

            int[] ordenado = (int[])aleatorio.Clone();
            Array.Sort(ordenado);
            int[] inverso = (int[])ordenado.Clone();
            Array.Reverse(inverso);
            int[][] entradas = { aleatorio, ordenado, inverso };

            string arquivoMov = "movimentacoes_" + tamanho + ".txt";
            File.WriteAllText(arquivoMov,
                "AMOSTRAS: primeiras " + LimiteAmostra + " movimentacoes por teste" + Environment.NewLine +
                "O total de movimentacoes e contado sem limite nas 10 rodadas." +
                Environment.NewLine + Environment.NewLine);

            for (int m = 0; m < metodos.Length; m++)
            {
                for (int t = 0; t < tipos.Length; t++)
                {
                    double somaTempo = 0, somaComp = 0, somaMov = 0;

                    for (int rodada = 1; rodada <= 10; rodada++)
                    {
                        double[] resultado = LerResultado(metodos[m], tamanho, tipos[t], rodada);
                        if (resultado == null)
                        {
                            int[] vetor = (int[])entradas[t].Clone();
                            if (mostrar)
                                Console.WriteLine("Antes: " + string.Join(", ", vetor));

                            // A gravacao de movimentacoes NAO acontece durante esta medicao.
                            resultado = Ordenar(m, vetor, null);

                            if (mostrar)
                                Console.WriteLine("Depois: " + string.Join(", ", vetor));

                            for (int i = 1; i < tamanho; i++)
                                if (vetor[i] < vetor[i - 1])
                                    throw new Exception("Erro na ordenacao: " + metodos[m]);

                            string linha = metodos[m] + ";" + tamanho + ";" + tipos[t] + ";" + rodada + ";" +
                                resultado[1].ToString("F0", CultureInfo.InvariantCulture) + ";" +
                                resultado[0].ToString("F0", CultureInfo.InvariantCulture) + ";" +
                                resultado[2].ToString("F6", CultureInfo.InvariantCulture);
                            File.AppendAllText(ArquivoResultados, linha + Environment.NewLine);
                        }

                        somaMov += resultado[0];
                        somaComp += resultado[1];
                        somaTempo += resultado[2];
                        Console.WriteLine(metodos[m] + " | " + tamanho + " | " + tipos[t] +
                            " | Rodada " + rodada + "/10 | " + resultado[2].ToString("F4") + " ms");
                    }

                    double mediaTempo = somaTempo / 10;
                    double mediaComp = somaComp / 10;
                    double mediaMov = somaMov / 10;

                    File.AppendAllText(ArquivoMedias,
                        "Metodo: " + metodos[m] + " | Tamanho: " + tamanho + " | Tipo: " + tipos[t] + "\n" +
                        "Tempo medio: " + mediaTempo.ToString("F6", br) + " ms | " +
                        "Comparacoes medias: " + mediaComp.ToString("F2", br) + " | " +
                        "Movimentacoes medias: " + mediaMov.ToString("F2", br) + "\n\n");

                    File.AppendAllText(ArquivoTabela,
                        metodos[m] + ";" + tamanho + ";" + tipos[t] + ";" +
                        mediaTempo.ToString("F6", br) + ";" +
                        mediaComp.ToString("F2", br) + ";" +
                        mediaMov.ToString("F2", br) + Environment.NewLine);

                    List<int> amostra = new List<int>();
                    if (mediaMov > 0)
                    {
                        int[] copia = (int[])entradas[t].Clone();
                        Ordenar(m, copia, amostra);
                    }

                    using (StreamWriter arquivo = new StreamWriter(arquivoMov, true))
                    {
                        arquivo.WriteLine("METODO: " + metodos[m] + " | TIPO: " + tipos[t]);
                        arquivo.WriteLine("TAMANHO: " + tamanho + " | TOTAL POR RODADA: " +
                            mediaMov.ToString("F0", CultureInfo.InvariantCulture));
                        arquivo.WriteLine("MOVIMENTACOES REGISTRADAS: " + Math.Min(LimiteAmostra, amostra.Count));
                        arquivo.WriteLine("Numero;Valor movimentado");
                        for (int i = 0; i < amostra.Count && i < LimiteAmostra; i++)
                            arquivo.WriteLine((i + 1) + ";" + amostra[i]);
                        arquivo.WriteLine("FIM DA AMOSTRA");
                        arquivo.WriteLine();
                    }
                }
            }
        }

        Console.WriteLine("\nConcluido! Veja os resultados, as medias, a tabela e as amostras de movimentacoes.");
    }

    static double[] Ordenar(int metodo, int[] vetor, List<int> amostra)
    {
        if (metodo == 0) return SelecaoOrdenada(vetor, vetor.Length, amostra);
        if (metodo == 1) return BolhaOrdenada(vetor, vetor.Length, amostra);
        return InsercaoOrdenada(vetor, vetor.Length, amostra);
    }

    static double[] SelecaoOrdenada(int[] array, int n, List<int> amostra)
    {
        long mov = 0, comp = 0;
        Stopwatch relogio = Stopwatch.StartNew();

        for (int i = 0; i < n - 1; i++)
        {
            int menor = i;
            for (int j = i + 1; j < n; j++)
            {
                comp++;
                if (array[menor] > array[j]) menor = j;
            }

            int temp = array[menor];
            array[menor] = array[i];
            array[i] = temp;
            mov += 3;

            if (amostra != null)
            {
                amostra.Add(temp);
                amostra.Add(array[menor]);
                amostra.Add(array[i]);
                if (amostra.Count >= LimiteAmostra) break;
            }
        }

        relogio.Stop();
        return new double[] { mov, comp, relogio.Elapsed.TotalMilliseconds };
    }

    static double[] BolhaOrdenada(int[] array, int n, List<int> amostra)
    {
        long mov = 0, comp = 0;
        Stopwatch relogio = Stopwatch.StartNew();

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = n - 1; j > i; j--)
            {
                comp++;
                if (array[j] < array[j - 1])
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    mov += 3;

                    if (amostra != null)
                    {
                        amostra.Add(temp);
                        amostra.Add(array[j]);
                        amostra.Add(array[j - 1]);
                        if (amostra.Count >= LimiteAmostra)
                        {
                            relogio.Stop();
                            return new double[] { mov, comp, relogio.Elapsed.TotalMilliseconds };
                        }
                    }
                }
            }
        }

        relogio.Stop();
        return new double[] { mov, comp, relogio.Elapsed.TotalMilliseconds };
    }

    static double[] InsercaoOrdenada(int[] array, int n, List<int> amostra)
    {
        long mov = 0, comp = 0;
        Stopwatch relogio = Stopwatch.StartNew();

        for (int i = 1; i < n; i++)
        {
            int tmp = array[i];
            mov++;
            if (amostra != null)
            {
                amostra.Add(tmp);
                if (amostra.Count >= LimiteAmostra) break;
            }

            int j = i - 1;
            while (j >= 0 && array[j] > tmp)
            {
                comp++;
                array[j + 1] = array[j];
                mov++;
                if (amostra != null)
                {
                    amostra.Add(array[j + 1]);
                    if (amostra.Count >= LimiteAmostra) break;
                }
                j--;
            }
            if (amostra != null && amostra.Count >= LimiteAmostra) break;

            if (j >= 0) comp++; // Ultima comparacao que foi falsa.
            array[j + 1] = tmp;
            mov++;
            if (amostra != null)
            {
                amostra.Add(tmp);
                if (amostra.Count >= LimiteAmostra) break;
            }
        }

        relogio.Stop();
        return new double[] { mov, comp, relogio.Elapsed.TotalMilliseconds };
    }

    static double[] LerResultado(string metodo, int tamanho, string tipo, int rodada)
    {
        foreach (string linha in File.ReadLines(ArquivoResultados))
        {
            string[] p = linha.Split(';');
            if (p.Length != 7 || p[0] != metodo || p[1] != tamanho.ToString() ||
                p[2] != tipo || p[3] != rodada.ToString()) continue;

            double comp, mov, tempo;
            if (double.TryParse(p[4], NumberStyles.Float, CultureInfo.InvariantCulture, out comp) &&
                double.TryParse(p[5], NumberStyles.Float, CultureInfo.InvariantCulture, out mov) &&
                double.TryParse(p[6], NumberStyles.Float, CultureInfo.InvariantCulture, out tempo))
                return new double[] { mov, comp, tempo };
        }
        return null;
    }
}

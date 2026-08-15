using System;
using System.Collections.Generic;
using System.Threading;

class Rato
{
    private int row;
    private int col;
    private Maze maze;
    private char simbol = '✺';

    public Rato(Maze maze)
    {
        this.maze = maze;
        row = 0;
        col = 0;
    }

    public bool Move()
    {
        int[] visitar = maze.VizinhoMenosVisitado(row, col);

        if (CanMove(visitar[0], visitar[1]))
        {
            maze.SetCell(row, col, ' ');

            row = visitar[0];
            col = visitar[1];

            maze.SetCell(row, col, simbol);
            return true;
        }
        else
        {
            return false;
        }
    }

    private bool CanMove(int r, int c)
    {
        if (r < 0 || c < 0 || r >= maze.Rows || c >= maze.Columns)
            return false;

        int visitas = maze.Visitado(r, c);
        if (visitas > 20) return false;

        char cell = maze.GetCell(r, c);

        if (cell == 'S') return true;

        bool can = cell == ' ' || cell == '*' || cell == 'S';
        return can;
    }
}

class Maze
{
    private int rows;
    private int columns;
    private char[,] grid;
    private int[,] visitados;

    public int Rows => rows;
    public int Columns => columns;

    public Maze(int rows, int columns)
    {
        this.rows = rows;
        this.columns = columns;
        grid = new char[rows, columns];
        visitados = new int[rows, columns];
    }

    public void Generate()
    {
        Random rand = new Random();
        for (int r = 0; r < rows; r++)
            for (int c = 0; c < columns; c++)
                grid[r, c] = rand.Next(100) < 75 ? ' ' : '█';

        grid[0, 0] = 'E';
        grid[rows - 1, columns - 1] = 'S';
    }

    public char GetCell(int r, int c) => grid[r, c];

    public void Print()
    {
        for (int c = 0; c < columns + 2; c++)
            Console.Write("█");
        Console.WriteLine();

        for (int r = 0; r < rows; r++)
        {
            Console.Write("█");
            for (int c = 0; c < columns; c++)
                Console.Write(grid[r, c]);
            Console.WriteLine("█");
        }

        for (int c = 0; c < columns + 2; c++)
            Console.Write("█");
        Console.WriteLine();
    }

    public bool ExisteCaminho()
    {
        int startRow = 0, startCol = 0;
        int endRow = rows - 1, endCol = columns - 1;
        bool[,] visitado = new bool[rows, columns];
        (int r, int c)[,] anterior = new (int, int)[rows, columns];
        Queue<(int r, int c)> fila = new Queue<(int r, int c)>();

        fila.Enqueue((startRow, startCol));
        visitado[startRow, startCol] = true;
        anterior[startRow, startCol] = (-1, -1);

        int[] dr = { 1, -1, 0, 0 };
        int[] dc = { 0, 0, 1, -1 };

        while (fila.Count > 0)
        {
            var (r, c) = fila.Dequeue();
            if (r == endRow && c == endCol)
            {
                return true;
            }
            for (int i = 0; i < 4; i++)
            {
                int nr = r + dr[i];
                int nc = c + dc[i];
                if (nr >= 0 && nc >= 0 && nr < rows && nc < columns &&
                !visitado[nr, nc] &&
                (grid[nr, nc] == ' ' || grid[nr, nc] == 'S'))
                {
                    visitado[nr, nc] = true;
                    anterior[nr, nc] = (r, c);
                    fila.Enqueue((nr, nc));
                }
            }
        }
        return false;
    }

    public void SetCell(int r, int c, char rat)
    {
        grid[r, c] = rat;
    }

    public int Visitado(int r, int c)
    {
        this.visitados[r, c]++;
        return this.visitados[r, c];
    }

    public int[] VizinhoMenosVisitado(int r, int c)
    {
        int[] dr = { 1, -1, 0, 0 };
        int[] dc = { 0, 0, 1, -1 };

        int menorVisita = int.MaxValue;
        int[] melhorVizinho = new int[] { r, c };

        for (int i = 0; i < 4; i++)
        {
            int nr = r + dr[i];
            int nc = c + dc[i];

            if (nr >= 0 && nc >= 0 && nr < rows && nc < columns)
            {
                char cell = grid[nr, nc];
                if (cell == ' ' || cell == 'S' || cell == '*' || cell == 'E')
                {
                    int visitas = visitados[nr, nc];
                    if (visitas < menorVisita)
                    {
                        menorVisita = visitas;
                        melhorVizinho[0] = nr;
                        melhorVizinho[1] = nc;
                    }
                }
            }
        }

        return melhorVizinho;
    }
}

class Program
{
    static void Main()
    {
        Maze maze = new Maze(15, 40);
        bool labirintoValido = false;

        while (!labirintoValido)
        {
            maze.Generate();

            if (maze.ExisteCaminho())
            {
                labirintoValido = true;
                maze.Print();
                Console.WriteLine("Labirinto gerado com caminho válido!");
                Console.ReadLine();
            }
        }

        Console.Clear();
        Rato rato = new Rato(maze);
        bool podeMovimentar = true;

        do
        {
            maze.Print();
            Thread.Sleep(100);

            podeMovimentar = rato.Move();

            if (maze.GetCell(maze.Rows - 1, maze.Columns - 1) == '✺')
            {
                break;
            }

            Console.Clear();
        } while (podeMovimentar);

        maze.Print();
        Console.WriteLine("O rato terminou sua jornada!");
        Console.ReadLine();
    }
}

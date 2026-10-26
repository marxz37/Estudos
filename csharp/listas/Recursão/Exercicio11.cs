class Program
{
    static void Metodo(int n)
    {
        if (n == 0)
            return;

        Metodo(n - 1);
    }

    static void Main()
    {
        Metodo(4);
    }
}

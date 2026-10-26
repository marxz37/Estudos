class Program
{
    static void Contar(int n)
    {
        if (n <= 0)
            return;

        Contar(n - 2);
    }

    static void Main()
    {
        Contar(6);
        Contar(5);
    }
}

class Program
{
    static void Teste(int n)
    {
        if (n == 10)
            return;

        Teste(n + 1);
    }

    static void Main()
    {
        Teste(5);
    }
}

class Program
{
    static void Teste(int n)
    {
        if (n == 5)
            return;

        Teste(n + 1);
    }

    static void Main()
    {
        Teste(2);
    }
}

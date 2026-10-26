using System;
class ContaBancária
{
    private string titular;
    private decimal saldo;

    public string Titular { get => titular; set=> titular = value;}
    public decimal Saldo { get => saldo; private set=> saldo = value;}

    public void Sacar(decimal sacar)
    {
        if (sacar > 0 && sacar <= Saldo)
        {
            Saldo -= sacar;
            Console.WriteLine($"Valor sacado: {sacar}");
        }
        else if(sacar > Saldo)
        {
            Console.WriteLine($"Saldo Insuficiente!");
        }
        else
        {
            Console.WriteLine("Valor de saque inválido!");
        }
    }
    public void Depositar(decimal deposito)
    {
        if (deposito > 0)
        {
            Saldo += deposito;
            Console.WriteLine($"Depositado: {deposito}");
        }
        else
        {
            Console.WriteLine("Deposito Inválido!");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Titular: {Titular} | Saldo Disponível: {Saldo}");
    }
    public ContaBancária(string titular, decimal saldo = 0)
    {
        Titular = titular;
        Saldo = saldo;
    }
}
class Program
{
    static void Main(string[] arg)
    {
        ContaBancária conta = new ContaBancária("Maria",1612.00m);

        conta.ExibirSaldo();
        conta.Sacar(1000m);
        conta.ExibirSaldo();
        conta.Depositar(5255m);
        conta.ExibirSaldo();
        conta.Depositar(-1);
        conta.ExibirSaldo();
    }
}
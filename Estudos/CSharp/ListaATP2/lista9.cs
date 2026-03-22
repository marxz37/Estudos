using System;

public class lista9
{
    public static void Main(string[] args)
    {
        //Declaração das Variaveis e Entrada do Usuário:
        Console.WriteLine("Escreva o nome da Empresa:");
        string empresa = Console.ReadLine();
        Console.WriteLine("Escreva o seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Escreva o seu cargo:");
        string cargo = Console.ReadLine();
        Console.WriteLine("Escreva o seu salario bruto:");
        double salarioBruto = double.Parse(Console.ReadLine());
        double inss = 0, salarioLiquido = 0;
        
        if(salarioBruto <= 0)
        {
            Console.WriteLine("Escreva um numero positivo!");
            return;
        }
        else
        {
            
        }

        //Condições:
        if(salarioBruto <= 1621.01)
        {
            inss = (salarioBruto * 7.5) / 100;
            salarioLiquido = salarioBruto - inss;
        }
        else if(salarioBruto >= 1621.01 && salarioBruto <= 2902.85)
        {
            inss = (salarioBruto * 9) / 100;
            salarioLiquido = salarioBruto - inss;
        }
        else if(salarioBruto >= 2902.85 && salarioBruto <= 4354.28)
        {
            inss = (salarioBruto * 12) / 100;
            salarioLiquido = salarioBruto - inss;
        }
        else if(salarioBruto >= 4354.28)
        {
            inss = (salarioBruto * 14) / 100;
            salarioLiquido = salarioBruto - inss;
        }
        //Evitar com que Usuário o digite valor errado.
        else if(salarioBruto < 0)
        {
            Console.WriteLine("Escreva um número positivo!");
        }
        Console.WriteLine("Nome: "+ nome);
        Console.WriteLine("Nome da Empresa: "+ empresa);
        Console.WriteLine("Nome do Cargo: "+ cargo);
        Console.WriteLine("Salario Bruto: {0:C}", salarioBruto);
        Console.WriteLine("Desconto do INSS: {0:N2}", inss);
        Console.WriteLine("Salario Liquido: {0:N2}", salarioLiquido);
    }
}
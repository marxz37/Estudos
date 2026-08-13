using System;
class listatv7
{
    static void Main2(string[] arg)
    {
        //
        char resposta = 's';

        //
        double cont5000 = 0;
        double contAnos15 = 0;
        int contPopulacao = 0;

        //
        double porcentagemAnosEstudos = 0;
        int somaAnos = 0; 
        double somaSalario = 0;
        double porcentagemSal_5000;

        //
        while(resposta != 'n')
        {
            //
            Console.WriteLine("Escreva o salario:");
            double user_Salario = double.Parse(Console.ReadLine());

            if(user_Salario <= 0)
            {
                Console.WriteLine("Escreva um valor positivo acima de 0!");
                return;
            }

            Console.WriteLine("Escreva os anos de estudos:");
            int anoEstudos = int.Parse(Console.ReadLine());

            if(anoEstudos <= 0)
            {
                Console.WriteLine("Escreva um valor positivo acima de 0!");
                return;
            }

            Console.WriteLine("Deseja inserir um novo Usuário? (S/N)");
            resposta = char.Parse(Console.ReadLine().ToLower());

            contPopulacao++;

            //
            somaSalario += user_Salario;
            double salarioMax = user_Salario;
            double mediaSalario = (double)somaSalario / contPopulacao;

            somaAnos += anoEstudos;
            double mediaAnos = somaAnos / contPopulacao;
            
            if(anoEstudos >= 15)
            {
                contAnos15++;
            }
            
            if(user_Salario <= 5000)
            {
                cont5000++;
            }

            if(user_Salario > salarioMax)
            {
                salarioMax = user_Salario;
            }

            porcentagemAnosEstudos = (contAnos15 / contPopulacao) * 100;
            porcentagemSal_5000 = (cont5000 / contPopulacao) * 100;

            if(resposta == 's')
            {
                
            }
            //
            else
            {
                Console.WriteLine($"média do salário da população: {mediaSalario:C}");
                Console.WriteLine($"média de anos de estudo: {mediaAnos}");
                Console.WriteLine($"maior salário: {salarioMax:C}");
                Console.WriteLine($"percentual de pessoas com salário até R$5000,00: {porcentagemSal_5000}%");
                Console.WriteLine($"percentual de pessoas com 15 ou mais anos de estudo: {porcentagemAnosEstudos}%");
            }
        }
    }
}
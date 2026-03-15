using System;

public static class atividadeanimal
{
    public static void Main2(string[] arg)
    {
        Console.WriteLine("O programa irá tentar adivinhar que animal você escolheu!");
        
        Console.WriteLine("Escolha 'vertebrados' ou 'invertebrados'");
        string choice_1 = Console.ReadLine().ToLower();
        
        if (choice_1 != "vertebrados" && choice_1 != "invertebrados")
        {
            Console.WriteLine("Escreva uma das opções!");
        }
        else
        {
            
        }
    }
}   
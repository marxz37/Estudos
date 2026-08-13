using System;
namespace CSharp
{
    class atividadevideo
    {
        static void Main2()
        {
            Console.WriteLine("Qual é o nome do seu Projeto?");
            string nameProject = Console.ReadLine();
            bool verificacao;
            double timeProject;

            do
            {
                Console.WriteLine("Quanto tempo de duração do projeto?");
            verificacao = double.TryParse(Console.ReadLine(), out timeProject);

            if(!verificacao || timeProject <= 0)
            {
                Console.WriteLine("Tente Novamente, apenas com números e que seja maior que 0.");
            }
            else
            {

            }
            }
            while(!verificacao || timeProject <= 0);

            Console.WriteLine($"\nProjeto {nameProject} foi criado com sucesso! Duração: {timeProject} Renderizado: Não");
        }
    }
}
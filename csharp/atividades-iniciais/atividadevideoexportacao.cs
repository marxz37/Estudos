using System;
namespace CSharp
{
    class atividadevideoexportacao
    {
        static void Main2()
        {
            Console.WriteLine("Nome do vídeo para exportação:");
            
            string userType = Console.ReadLine();

            for(int x = 0; x <= 100; x += 10)
            {
                Console.WriteLine($"Renderizando {x}%...");
            }
            Console.WriteLine("Exportação finalizada com sucesso, seu video '{0}' foi exportado para o youtube!", userType);
        }
    }   
}
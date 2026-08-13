using System;

namespace CSharp
{
    class length
    {
        static void Main1()
        {
            string[] videos = {"Video.mp4","Test.mp4","Edit.mp4","Minecraft.mp4","Credits.mp4"};
            for(int x = 0; x < videos.Length; x++)
            {
                Console.WriteLine($"Renderizando Video: {videos[x]}");
            }
        }
    }
}
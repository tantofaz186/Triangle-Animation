using System.IO;
using System.Numerics;

namespace Pipeline_Exercícios
{
    static class MainClass
    {
        public static void Main()
        {
            Buffer image = new Buffer(100, 100);
            image.Clear();
            Color black = new Color(0, 0, 0);

            Vector2 centro = new Vector2(50, 50);
            Vector2 tamanho = new Vector2(50, 50);
            Triangle tri = new Triangle(centro, tamanho, black);
            image.DrawPoly(tri);
            if (!Directory.Exists("Anim"))
                Directory.CreateDirectory("Anim");

            const int frames = 30;
            for (int i = 0; i < frames; i++)
            {
                tri.vertex = Transform.Translate(tri.vertex, -centro);
                tri.vertex = Transform.Rotate(tri.vertex, 360.0f / frames);
                tri.vertex = Transform.Translate(tri.vertex, centro);
                image.Clear();
                image.DrawPoly(tri);
                SaveImage.Save($"Anim/tri{i}.ppm", image.ToString());
            }
            SaveImage.Save("teste.ppm", image.ToString());
        }
    }
}
using System;
using System.Numerics;
namespace Pipeline_Exercícios
{
    public class Buffer
    {
        private Color[,] frame;

        public Buffer(int w, int h)
        {
            Config.WIDTH = w;
            Config.HEIGHT = h;
            frame = new Color[Config.WIDTH, Config.HEIGHT];
        }
        public Buffer()
        {
            frame = new Color[Config.WIDTH, Config.HEIGHT];
        }
        public void Clear(Color color)
        {
            for (int y = 0; y < Config.HEIGHT; y++)
            {
                for (int x = 0; x < Config.WIDTH; x++)
                {
                    frame[x, y] = color;
                }
            }
        }
        public void Clear()
        {
            Color white = new Color(255, 255, 255);
            Clear(white);
        }

        public void SetPixel(int x, int y, Color color)
        {
            x = Clamp(x, 0, Config.WIDTH - 1);
            y = Clamp(y, 0, Config.HEIGHT - 1);
            color.Clamp();
            frame[x, y] = color;
        }

        public void Linha(Vector2 p1, Vector2 p2, Color c)
        {
            Vector2 d = p2 - p1;
            Vector2 p = p1;
            float step = MathF.Max(MathF.Abs(d.X), MathF.Abs(d.Y));
            if (step != 0) d = d / step;
            for (int k = 0; k <= (int)step; k++)
            {
                SetPixel((int)p.X, (int)p.Y, c);
                p = p + d;
            }
        }
        public void DrawPoly(Shape shape)
        {
            int size = shape.vertex.Length;
            for (int i = 0; i < shape.vertex.Length; i++)
            {
                Linha(shape.vertex[i], shape.vertex[(i + 1) % size], shape.color);
            }
        }
        public override string ToString()
        {
            string str = "";
            for (int y = 0; y < Config.HEIGHT; y++)
            {
                for (int x = 0; x < Config.WIDTH; x++)
                {
                    str += $"{frame[x, y].r} {frame[x, y].g} {frame[x, y].b} ";
                }
                str += "\n";
            }

            return str;
        }
        static int Clamp(int val, int min, int max)
        {
            return (val > max)? max : (val < min)? min : val;
        }
    }
}
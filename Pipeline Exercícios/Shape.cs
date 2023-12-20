using System.Numerics;
namespace Pipeline_Exercícios
{
    public class Shape {
        public Vector2[] vertex;
        public Color color;
    }
    public class Rectangle : Shape { 

        public Rectangle(Vector2 pos, Vector2 size, Color c) {
            vertex = new Vector2[4];
            Vector2 min = pos - size / 2.0f;
            Vector2 max = pos + size / 2.0f;
            vertex[0] = min;
            vertex[1] = new Vector2(max.X, min.Y);
            vertex[2] = max;
            vertex[3] = new Vector2(min.X, max.Y);
            color = c;
        }
    }
    public class Triangle : Shape {
        public Triangle(Vector2 pos, Vector2 size, Color c){
            vertex = new Vector2[3];
            Vector2 min = pos - size / 2.0f;
            Vector2 max = pos + size / 2.0f;
            vertex[0] = min;
            vertex[1] = new Vector2(max.X, min.Y);
            vertex[2] = new Vector2(pos.X, max.Y);
            color = c;
        }
    }
}
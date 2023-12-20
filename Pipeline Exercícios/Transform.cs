using System;
using System.Numerics;
namespace Pipeline_Exercícios
{
    public static class Transform {

        public static Vector2[] Translate(Vector2[] vertex, Vector2 dir){
            for (int i = 0; i < vertex.Length; i++){
                vertex[i] = vertex[i] + dir;
            }
            return vertex;
        }
        public static Vector2[] Scale(Vector2[] vertex, Vector2 scale){
            for (int i = 0; i < vertex.Length; i++){
                float x = Vector2.Dot(new Vector2(scale.X,    0   ), vertex[i]);
                float y = Vector2.Dot(new Vector2(0      , scale.Y), vertex[i]);
                vertex[i] = new Vector2(x, y);
            }
            return vertex;
        }
        public static Vector2[] Skew(Vector2[] vertex, Vector2 skew){
            for (int i = 0; i < vertex.Length; i++){
                float x = Vector2.Dot(new Vector2(1     ,  skew.X), vertex[i]);
                float y = Vector2.Dot(new Vector2(skew.Y,    1   ), vertex[i]);
                vertex[i] = new Vector2(x, y);
            }
            return vertex;
        }
        public static Vector2[] Rotate(Vector2[] vertex, float angle){
            float rad = angle * 3.141592f / 180.0f;
            
            float cos = MathF.Cos(rad);
            float sin = MathF.Sin(rad);
            for (int i = 0; i < vertex.Length; i++){
                float x = Vector2.Dot(new Vector2(cos, -sin), vertex[i]);
                float y = Vector2.Dot(new Vector2(sin,  cos), vertex[i]);
                vertex[i] = new Vector2(x, y);
            }
            return vertex;
        }
    }
}
using System.IO;
namespace Pipeline_Exercícios
{
    public static class SaveImage
    {
        public static void Save(string name, string img)
        {
            string str = $"P3\n{Config.WIDTH} {Config.HEIGHT}\n255\n";
            str += img;
            File.WriteAllText(name, str);
        }
    }
}
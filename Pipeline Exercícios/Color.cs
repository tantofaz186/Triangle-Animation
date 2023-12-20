namespace Pipeline_Exercícios
{
    public class Color {
        public int r, g, b;
        public Color(int r, int g, int b){
            this.r = r;
            this.g = g;
            this.b = b;
        }

        /// <summary>
        /// clamp color RGB values from 0 to 255
        /// </summary>
        public void Clamp()
        {
            r = r > 255 ? 255 : r < 0 ? 0 : r;
            g = g > 255 ? 255 : g < 0 ? 0 : g;
            b = b > 255 ? 255 : b < 0 ? 0 : b;
        }
    }
}
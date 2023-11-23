namespace Adapterino
{
    public struct ARGBValue
    {
        byte Alpha { get; set; }
        byte Red { get; set; }
        byte Green { get; set; }
        byte Blue { get; set; }

        public ARGBValue(byte alpha, byte red, byte green, byte blue)
        {
            Alpha = alpha;
            Red = red;
            Green = green;
            Blue = blue;
        }

        public void Set(byte alpha, byte red,byte green,byte blue)
        {
            Alpha = alpha;
            Red = red;
            Green = green;
            Blue = blue;
        }

        public override string ToString()
        {
            return (this.Alpha + "," + this.Red + "," + this.Green + "," + this.Blue).ToString();
        }
    }
}

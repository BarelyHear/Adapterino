using System.Text;

namespace Adapterino
{
    struct Frame
    {
        private ARGBValue[,]? frameData;
        private readonly ushort width = 1920;
        private readonly ushort height = 1080;


        public Frame()
        {
            Random random = new Random();
            ARGBValue[,] frame = new ARGBValue[width, height];
            ARGBValue val = new ARGBValue();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    val.Set((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
                    frame[j, i] = val;
                }
            }
            this.frameData = frame;
        }

        public string GetData()
        {
            if (this.frameData != null)
            {
                StringBuilder result = new StringBuilder();
                for (uint i = 0; i < height; i++)
                {
                    for (uint j = 0; j < width; j++)
                    {
                        result.Append("{");
                        ARGBValue val = frameData[j, i];
                        result.Append(val.ToString());
                        result.Append("}");
                    }
                }
                return result.ToString();
            }
            return "{Error}";
        }

    }

}

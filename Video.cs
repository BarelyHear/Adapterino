namespace Adapterino
{
    internal class Video
    {
        public byte FrameRate { get; set; }

        private Frame[]? videoData;
        public Video(uint lengthInFrames = 1)
        {
            if (lengthInFrames > 0)
            {
                for (uint i = 0; i < lengthInFrames; i++)
                {
                    this.videoData[i] = new Frame();
                }
            }
        }


        public Video GetVideo()
        {
            return this;
        }

        /*
        public void Save(string fileName)
        {
            StreamWriter streamWriter = new StreamWriter(fileName);
            Frame frame = new Frame();
            for (uint i = 0; i < videoData.Length; i++)
            {
                frame = videoData[i];
                for (uint y = 0; y < videoData.GetLength(0); y++)
                {
                    for (uint x = 0; x < videoData.GetLength(1); x++)
                    {
 //                       streamWriter.Write(frame.)
                    }
                }

            }
        }*/
    }
}

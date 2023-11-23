using System.ComponentModel;
using System.Diagnostics;

namespace Adapterino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Frame[] frame = new Frame[100];
            Console.ReadKey();
            Console.WriteLine();
            ARGBValue val = new ARGBValue(255, 255, 255, 255);
            Console.WriteLine("{" + val.ToString() + "}");
            Double mInput = Double.Parse(Console.ReadLine());
            long[] times = new long[(int)mInput];

            Console.WriteLine();
            Stopwatch stopwatch = new Stopwatch();
            for (int i = 0; i < times.Length; i++)
            {
                frame[i] = new Frame();
                stopwatch.Restart();
                string foo = frame[i].GetData();
                stopwatch.Stop();
                times[i] = stopwatch.ElapsedMilliseconds;
            }


            UInt128 temp = 0;
            for (int i = 0; i < times.Length; i++)
            {
                temp = temp + (UInt128)times[i];
            }

            temp /= (UInt128)mInput;


            Console.WriteLine(temp + " ms per frame on average. Average of " + times.Length + " frames.");
            TimeSpan ts = GC.GetTotalPauseDuration();
            Console.WriteLine(ts.TotalSeconds + " seconds spent on GC.");


        }
    }
}
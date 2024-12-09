using NAudio.Wave;

namespace Complete_1x1_Color
{
    internal class Program
    {
        private static IWavePlayer waveOutDevice;
        private static AudioFileReader audioFileReader;

        static void Main(string[] args)
        {
            ConsoleColor[] colors =
            {
                ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Green
            };
            string musicPath = Directory.GetCurrentDirectory() + @"/Music.mp3";
            int colorCode = -1;

            Play(musicPath);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Reihe {i}");

                for (int j = 1; j <= 10; j++)
                {
                    colorCode++;
                    if (colorCode >= colors.Length)
                        colorCode = 0;

                    Console.ForegroundColor = colors[colorCode];
                    Console.WriteLine($"{i}".PadRight(2) + " * " + $"{j}".PadRight(2) + " = " + $"{i * j}".PadRight(3));
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static void Play(string filePath)
        {
            waveOutDevice = new WaveOutEvent();
            audioFileReader = new AudioFileReader(filePath);

            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }
    }
}

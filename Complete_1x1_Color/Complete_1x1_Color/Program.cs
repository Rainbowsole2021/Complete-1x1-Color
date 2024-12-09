namespace Complete_1x1_Color
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            ConsoleColor[] color = Enum.GetValues<ConsoleColor>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Reihe {i}");

                for (int j = 1; j <= 10; j++)
                {
                    Console.ForegroundColor = color[random.Next(0, color.Length)];
                    Console.WriteLine($"{i}".PadRight(2) + " * " + $"{j}".PadRight(2) + " = " + $"{i * j}".PadRight(3));
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

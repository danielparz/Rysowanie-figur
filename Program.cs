using System;

namespace Rysowanie_figur
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość boku:");
            int a = Int32.Parse(Console.ReadLine());

            Program.Kwadrat(a);
            Console.WriteLine();
            Program.TrojkatProstokatny(a);
            Console.WriteLine("");
            Program.TrojkatRownoramienny(a);

        }

        public static void Kwadrat(int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                    Console.Write("* ");
                Console.Write("\n");
            }
        }

        public static void TrojkatProstokatny(int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
            }
        }

        public static void TrojkatRownoramienny(int a)
        {
            if (a % 2 == 0)
            {
                for (int i = 1; i < a / 2 + 1; i++)
                {
                    for (int j = a / 2; j > i; j--)
                        Console.Write("  ");
                    for (int j = 0; j < i * 2; j++)
                        Console.Write("* ");
                    Console.Write("\n");
                }
            }
            else
            {
                for (int i = 1; i <= a / 2 + 1; i++)
                {
                    for (int j = a / 2 + 1; j > i; j--)
                        Console.Write("  ");
                    for (int j = 0; j < i * 2 - 1; j++)
                        Console.Write("* ");
                    Console.Write("\n");
                }
            }
        }
    }
}
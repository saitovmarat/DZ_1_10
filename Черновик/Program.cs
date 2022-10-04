using System;

namespace Черновик
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 10");
            int[] bubble = { 52, 44, 13, 26, 1 };
            int var;
            for (int i = 0; i < bubble.Length; i++)
            {
                for (int j = 0; j < bubble.Length - 1 - i; j++)
                {
                    if (bubble[j] > bubble[j + 1])
                    {
                        var = bubble[j];
                        bubble[j] = bubble[j + 1];
                        bubble[j + 1] = var;
                    }
                }
            }
            for (int k = 0; k < bubble.Length; k++)
            {
                Console.Write(bubble[k] + " ");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

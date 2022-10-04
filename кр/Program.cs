using System;

namespace кр
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3");
            int[] numbers = {1, 3, 2, 4, 6, 5};
            int var;
            for (int w = 0; w < numbers.Length; w++)
            {
                for (int e = 0; e < numbers.Length - 1 - w; e++)
                {
                    if (numbers[e] > numbers[e + 1])
                    {
                        var = numbers[e];
                        numbers[e] = numbers[e+1];
                        numbers[e+1] = var;
                    }
                }
            }
            for (int r = 0; r < numbers.Length; r++)
            {
                Console.Write(numbers[r] + " ");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

using System;

namespace DZ_1_10
{
    class Program
    {
        static string kv_ur(double a, double b, double c)
        {
                double d = b * b - 4 * a * c;
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                string otv = $"x1 = {x1}, x2 = {x2}";
                return otv;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine(kv_ur(1, 2, 1));
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 2");
            Random random = new Random();
            int[] mas = new int[20];
            for (int i = 0; i < 20; i++)
            {
                mas[i] = random.Next(1, 1000);
                Console.WriteLine($"{i + 1}) {mas[i]}");
            }
            Console.WriteLine("Ввести два разных числа из выведенного списка");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            for (int j = 0; j < mas.Length; j++)
            {
                if (mas[j] == num1)
                {
                    mas[j] = num2;
                }
                else if (mas[j] == num2)
                {
                    mas[j] = num1;
                }
            }
            for (int k = 0; k < mas.Length; k++)
            {
                Console.WriteLine($"{k + 1}) {mas[k]}");
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 3");
            int[] numbers = new int[] {1, 2, 4, 3, 5, 6};
            int qw = 0;
            for (int w = 0; w < numbers.Length; w++)
            {
                for (int e = 1; e < numbers.Length-1-w; e++)
                {
                    if (numbers[w] > numbers[e])
                    {
                        qw = numbers[w];
                        numbers[w] = numbers[e];
                        numbers[e] = qw;
                    }                    
                }
            }
            for (int r = 0; r<numbers.Length; r++)
            {
                Console.Write($"{numbers[r]}, ");
            }



        }
    }
}

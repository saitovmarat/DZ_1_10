using System;
using System.Threading;

namespace DZ_1_10
{
    class Program
    {
        struct ded
        {
            public string name;
            public int vorch_level;
            public string[] vorch_words;
            public ded(string name, int vorch_level, string[] vorch_words)
            {
                this.name = name;
                this.vorch_level = vorch_level;
                this.vorch_words = vorch_words;
            }
        }
        static void Task1(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"x1 = {x1}, x2 = {x2}");
        }
        static void Task2(int a, int b, int[] mas)
        {
            for (int j = 0; j < mas.Length; j++)
            {
                if (mas[j] == a)
                {
                    mas[j] = b;
                }
                else if (mas[j] == b)
                {
                    mas[j] = a;
                }
            }
            for (int k = 0; k < mas.Length; k++)
            {
                Console.WriteLine($"{k + 1}) {mas[k]}");
            }
        }
        static void Task3(int[] numbers, int qw)
        {
            for (int w = 0; w < numbers.Length; w++)
            {
                for (int e = 0; e < numbers.Length - 1 - w; e++)
                {
                    if (numbers[e] > numbers[e + 1])
                    {
                        qw = numbers[e];
                        numbers[e] = numbers[e + 1];
                        numbers[e + 1] = qw;
                    }
                }
            }
            for (int r = 0; r < numbers.Length; r++)
            {
                Console.Write(numbers[r] + " ");
            }
        }
        static void Task5(double parametrs)
        {
            if ((parametrs >= 0) && (parametrs <= 9))
            {
                Console.WriteLine("#");
            }
            else if ((parametrs < 0) || (parametrs > 9))
            {
                Thread.Sleep(3000);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Error");
                Console.ResetColor();
            }
        }
        static int Task6(string[] vorch_words, string[] curse_words)
        {
            int cnt_fingals = 0;
            for (int t = 0; t < vorch_words.Length; t++)
            {
                for (int y = 0; y < curse_words.Length; y++)
                {
                    if (vorch_words[t] == curse_words[y])
                    {
                        cnt_fingals++;
                    }
                }
            }
            return cnt_fingals;
        }
        static int[] Task7(int[] strs)
        {
            int[] str = new int[strs.Length];
            Array.Sort(strs);
            for (int i = 0; i < strs.Length; i++)
            {
                str[i] = strs[i];
            }
            return str;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Task1(1, 2, 1);
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
            Task2(num1, num2, mas);
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 3");
            int[] numbers = { 1, 3, 2, 4, 6, 5 };
            int qw = 0;
            Task3(numbers, qw);
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 4");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 5");
            int flag = 2;
            while (flag > 1)
            {
                string qq = Console.ReadLine();
                if (qq == "exit" || qq == "закрыть")
                {
                    flag -= 2;
                    Console.Clear();
                }
                else
                {
                    try
                    {
                        double w = double.Parse(qq);
                        Task5(w);
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Error");
                    }
                }
            }


            Console.WriteLine("Task 6");
            ded valera = new ded();
            valera.name = "Валера";
            valera.vorch_level = 0;
            valera.vorch_words = new string[] { "Бестолочь", "Негодяй" };
            ded vasiliy = new ded();
            vasiliy.name = "Василий";
            vasiliy.vorch_level = 1;
            vasiliy.vorch_words = new string[] { "Увалень", "Негодяй" };
            ded grigoriy = new ded();
            grigoriy.name = "Григорий";
            grigoriy.vorch_level = 2;
            grigoriy.vorch_words = new string[] { "Бестолочь", "Бездельник" };
            ded petr = new ded();
            petr.name = "Петр";
            petr.vorch_level = 3;
            petr.vorch_words = new string[] { "Бестолочь", "Нехороший человек", "Редиска" };
            ded genadiy = new ded();
            genadiy.name = "Генадий";
            genadiy.vorch_level = 4;
            genadiy.vorch_words = new string[] { "Бестолочь", "Проститутки" };

            string[] curse_words = new string[] { "Бестолочь", "Негодяй" };
            Console.WriteLine($"Кол-во синяков получивших Валера: { Task6(valera.vorch_words, curse_words)}.");
            Console.WriteLine($"Кол-во синяков получивших Василий: { Task6(vasiliy.vorch_words, curse_words)}.");
            Console.WriteLine($"Кол-во синяков получивших Григорий: { Task6(grigoriy.vorch_words, curse_words)}.");
            Console.WriteLine($"Кол-во синяков получивших Петр: { Task6(petr.vorch_words, curse_words)}.");
            Console.WriteLine($"Кол-во синяков получивших Генадий: { Task6(genadiy.vorch_words, curse_words)}.");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 7");
            int[] strs = new int[] { 1, 3, 4, 2, 5 };
            for (int sorting_num = 0; sorting_num < Task7(strs).Length; sorting_num++)
            {
                Console.Write(Task7(strs)[sorting_num] + " ");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

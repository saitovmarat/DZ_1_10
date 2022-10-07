using System;
using System.Threading;

namespace кр
{
    class Program
    {
        static int Task1(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }
        static int[] Task2(int num1, int num2)
        {
            int[] strs = new int[] { num2, num1 };
            return strs;
        }
        static bool/*int*/ Task3(int num1)
        {
            int fact = 1;
            try
            {
                checked
                {
                    for (int i = 1; i < (num1 + 1); i++)
                    {
                        fact *= i;
                    }
                    return true; //fact
                }
            }
            catch (OverflowException)
            {
                return false;//0
            }
        }
        static int Task4(int num1)
        {
            if (num1 == 1)
            {
                return 1;
            }
            return num1 * Task4(num1 - 1);
        }
        static void Task5_1(int num1, int num2)
        {
            int nod = 0;
            for (int i = 1; i < (num1*num2)+1; i++)
            {
                if ((num1%i == 0)&&(num2%i == 0))
                {
                    nod = i;
                }
            }
            Console.WriteLine(nod);
        }
        static void Task5_2(int num1, int num2, int num3)
        {
            int nod = 0;
            for (int i = 1; i < (num1 * num2 * num3) + 1; i++)
            {
                if ((num1 % i == 0) && (num2 % i == 0) && (num3 % i == 0))
                {
                    nod = i;
                }
            }
            Console.WriteLine(nod);
        }
        static int Task6(int num1)
        {
            int fib_num = 0;
            if ((num1 == 2) || (num1 == 1))
            {
                fib_num = 1;
            }
            else
            {
                fib_num = Task6(num1 - 1) + Task6(num1 - 2);
            }            
            return fib_num;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine(Task1(1, 2));
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 2");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(Task2(1,2)[i]);
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 3");
            Console.WriteLine(Task3(9999));
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 4");
            Console.WriteLine(Task4(5));
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 5");
            Task5_1(24, 60);
            Task5_2(24, 60, 36);
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 6");
            Console.WriteLine(Task6(4));
            Console.ReadKey();
            Console.Clear();
        }
    }
}


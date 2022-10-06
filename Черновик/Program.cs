using System;
using System.Threading;

namespace Черновик
{
    class Program
    {
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
        static void Main()
        {
            int[] strs = new int[] { 1, 3, 4, 2, 5 };
            for (int i = 0; i < Task7(strs).Length; i++)
            {
                Console.Write(Task7(strs)[i] + " ");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

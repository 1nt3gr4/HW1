using System;

namespace _3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            int x, y, n;

            n = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                y = Convert.ToInt32(Console.ReadLine());
                if (y >= x)
                {
                    check = false;
                    break;
                }
            }
            if (check)
                Console.WriteLine("Введённая последовательность является бесконечно убывающей.");
            else
                Console.WriteLine("Введённая последовательность не является бесконечно убывающей.");
        }
    }
}

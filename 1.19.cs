using System;

namespace _1._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 0;
            int y0 = y;
            int s = 0;

            for(int i = 0; i < 4; i++)
            {
                a = x % 10;
                for (int j = 0; j < 4; j++)
                {
                    b = y % 10;
                    if ((a == b) & (j != i))
                        s += 1;
                    y /= 10;
                }
                x /= 10;
                y = y0;
            }
            Console.WriteLine(s);
        }
    }
}

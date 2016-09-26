using System;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0, y0, R;
            int n;
            x0 = Convert.ToDouble(Console.ReadLine());
            y0 = Convert.ToDouble(Console.ReadLine());
            R = Convert.ToDouble(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            double x, y;
            double xmin = 100500, ymin = 100500;
            double s = 0;
            double smin = (xmin - x0) * (xmin - x0) + (ymin - y0) * (ymin - y0);
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                s = (x - x0) * (x - x0) + (y - y0) * (y - y0);
                if ((s < smin) && (s > R * R))
                {
                    xmin = x;
                    ymin = y;
                    smin = s;
                }

            }
            Console.WriteLine("({0};{1})", xmin, ymin);
        }
    }
}

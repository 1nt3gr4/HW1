using System;

namespace practice
{
    class letuchka
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (((x >= 0) && (y >= 0) && (x <= 1) && (y <= 1)) || ((x >= 0) && (y <= 0) && (y >= -x * x)))
                Console.WriteLine("Принадлежит");
            else
                Console.WriteLine("Не принадлежит");
        }
    }
}

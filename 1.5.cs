using System;

namespace _1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            char x1 = (char)Console.Read();
            int y1 = Convert.ToInt32(Console.ReadLine());
            char x2 = (char)Console.Read();
            int y2 = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
                Console.WriteLine("Данные клетки лежат на одной диагонали.");
            else
                Console.WriteLine("Данные клетки не лежат на одной диагонали.");
        }
    }
}

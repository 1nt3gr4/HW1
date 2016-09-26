using System;

namespace _4._14
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = Convert.ToInt32(Console.ReadLine());

            switch (factorial)
            {
                case 0:
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                    Console.WriteLine(6);
                    break;
                case 4:
                    Console.WriteLine(4);
                    break;
            }

            if (factorial >= 5)
                Console.WriteLine(0);
        }
    }
}

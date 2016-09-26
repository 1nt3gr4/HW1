using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, k; 
            a1 = Convert.ToInt32(Console.ReadLine());
            a2 = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());

            int d, ak; 
            d = a2 - a1;
            ak = a1 + d * (k - 1);

            Console.WriteLine("Искомый член прогрессии: {0}", ak);
        }
    }
}

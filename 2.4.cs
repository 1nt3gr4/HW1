using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int f, s, n;
            f = Convert.ToInt32(Console.ReadLine());
            s = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int k = (n - f) / s + 1;

            if (n != f + s * (k - 1))
                k = -1;
            Console.WriteLine(k);
        }
    }
}

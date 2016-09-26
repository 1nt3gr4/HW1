using System;

namespace _4._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int len = 0;
            int sum = 0;
            int maxLen = 0;

            for (int i = 0; i < n; i++)
            {
                for (int k = i + 1; sum < n; k++)
                {
                    sum += k;
                    len += 1;
                }
                if (sum == n)
                    if (len > maxLen)
                        maxLen = len;
                sum = 0;
                len = 0;
            }
            Console.WriteLine(maxLen);
        }
    }
}

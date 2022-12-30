using System;
using System.Globalization;

namespace cal
{
    class Cal
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;
            int i, k;
            long jc=1;
            Console.Write("Pleastinput a positive number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=1;i<=n; i++)
            {
                jc = jc * i;
            }
            
            Console.WriteLine("{0}的阶乘是：{1}", n, jc);
            for (i = 5; i <= n; i = i + 5)
            {
                int m = i;
                for (k = 0; m % 5 == 0; k++)
                    m = m / 5;
                sum = sum + k;
            }
            Console.WriteLine("The number of zero in {0}! is: {1}", n, sum);
        }
    }
}
  
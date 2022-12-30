using System;
namespace cal
{
    class Cal
    {
        static void Main(string[] args)
        {
            int x, i, m;
            Console.Write("请输入整数：");
            x = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Math.Sqrt(x));
            for (i = 2; i <= m; i++)
            {
                if (x % i == 0)
                    break;
            }
            if (i > m)
                Console.WriteLine("{0}是素数", x);
            else
                Console.WriteLine("{0}不是素数", x);
        }
    }
}
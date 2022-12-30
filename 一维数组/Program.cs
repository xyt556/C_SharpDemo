using System;
namespace cal
{
    class Cal
    {
        private static object fib;

        static void Main(string[] args)
        {
            int n, sum;
            Console.Write("请输入n: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("输入错误，n应为大于等于0的整数！");
            }
            else if (n == 0)
            {
                Console.WriteLine("第0项是0，和值是0");
            }
            else if (n == 1)
            {
                Console.WriteLine("第1项是1，和值是1");
            }
            else
            {
                int[] fib = new int[n + 1];//创建数组
                fib[0] = 0;
                fib[1] = 1;
                sum = 1;
                for (int i = 2; i < n + 1; i++)//数组赋值
                {
                    fib[i] = fib[i - 1] + fib[i - 2];
                    sum += fib[i];
                }
                Console.WriteLine("第{0}项是{1}，和值是{2}", n, fib[n], sum);
                // 打印数组元素
                // foreach语句的使用
                foreach (int i in fib)
                {
                    Console.WriteLine(i);
                }
            }
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入n的值：");
            int n = int.Parse(Console.ReadLine());

            int[] fib = new int[n + 1];  // 申明并初始化长度为n+1的一维数组
            fib[0] = 0;  // 数列第一项为0
            if (n > 0)
            {
                fib[1] = 1;  // 数列第二项为1
                for (int i = 2; i <= n; i++)
                {
                    fib[i] = fib[i - 1] + fib[i - 2];  // 计算数列的第i项
                }
            }

            int sum = 0;  // 前n项和
            for (int i = 0; i <= n; i++)
            {
                sum += fib[i];
            }

            Console.WriteLine("斐波那契数列的第{0}项为：{1}", n, fib[n]);
            Console.WriteLine("斐波那契数列的前{0}项和为：{1}", n, sum);
        }
    }
}

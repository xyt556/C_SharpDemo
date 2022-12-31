using System;

// 打印九九乘法表
namespace cal
{
    class cal
    {
        static void Main(string[] args)
        {
            /*求水仙花数
             * 如果一个三位数的个位数、十位数和百位数的立方和等于该数自身，则称该数为水仙花数。*/
            int n, i, j, k;
            for (n = 100; n <= 999; n++)
            {
                i = n / 100; // 取出n的百位数
                j = (n / 10) % 10; // 取数n的十位数
                k = n % 10; // 取出n的个位数
                if (n == i * i * i + j * j * j + k * k * k)
                    Console.WriteLine("{0} = {1}^3 + {2}^3 + {3}^3", n, i, j, k);
            }
            /*循环体嵌套——编写程序制作九九乘法表当循环语句中的循环体又包含另一个循环语句时，就构成了嵌套循环。*/
            i = 1;
            j = 1;
            Console.WriteLine("************九九乘法表**************");
            for (i = 1; i < 10; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}*{1}={2}\t", j, i, i * j);
                Console.WriteLine();
            }

        }
    }
}

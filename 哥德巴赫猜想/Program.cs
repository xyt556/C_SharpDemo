/*Title: 歌德巴赫猜想
Description: 哥德巴赫猜想是指：任一大于2的偶数都可以表
示成两个质数之和。例如：6=3+3，8=3+5等。编写程序验证
哥德巴赫猜想。
Input:输入大于2的偶数N
Output: 输出N表示成两个质数和的形式。（小的质数在前，
大的质数在后）
sample_input:
10
sample_output:
10 = 3 + 7
10 = 5 + 5
本题借助循环先枚举出可能是其加数的一个质数，然后算出另一个加数检查是否为质数；如果是，即为满足题目要求的一个解。*/
using System;
class pro
{
    static void Main()
    {
        int N;
        N = Convert.ToInt32(Console.ReadLine());
        for (int X = 2; X <= N / 2; X++)
        {
            int j;
            for (j = 2; j < X; j++)
                if (X % j == 0) break;
            if (X == j)//X为质数，有可能是N的一个满足要求的质加数
            {
                int k, Y = N - X;//计算出N的另一个加数，检查是否为质数
                for (k = 2; k < Y; k++)
                    if (Y % k == 0) break;
                if (k == Y) Console.WriteLine("{0}={1}+{2}", N, X, Y);
            }
        }
    }
}
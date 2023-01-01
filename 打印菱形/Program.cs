/*Title: 打印菱形
Description: 输入奇数的行数，打印菱形图案。注意：菱形的左角挨着窗体边缘。
Input: 输入菱形的行数
Output: 输出菱形
sample_input:
5
sample_output:
菱形的输出可以看成是上半部分三角形的输出和下半部分三角形的输出叠加；
（1）上半部分：前导空格个数，总行数/2+1-当前行号；星号个数，当前行号*2-1；
（2）下半部分：前导空格个数，当前行号-总行数/2-1；星号个数，（总行数-当前行号）*2+1；*/

using System;
class pro
{
    static void Main()
    {
        int N;
        N = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= N; i++)//输出第i行
        {
            if (i <= N / 2 + 1)
            {
                for (int j = 1; j <= N / 2 + 1 - i; j++)
                    Console.Write(" ");
                //输出星号
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                //一行的空格和星号输出完毕，换行
                Console.WriteLine();
            }
            else
            {
                for (int j = 1; j <= i - N / 2 - 1; j++)
                    Console.Write(" ");
                //输出星号
                for (int j = 1; j <= 2 * (N - i) + 1; j++)
                    Console.Write("*");
                //一行的空格和星号输出完毕，换行
                Console.WriteLine();
            }
        }
    }
}
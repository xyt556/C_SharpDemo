/*Title: 打印三角形
Description: 输入行数，打印由* 组成的等腰三角形。注意：三角形的左下角挨着窗体边缘。
Input:输入三角形的行数
Output: 输出相应的等腰三角形
本题主要是分析三角形每一行的星号个数以及星号之前空格
个数与行号的关系:
(1)
星号个数：2*行号-1
(2)前导空格个数：总行数-当前行号
编程实现时，只需要用循环控制每行空格和星号按照计算出
的个数输出即可。*/

using System;
class pro
{
    static void Main()
    {
        int N;
        N = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= N; i++)//输出第i行
        {
            //输出前导空格
            for (int j = 1; j <= N - i; j++)
                Console.Write(" ");
            //输出星号
            for (int j = 1; j <= 2 * i - 1; j++)
                Console.Write("*");
            //一行的空格和星号输出完毕，换行
            Console.WriteLine();
        }
    }
}
/*Title: 切割纸板
Description: 一张长为m厘米，宽为n厘米的长方形纸板，现在要将它完全切割成若干块大小相同的小正方形纸板。如果要使切割的小正方形纸板面积最大，该小正方形的边长应该为多少厘米？要求小正方形的边长为整数厘米，m和n也为正整数。
Input: 输入m和n的值（m、n为正整数）
Output: 输出小正方形的边长
sample_input:
6
9
sample_output:
3
分析题意发现，只有按照长和宽的最大公约数作为小正方形的边长切割能满足题目要求。因此，本题借助循环结构，来找
寻两个整数的最大公约数。
找寻最大公约数最直观的方法就是枚举法，从两个数的较小那一个向1递减枚举，找到的第一个同时是两个数因子的数就是这两个数的最大公约数。*/
using System;
class pro
{
    static void Main()
    {
        int M,N;
        M = Convert.ToInt32(Console.ReadLine());
        N = Convert.ToInt32(Console.ReadLine());
        for (int i = M < N ? M : N; i >= 1; i--)
            if (M % i == 0 && N % i == 0)
            {
                Console.WriteLine("{0}", i);
                break;
            }
    }
}
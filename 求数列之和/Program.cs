/*
Title: 求数列之和
Description: 求数列1、1 / 2、1 / 3、1 / 4、1 / 5 …… 1 / N之和。结果小数点后面保留2位小数。
Input: 输入正整数N
Output: 输出数列之和
sample_input:
100
sample_output:
5.1974
本题可借助循环结构实现数列各项累加：
（1）数列中各项数据的规律：分子为1，分母从1依次累增1；
（2）注意C#中运算符/的含义，对于整数相除取整数商（余数部分由%运算获取），对于实数相除则获取实数商。题目中1/2,1/3等数据项应该按照实数相除的含义使用/，否则数列中从第二项起各项结果都为0。*/
using System;
class pro
{
    static void Main()
    {
        int n;
        double sum = 0;
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
            sum = sum + 1.0 / i;
        Console.WriteLine("{0:f4}", sum);
    }
}
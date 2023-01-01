/*
Title: 整数位数
Description: 编写程序输入一个数，输出其整数部分的位数（例如输入123 .4则输出3，输入－0.6则输出0）。
Input: 输入为实型。
Output: 输出为其整数部分的位数
sample_input:
123.4
sample_output:
3
本题求任何实数的整数位数，方便起见可以：
（1）取绝对值；
（2）切除小数部分；
对剩下的整数部分计算其位数，可以使用反复除以
10观察其商是否为0，除以10的次数即为其位数*/
using System;
class pro
{
    static void Main()
    {
        double x;
        x = Convert.ToDouble(Console.ReadLine());
        int y = Convert.ToInt32(Math.Truncate(Math.Abs(x)));
        int cnt = 0;
        while (y > 0)
        {
            cnt++;
            y = y / 10;
        }
        Console.WriteLine("{0}", cnt);
    }
}
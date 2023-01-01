/*
Title: 面积计算
Description: 输入正N边形的边数和边长值，输出其面积。
Input: 输入边数N和边长值R（6 >= N >= 3）
Output: 输出正N边形的面积，保留2位小数。
sample_input:
4 1
sample_output:
1.00
本题主要难点在于知道正N边形的面积计算公式。
S=N* R/2 * R/2/Math.Tan(3.14/N)*/
using Microsoft.VisualBasic;
using System;
class pro
{
    static void Main()
    {
        string t;
        t = Console.ReadLine();
        string[] st = t.Split(' ');
        int N, R;
        N = Convert.ToInt32(st[0]);
        R = Convert.ToInt32(st[1]);
        if (n == 3) console.writeline("{0:f2}", math.sqrt(3 * r * r / 4));
        if (n == 4) console.writeline("{0:f2}", r * r);
        if (n == 5) console.writeline("{0:f2}", 1.72 * r * r);
        if (n == 6) console.writeline("{0:f2}", math.sqrt(3) * r * r * 1.5);
        // 或者
        // Console.WriteLine("{0:f2}", N * R / 2 * R / 2 / Math.Tan(3.14 / N));
    }
}
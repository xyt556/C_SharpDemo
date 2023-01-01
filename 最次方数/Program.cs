/*
Title: 最次方数
Description: 编写程序求一个整数的任意次方的最后三位数。
Input: 输入均为整型，首先为x，其后为a。
Output: 输出为整型。
sample_input:
13
13
sample_output:
253
本题如果直接计算
x的a次方有可能超出数据表示范围；
本题只需要最后次方结果的低三位，因此可以在计算
x的a次方的累乘过程中每次只保存结果的后三位进行累乘，避免溢出问题。*/
using System;
class pro
{
    static void Main()
    {
        int x,a,mul = 1;
        x = Convert.ToInt32(Console.ReadLine());
        a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= a; i++)
            mul = mul * x % 1000;
        Console.WriteLine("{0}", mul);
    }
}

/*
Title: 字母金字塔
Description: 输入正整数N，输出N行的字母金字塔。
Input: 输入一个正整数N
Output: 输出N行的字母金字塔。
sample_input:
3
sample_output:
A
BB
CCC
本题的字母金字塔规律如下：
（1）每一行的字母个数与行号相等；
（2）每一行输出的字母在字母表中的排序与行号相等；*/
using System;
class pro
{
    static void Main()
    {
        int N;
        N = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write("{0}", Convert.ToChar(65 + i - 1));
            Console.WriteLine();
        }
    }
}
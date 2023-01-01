/*
Title: 两个数的平方和
Description: 输入正整数N，找出所有满足N = X2 + Y2的正整数对X和Y（X <= Y）。
Input: 输入一个正整数N
Output: 输出X和Y，每行输出一种组合，按照x值升序排列，空格隔开X和Y的值。如果没有满足条件的X和Y正整数对，则输出“Not found”。
sample_input:
100
sample_output:
6 8
本题借助循环进行所有可能的
X和Y的组合枚举，然后检查是否符合题目中函数关系。*/
using System;
class pro
{
    static void Main()
    {
        int X,Y,N,cnt = 0;
        N = Convert.ToInt32(Console.ReadLine());
        for (X = 1; X <= Math.Sqrt(N); X++)
            for (Y = X; Y <= Math.Sqrt(N - X * X); Y++)
                if (X * X + Y * Y == N)
                {
                    Console.WriteLine("{0} {1}", X, Y);
                    cnt++;
                }
        if (cnt == 0) Console.WriteLine("Not found");
    }
}
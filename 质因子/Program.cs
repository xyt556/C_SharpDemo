/*
Title: 质因子
Description: 输出整数N的所有质因子。
Input: 输入N，N为正整数
Output: 输出N的所有质因子（不重复，按照升序排列），用空格隔开
sample_input:
6
sample_output:
2 3
借助循环来实现找出一个数的所有因子，同时判定该因
子是否为符合要求的质因子。
判定一个数是否为质数的条件：只有1和本身两个因子的数即为质数。*/
using System;
class pro
{
    private static int i;

    static void Main()
    {
        int N;
        N = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i <= N; i++)
        {
            if (N % i == 0)//是该数的因子
            {
                if (i == 2 || i == 3 || i == 5 || i == 7) //如有2,3,5,7因子，则直接输出
                {
                    Console.Write("{0} ", i);
                    continue;
                }

            }
        }
        if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)//有可能是质因子
        {
            int j;
            for (j = 2; j < i; j++)
                if (i % j == 0) break;
            if (i == j) Console.Write("{0} ", i);//i是质数
        }
    }
}
/*
Title: 最大公约数和最小公倍数
Description: 求两个正整数的最大公约数和最小公倍数。
Input: 输入两个正整数M和N，用空格隔开
Output: 输出M和N的最大公约数和最小公倍数，用空格隔开。
sample_input:
10 15
sample_output:
5
30
本题考查数学知识在编程中的实现：
求最大公约数可以使用枚举法、辗转相除法等；
求最小公倍数可以使用枚举法、乘积除以最大公约数等；*/
using System;
class pro
{
    static int gcd(int m, int n) //使用欧几里德算法求最大公约数
    {
        int r;
        while (n != 0)
        { //欧几里德算法，原理是：
            r = m % n; //r为m/n的余数
            m = n; //则gcd(m,n)=gcd(n,r)=...
            n = r; //r=0时n即是gcd
        }
        return m;
    }
    static int lcm(int m, int n)//使用枚举法求最小公倍数
    {
        for (int i = m > n ? m : n; i <= m * n; i++)
            if (i % m == 0 && i % n == 0) return i;
        return m* n;
    }

    static void Main()
    {
        int m, n;
        m = Convert.ToInt32(Console.ReadLine());
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0}和{1}的最大公约数是:{2}", m, n, gcd(m, n));
        Console.WriteLine("{0}和{1}的最小公倍数数是:{2}", m, n, lcm(m, n));
    }

}
/*
Title: 发车问题
Description: 甲路车每m分钟发一次车，乙路车每n分钟发一次车，两车同时发车，问经过多少分钟甲路车和乙路车第二次同时发车？
Input: 输入m和n的值（m、n为正整数）
Output: 输出第一次同时发车到第二次同时发车的间隔时间
sample_input:
2
3
sample_output:
6
仔细阅读题意，会发现甲乙两路车两次同时发车的时间间隔
就是各自发车时间间隔数的最小公倍数，因此本题即为借助循
环找寻两个数的最小公倍数。
找寻两个的最小公倍数，最简单的方法即为枚举法，从两个
数中较大的一个开始检查到两数乘积，在这个区间内找到的第
一个能整除两个数的即为他们的最小公倍数。*/
using System;

class pro
{
    static void Main()
    {
        int m, n;
        m = Convert.ToInt32(Console.ReadLine());
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = m >= n ? m : n; i <= m * n; i++)
        {
            if (i % m == 0 && i % n == 0)
            {
                Console.WriteLine("{0}", i);
                break;
            }
        }
    }
}
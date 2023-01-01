/*
Title: 五猴分桃
Description: 5只猴子一起摘了1堆桃子。因为太累了，它们商量决定，先睡一觉再分。
过了不知多久，1只猴子来了。它见别的猴子没来，便将这1堆桃子平均分成5份，结果多了1个，就将多的这个吃了，拿走其中的1堆。
又过了不知多久，第2只猴子来了。它不知道有1个同伴已经来过，还以为自己是第1个到的呢。
于是将地上的桃子堆起来，平均分成5份，发现也多了1个，同样吃了这1个，拿走其中的1堆。
第3只、第4只、第5只猴子都是这样……问这5只猴子至少摘了多少个桃子？第5个猴子走后还剩下多少个桃子？
Input:
Output:输出5只猴子至少摘了多少个桃子，第5个猴子走后还剩下多少个桃子。中间用空格隔开。
sample_input:
sample_output:
3121 1020*/
using System;
class pro
{
    static void Main()
    {
        int s5,s4,s3,s2,s1,cnt = 0;
        for (s5 = 16; ; s5 = s5 + 5) //s5初始列举第五只猴子看到的桃子数目
        {
            if (s5 % 4 == 0) { s4 = 5 * s5 / 4 + 1; cnt++; }
            else { cnt = 0; continue; }
            if (s4 % 4 == 0) { s3 = 5 * s4 / 4 + 1; cnt++; }
            else { cnt = 0; continue; }
            if (s3 % 4 == 0) { s2 = 5 * s3 / 4 + 1; cnt++; }
            else { cnt = 0; continue; }
            if (s2 % 4 == 0) { s1 = 5 * s2 / 4 + 1; cnt++; }
            else { cnt = 0; continue; }
            if (cnt == 4) break;
        }
        Console.WriteLine("{0} {1}", s1, (s5 - 1) * 4 / 5);
    }
}
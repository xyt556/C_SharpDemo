using System;
/*
所谓完全数是该数各个真因子之和等于它本身的自然数，又称完美数或完备数（Perfect number）。
例如：第一个完全数是6，它有约数1、2、3、6，除去它本身6外，其余3个数相加，1+2+3=6。
分析：
程序首先计算整数的真因子之和。整数1肯定是因子，不需要判断，直接赋给因子之和sum。计算整数i的真因子之和算法如下。
sum=1;
for(j=2;j<=i/2;j++)
{
    如果j是i的因子，将j加入因子之和sum中
}
然后根据整数i是否等于真因子之和sum来判断i是否是完全数。
 */
namespace cal
{
    class cal
    {
        static void Main(string[] args)
        {
            int i, j, sum;
            for (i = 2; i < 10000; i++)
            {
                sum = 1;
                for (j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;
                }
                if (sum == i)
                {
                    Console.Write("{0} = 1", i);
                    for (j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                            Console.Write("+ {0}", j);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}


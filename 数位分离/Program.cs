/*
Title:数位分离
Description:从键盘输入任意的3位正整数，输出其百位、十位和个位的数字。
Input:输入一个任意的3位正整数
Output:输出其百位、十位和个位的数字，空格隔开。
sample_input:
100
sample_output:
1 0 0
主要考查C#程序语言中数学运算符的使用：
（1）取三位数的个位：除10取余数，即%10；
（2）取三位数的百位：除100取商，即/100；
（3）取三位数的十位：除10的商再对10取余，即/10%10;
或除100的余数再对10取商，即%100/10。
 */
using System;
namespace cal
{
    class Cal
    {
        static void Main()
        {
            int d, a, b, c;
            Console.WriteLine("输入一个任意的3位正整数");
            d = Convert.ToInt32(Console.ReadLine());
            a = d / 100;//取百位
            b = d % 100 / 10; //取十位
            c = d % 10; //取个位
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}
/*
Title: 简易计算器
Description: 输入一个数学表达式，输出运算结果。如输入为3 / 2，则输出1 .50；（运算符号局限于 +、—、*、/ 四种），结果保留2位小数。
Input: 输入数学表达式（合法的数学表达式）
Output: 输出表达式的结果
sample_input:
1 * 2
sample_output:
2*/
/*算式计算考查字符串的拆分应用和选择结构，需用到:
（1）字符串拆分方法，将输入的算式按照运算符为拆分依据进行拆分；
（2）判定运算符的种类，进行相应的运算。*/
using System;
class pro
{
    static void Main()
    {
        double x,y;
        string temp;
        char[] op = { '+', '-', '*', '/' };
        temp = Console.ReadLine();
        string[] st = temp.Split(op);
        x = Convert.ToDouble(st[0]);
        y = Convert.ToDouble(st[1]);
        if (temp.IndexOf('+') >= 0)
            Console.WriteLine("{0:f2}", x + y);
        if (temp.IndexOf('-') >= 0)
            Console.WriteLine("{0:f2}", x - y);
        if (temp.IndexOf('*') >= 0)
            Console.WriteLine("{0:f2}", x * y);
        if (temp.IndexOf('/') >= 0)
            Console.WriteLine("{0:f2}", x / y);
    }
}

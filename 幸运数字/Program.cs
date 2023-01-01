/*Title: 幸运数字8
Description: 将与8有关系的整数称为幸运数。这种关系可以是整数中包含数字8或者该整数是8的倍数。
Input: 输入0～1000的任意整数N
Output: 输出N是否为幸运数的结论，若是输出“yes”，若不是输出“no”
sample_input:
812
sample_output:
yes
幸运数的条件有两个，满足其一即可：
（1）8的倍数：x%8==0；
（2）包含数字8：可以使用拆分数字的方法一位一位查看是否为8；更简单的方法是把该整数转变为字符串，利用字符串函数检索是否包含8字符。*/
using Microsoft.VisualBasic;
using System;
class pro
{
    static void Main()
    {
        int x;
        x = Convert.ToInt32(Console.ReadLine());
        if (x % 8 == 0) Console.WriteLine("yes");
        else
        {
            string t = Convert.ToString(x);
            if (t.IndexOf('8') >= 0)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
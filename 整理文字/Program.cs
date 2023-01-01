/*Title: 整理文字：本题借助循环实现对字符串中字符的单个处理。
Description: 对输入的任意一段文字进行整理：所有的句子开头为大写字母，其他都是小写字母。句子的结束符为“！”、“？”或“.”。
Input: 输入一个句子
Output: 输出调整后的句子
sample_input:
How Are You ?
sample_output:
How are you ?*/

using Microsoft.VisualBasic;
using System;
class pro
{
    static void Main()
    {
        string s;
        int flag = 0;
        s = Console.ReadLine();
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]))
            {
                if (flag == 0) //句首字母,大写输出
                {
                    Console.Write("{0}", char.ToUpper(s[i]));
                    flag = 1;
                }
                else//非句首字母,小写输出
                    Console.Write("{0}", char.ToLower(s[i]));
            }
            else if (s[i] == '!' || s[i] == '?' || s[i] == '.')//一句结束
            {
                Console.Write("{0}", s[i]);
                flag = 0;
            }
            else
                Console.Write("{0}", s[i]);
        }
    }
}


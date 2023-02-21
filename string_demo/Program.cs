using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 读取用户输入
            Console.Write("请输入一个字符串：");
            string input = Console.ReadLine();

            // 输出字符串长度
            Console.WriteLine("字符串长度为：{0}", input.Length);

            // 输出字符串中的每个字符
            Console.WriteLine("字符串中的字符：");
            foreach (char c in input)
            {
                Console.WriteLine(c);
            }

            // 输出字符串中的单词
            Console.WriteLine("字符串中的单词：");
            string[] words = input.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // 将字符串转换为大写
            string upperCase = input.ToUpper();
            Console.WriteLine("转换为大写的字符串：{0}", upperCase);

            // 将字符串转换为小写
            string lowerCase = input.ToLower();
            Console.WriteLine("转换为小写的字符串：{0}", lowerCase);
        }
    }
}

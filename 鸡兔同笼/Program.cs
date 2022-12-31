/*////
//TITLE: 鸡兔同笼
//
//DESCRIPTION: 鸡和兔关在一个笼子里，鸡有2只脚，兔有4只脚。已知现在可以看到笼子里有M个头和N只脚，求鸡和兔子各有多少只？
//
//INPUT: 输入两个正整数M和N
//
//OUTPUT: 依次输出鸡和兔的数量，空格隔开。无解时输出”ERROR”。*/
using System;
namespace program
{
    class pro
    {
        static void Main()
        {
            string t;
            int m, n, x = -1, y = -1;
            t = Console.ReadLine();
            string[] st = t.Split(' ');//借助Split方法将字符串按照空格进行切分
            m = Convert.ToInt32(st[0]);//第一个子串转换后是m的值
            n = Convert.ToInt32(st[1]);//第二个子串转换后是n的值
            if (n % 2 == 0) //鸡和兔的脚总数一定是偶数
            {
                x = 2 * m - n / 2;
                y = n / 2 - m;
            }
            if (x >= 0 && y >= 0)//仅当鸡和兔的数量都不是负数时才是正确的解
                Console.WriteLine("{0} {1}", x, y);
            else
                Console.WriteLine("Error");
        }
    }
}
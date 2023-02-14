using System;

namespace ChickenAndRabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入总数：");
            int total = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入总脚数：");
            int feet = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= total; i++)
            {
                int j = total - i;
                if (i * 2 + j * 4 == feet)
                {
                    Console.WriteLine("鸡数：" + i + "，兔数：" + j);
                }
            }
            Console.ReadLine();
        }
    }
}
/*
 * 在上面的代码中，我们首先从用户输入获取鸡和兔的总数和总脚数，
 * 然后使用循环语句枚举鸡的数量，并计算兔的数量。
 * 最后，我们检查总脚数是否与鸡的脚数和兔的脚数相等，如果是，则输出鸡和兔的数量。
 */
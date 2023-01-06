using System;
class pro
{
    static void Main(string[] args)
    {
        int x;

        Console.WriteLine("请输入一个整数：");
        x = Convert.ToInt16(Console.ReadLine());
        if (x%2==0)
        {
            Console.WriteLine("你输入的数是偶数！");
        }
        else
        {
            Console.WriteLine("你输入的数是奇数！");
        }
    }
}

using System;

class if_1
{
    static void Main(string[] args)
    {
        double x, y;
        Console.WriteLine("请输入x的值: ");
        x = Convert.ToDouble(Console.ReadLine());
        if (x < 0)
        {
            y = x + 1;
            Console.WriteLine("x={0}, y=x+1={1}", x, y);
        }
        else if (x < 1) // 0 ≤x < 1
        {
            y = 1;
            Console.WriteLine("x={0}, y={1}", x, y);
        }
        else// 1 ≤x
        {
            y = x * x * x;
            Console.WriteLine("x={0}, y=x*x*x={1}", x, y);
        }
    }
}

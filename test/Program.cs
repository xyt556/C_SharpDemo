using System;
class Program
{
    static void Main(string[] args)
    {
        double distance; // 行驶距离，单位为公里
        double cost = 0; // 车费，单位为元

        Console.Write("请输入行驶距离（公里）：");
        distance = double.Parse(Console.ReadLine());
        distance=Math.Ceiling(distance);// 向上取整
        if (distance <= 2)
        {
            cost = 7;
        }
        else if (distance <= 15)
        {
            cost = 7 + (distance - 2) * 1.5;
        }
        else
        {
            cost = 7 + 13 * 1.5 + (distance - 15) * 2.1;
        }

        Console.WriteLine("您应该支付的车费为{0:f2}元：" , cost);
        Console.ReadLine();
    }
}
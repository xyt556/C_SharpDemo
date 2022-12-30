using System;
using expressions;
class Area
{
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Please input one integer 1000<n<9999");
    //    uint n = Convert.ToUInt32(Console.ReadLine());
    //    Console.WriteLine("Before inverse the number is: {0}", n);
    //    char c1 = Convert.ToChar(n % 10 + '0'); //分离个位数字
    //    char c2 = Convert.ToChar(n / 10 % 10 + '0'); //分离十位数字
    //    char c3 = Convert.ToChar(n / 100 % 10 + '0'); //分离百位数字
    //    char c4 = Convert.ToChar(n / 1000 + '0'); //分离千位数字
    //    Console.WriteLine("After inverse the number is: {0}{1}{2}{3}",
    //    c1, c2, c3, c4);
    //}
    private static void Main1(string[] args)
    {
        Console.Write("请输入a, b, c = ");
        string inS = Console.ReadLine();
        Console.WriteLine(inS);
        string[] inSS = inS.Split(' ');
        double a = Convert.ToDouble(inSS[0]);
        Console.WriteLine(a);
        double b = Convert.ToDouble(inSS[1]);
        double c = Convert.ToDouble(inSS[2]);
        if (a + b > c && a + c > b && b + c > a)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("area = {0:f3}", area); //保留3位小数
        }
        else
            Console.WriteLine("输入数据错误，不能构成三角形！");
    }
}

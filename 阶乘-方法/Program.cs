using System;
class pro
{
    static float fact(int n)
    {
        if (n == 1) return 1;
        else return n * fact(n - 1);
    }
    static void Main(string[] args)
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0}的阶乘是：{1}", n, fact(n));
    }
}
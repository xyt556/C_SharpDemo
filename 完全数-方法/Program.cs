using System;
class PerfectNum
{
    static bool perfect(int n)  // 定义方法
    {
        int sum = 0;
        for (int i = 1; i < n; i++)//计算n的所有真因子之和
            if (n % i == 0) sum = sum + i;
        if (sum == n)//判断是否完数
            return true;
        else
            return false;
    }
    static void Main()
    {
        int n;
        Console.WriteLine("请输入要判别的数：");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0}是完全数吗？{1}", n, perfect(n)); //引用方法
    }
}

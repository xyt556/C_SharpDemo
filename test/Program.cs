//测试
class MyClass
{
    static void Main(string[] args)
    {
        String str = "大家" + '\u0022' + "好" + '\'';

        Console.WriteLine(str);
        int x;
        double y;
        x = 10; y = 2.3;
        Console.WriteLine("结果是：{0:f3}",Convert.ToDouble(x/y));
        Console.ReadLine();
    }
}

/*大家 "好'*/
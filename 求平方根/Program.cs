using System;//引入命名空间System
class SQRT//类定义
{
    static void Main()//Main方法
    {
        double d;
        d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("{0:f3}", Math.Sqrt(d));//输出
    }
}

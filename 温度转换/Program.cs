using System;//引入命名空间System
/*

 */
class temp//类定义
{
    static void Main()//Main方法
    {
        double f, c;
        Console.WriteLine("请输入华氏温度：");
        f = Convert.ToDouble(Console.ReadLine());
        c = 5 * (f - 32) / 9.0;
        Console.WriteLine("摄氏温度是{0:f2}°C", c);
    }
}
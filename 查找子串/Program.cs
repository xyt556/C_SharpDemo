using System;//引入命名空间System
class STRING//类定义
{
    static void Main()//Main方法
    {
        String s1, s2;
        s1 = Console.ReadLine();
        s2 = Console.ReadLine();
        Console.WriteLine("{0}", s1.IndexOf(s2) + 1);//输出
    }
}
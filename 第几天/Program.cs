using System;//引入命名空间System
class DayOfYear//类定义
{
    static void Main()//Main方法
 {
        DateTime d;//定义存储用户将要输入日期的变量
        d = Convert.ToDateTime(Console.ReadLine());//输入日期
        Console.WriteLine("{0}", d.DayOfYear);//输出
    }
}
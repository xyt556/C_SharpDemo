using System;//引入命名空间System
/*
 * 本题主要考查
C#程序语言中的简单选择结构：
对用户所购买的鸡蛋重量进行判断，得出不同的应付金额；
（1）小于3公斤，金额=鸡蛋重量*7.60；
（2）等于或大于3公斤，金额=鸡蛋重量*7.60*0.8；
 */
class STRING//类定义
{
    static void Main()//Main方法
    {
        double w, m;
        Console.WriteLine("请输入购买鸡蛋的公斤数：");
        w = Convert.ToDouble(Console.ReadLine());
        m = w >= 3 ? w * 7.60 * 0.8 : w * 7.60;
        Console.WriteLine("一共需要{0:f2}元", m);//输出
    }
}
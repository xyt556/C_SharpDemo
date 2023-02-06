public class privateTest
{
    private privateTest()//私有构造函数
    {
        Console.WriteLine("private");
    }
    public privateTest(string a) //公有构造函数
    {
        Console.WriteLine("public：{0}", a);
    }
}
class Program
{
    static void Main(string[] args)
    {
        //privateTest f1 = new privateTest();//不能实例化
        privateTest f2 = new privateTest("ww");//调用公有构造函数实例化
    }
}
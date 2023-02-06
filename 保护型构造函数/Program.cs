public class protectTest
{
    protected protectTest()
    {
        Console.WriteLine("protect");
    }
    public protectTest(string a)
    {
        Console.WriteLine("public：{0}",a);
    }
}
class Program
{
    static void Main(string[] args)
    {
        //protectTest f = new protectTest();//不能实例化
        protectTest f1 = new protectTest("ww");//调用公有构造函数实例化
    }
}
class Conversions
{
    static double gmPerPound = 454;
    //英镑转换为克
    public static double poundsToMetric(double pounds)
    {
        return (pounds * gmPerPound);
    }
    private Conversions() { }//私有构造函数
}
class Program
{
    static void Main(string[] args)
    {
        //Conversions pTom = new Conversions();//错误，不能被实例化
        double pound;
        System.Console.Write("输入英制 pound:");
        pound = double.Parse(Console.ReadLine());
        Console.WriteLine("转换结果\r\n{0}磅={1}克", pound, Conversions.poundsToMetric(pound)); //调用类的静态方法
    }
}
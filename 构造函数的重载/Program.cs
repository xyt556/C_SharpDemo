class Circle
{
    private double _radius;//圆的半径
    public Circle() //构造函数
    { _radius = 10; }
    public Circle(double Radius)//带参数的构造函数
    { _radius = Radius; }
}

class Programe
{
    static void Main(string[] args)
    {
        Circle c1 = new Circle(); //出错，没有无参的构造函数
        Circle c2 = new Circle(2);
    }
}
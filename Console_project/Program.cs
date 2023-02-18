using System;
namespace Circle_computer
{
    class Circle
    {
        private double radius; //半径
        public void setradius(double r) //设置半径
        {
            radius = r;
        }
        public double area() //计算圆面积
        {
            return Math.PI * radius * radius;
        }
        public double length() //计算圆周长
        {
            return 2 * Math.PI * radius;
        }
        public double getradius() //获取半径
        {
            return radius;
        }
    }

    class Program
    {
        public static void Main(string[] Agrs)
        {
            Circle y = new Circle(); //创建实例y
            Console.WriteLine("请输入圆的半径：");
            // string s = Console.ReadLine();
            double r = Convert.ToDouble(Console.ReadLine());
            y.setradius(r); //设置半径为5.0
            Console.WriteLine("半径:{0} ", y.getradius());
            Console.WriteLine("面积:{0} ", y.area());
            Console.WriteLine("周长:{0} ", y.length());
        }
    }
}
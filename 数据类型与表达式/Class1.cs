using expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using expressions;
class progress
    {
    public static void Main(string[] Agrs)
    {
        // 计算圆的面积和周长
        Circle y = new Circle(); //创建实例y
        Console.WriteLine("请输入圆的半径：");
        // string s = Console.ReadLine();
        double r = Convert.ToDouble(Console.ReadLine());
        y.setradius(r); //设置半径为5.0
        Console.WriteLine("半径:{0} ", y.getradius());
        Console.WriteLine("面积:{0} ", y.area());
        Console.WriteLine("周长:{0} ", y.length());
        // 计算三角形的面积和周长
        Tri_Area t = new Tri_Area();
        Console.Write("请输入（以英文逗号分割）a, b, c = ");
        string inS = Console.ReadLine();
        string[] inSS = inS.Split(',');
        double a = Convert.ToDouble(inSS[0]);
        double b = Convert.ToDouble(inSS[1]);
        double c = Convert.ToDouble(inSS[2]);
        //t.cal_area(a, b, c);
        t.cal_area(a, b, c);
        Inverse i = new Inverse();
        Console.WriteLine("Please input one integer 1000<n<9999");
        uint n = Convert.ToUInt32(Console.ReadLine());
        i.inverse_data(n);
        // 字母大写转小写
        Utol cha = new Utol();
        Console.Write("请输入一个字母: ");
        char ch = Convert.ToChar(Console.Read());
        cha.voidutol(ch);
        // 判断一个数是否是回文数
        Check chec = new Check();
        Console.Write("请输入一个四位的整数：");
        int data = Convert.ToInt32(Console.ReadLine());
        chec.check(data);


    }
}



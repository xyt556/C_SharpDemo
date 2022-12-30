using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expressions
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

    class Tri_Area
    {
        private double a, b, c;
        public void cal_area(double a, double b, double c)//计算三角形的面积、周长
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                double t_lenth = a + b + c;
                Console.WriteLine("lenth = {0:f3}", t_lenth);
                Console.WriteLine("area = {0:f3}", area);
            }
            else
            {
                Console.WriteLine("输入错误，不能构成三角形！");
            }
        }


    }

    class Inverse
    {
        private uint x;
        public void inverse_data(uint x)
        {
            Console.WriteLine("Before inverse the number is: {0}", x);
            char c1 = Convert.ToChar(x % 10 + '0'); //分离个位数字
            char c2 = Convert.ToChar(x / 10 % 10 + '0'); //分离十位数字
            char c3 = Convert.ToChar(x / 100 % 10 + '0'); //分离百位数字
            char c4 = Convert.ToChar(x / 1000 + '0'); //分离千位数字
            Console.WriteLine("After inverse the number is: {0}{1}{2}{3}",
            c1, c2, c3, c4);
        }
    }

    class Utol
    {
        private char ch;
        public void voidutol(char ch)
        {
            
            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch - 'A' + 'a');
                Console.WriteLine("将大写转换为小写后，该字母为：{0}", ch);
            }
            else
            {
                Console.WriteLine("您输入的不是大写字母，无法转换");
            }
                
            
        }
        
    }
    class Check
    {
        private int n;
        public void check(int n)
        {
            
            //d1,d2,d3,d4分别用来表示各位数字
            int d1 = n / 1000;// 千位
            int d2 = n / 100 % 10;// 百位
            int d3 = n / 10 % 10;// 十位
            int d4 = n % 10;// 个位
            if (d1 == d4 && d2 == d3)
                Console.WriteLine("该数是回文数");
            else
                Console.WriteLine("该数不是回文数");
        }
    }
}

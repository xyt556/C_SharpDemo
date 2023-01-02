/*
Title: 发馒头
Description: 幼儿园吃中午饭，老师一人吃4个馒头，学生4个人吃一个馒头，老师和学生共有100个人，吃了100个馒头，请问老师和学生各有多少人。
Input:无输入
Output:输出老师和学生的人数
sample_input:
sample_output:
Teacher:20
Children:80
本题是借助循环结构，使用枚举的办法求解方程：
设教师
x人，学生y人，则有:
x+y=100
4x+y/4=100*/
using System;
class pro
{
    static void Main()
    {
        Console.WriteLine("方法1：");
        int x, y;
        for (x = 0; x <= 100; x++)
            for (y = 0; y <= 100; y++)
                if (x + y == 100 && 4 * x + y / 4 == 100 && y % 4 == 0)
                {
                    Console.WriteLine("Teacher:{0}\nChildren: {1}", x, y);
                    break;
                }
        Console.WriteLine("方法2：");
        for (x = 0; x <= 100; x++)
        {
            y = 100 - x;
            if (4 * x + y / 4 == 100 && y % 4 == 0)
            {
                Console.WriteLine("Teacher:{0}\nChildren: {1}", x, y);
                break;
            }
        }
    }
}
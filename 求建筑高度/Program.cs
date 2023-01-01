/*Title:求建筑高度
Description:有4个圆塔，圆心分别为(2,2)、(-2,2)、(2,-2)、(-
2,-2)，圆半径为1。这4个塔的高度为10m。塔以外无建筑物。
请编写程序，输入任一点的坐标，求该点的建筑高度(塔外的
高度为零)。
Input:输入某一点的横坐标和纵坐标
Output:输出该点的建筑高度。
sample_input:
2
2.5
sample_output:
10
主要应用两点之间的距离的计算方法和选择结构*/
using System;
class pro
{
    static void Main()
    {
        double d1, d2, d3, d4;
        double x, y;
        x = Convert.ToDouble(Console.ReadLine());
        y = Convert.ToDouble(Console.ReadLine());
        d1 = Math.Sqrt((x - 2) * (x - 2) + (y - 2) * (y - 2));
        d2 = Math.Sqrt((x + 2) * (x + 2) + (y - 2) * (y - 2));
        d3 = Math.Sqrt((x - 2) * (x - 2) + (y + 2) * (y + 2));
        d4 = Math.Sqrt((x + 2) * (x + 2) + (y + 2) * (y + 2));
        if (d1 <= 1 || d2 <= 1 || d3 <= 1 || d4 <= 1)
            Console.WriteLine("10");
        else
            Console.WriteLine("0");
    }
}
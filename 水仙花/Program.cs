/*Title: 水仙花数
Description: 如果一个3位整数的各个数位上数字的立方之和
等于该3位整数，则称其为水仙花数。输入一个3位整数N判断
是否为水仙花数，是的话输出“yes”，否则输出“no”。
Input:输入一个3位整数
Output: 输出为字符串
sample_input:
123
sample_output:
no
Title:水仙花数
Description:如果一个3位整数的各个数位上数字的立方之和
等于该3位整数，则称其为水仙花数。输入一个3位整数N判断
是否为水仙花数，是的话输出“yes”，否则输出“no”。
Input:输入一个3位整数
Output:输出为字符串
sample_input:
123
sample_output:
no*/
using System;
class pro
{
    static void Main()
    {
        int a;
        a = Convert.ToInt32(Console.ReadLine());
        int x, y, z;
        x = a / 100;
        y = a / 10 % 10;
        z = a % 10;
        if (x * x * x + y * y * y + z * z * z == a)
            Console.WriteLine("yes");
        else
            Console.WriteLine("no");
    }
}
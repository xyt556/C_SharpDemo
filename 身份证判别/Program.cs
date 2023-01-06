/*身份证判别性别
*/
using System;
class pro
{
    static void Main(string[] args)
    {
        Console.WriteLine("请输入有效身份证号码：");
        string s;
        int x;

        do
        {
            s = Console.ReadLine();
            {
                Console.WriteLine("输入正确，进入性别判别！");
                break;
            }
            Console.WriteLine("你输入的身份证号码无效，请重新输入。");
        } while (s.Length != 18);
        x = int.Parse(s.Substring(16, 1));
        Console.WriteLine("第17位是：{0}", x);

        if (x % 2 == 0)
        {
            Console.WriteLine("此人为女性！");
        }
        else
        {
            Console.WriteLine("此人为男性！");
        }
    }
}
using System;
namespace cal
{
    class Cal
    {
        static void Main(string[] args)
        {
            int old_grade;
            string new_grade;
            Console.Write("请输入学生成绩：");
            old_grade = Convert.ToInt32(Console.ReadLine());
            switch (old_grade / 10)
            {
                case 10:
                case 9:
                    new_grade = "优秀"; break;
                case 8:
                    new_grade = "良好"; break;
                case 7:
                    new_grade = "中等"; break;
                case 6:
                    new_grade = "及格"; break;
                default:
                    new_grade = "不及格"; break;
            }
            Console.WriteLine("转换前成绩是{0},转换后成绩是{1}", old_grade, new_grade);
        }

    }
}


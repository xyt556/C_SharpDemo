using System;
using System.Collections.Generic;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace scoreAnalysis
{
    class pro
    {
        static void Main(string[] args)
        {
            //定义全班人数，控制接收成绩的次数
            int students;
            //定义临时变量，接收每次输入的成绩
            int tmp_score;
            //最大成绩与最小成绩
            int max_score = 0, min_score = 0;
            // 统计各区间内的成绩人数
            int score_0_30 = 0, score_31_59 = 0, score_60_79 = 0, score_80_89 = 0, score_90_100 = 0;
            //接收全班人数
            Console.Write("请葡入班级人数：students= ");
            students = Int32.Parse(Console.ReadLine());
            //接收并处理成绩
            for (int i = 0; i < students; i++)
            {
                Console.WriteLine("请输入第{0}个成绩：", i);
                tmp_score = Int32.Parse(Console.ReadLine());
                //修改最大与最小成绩
                if (i == 1)
                {
                    min_score = tmp_score;
                    max_score = tmp_score;
                }
                else
                {
                    if (max_score < tmp_score)
                        max_score = tmp_score;
                    if (min_score > tmp_score)
                        min_score = tmp_score;
                }
                //统计成绩所在区间的总人数
                if (tmp_score >= 0 && tmp_score <= 30)
                {
                    score_0_30++;
                }
                if (tmp_score >= 31 && tmp_score <= 59)
                {
                    score_31_59++;
                }
                if (tmp_score >= 60 && tmp_score <= 79)
                {
                    score_60_79++;
                }
                if (tmp_score >= 80 && tmp_score <= 89)
                {
                    score_80_89++;
                }
                if (tmp_score >= 90 && tmp_score <= 100)
                {
                    score_90_100++;
                }
            }
            //统计信息输出
            Console.WriteLine("共{0:d}人，其中最大成绩{1:d}，最小成绩{2:d}", students, max_score, min_score);
            Console.WriteLine("成绩区间0-30的总人数{0:d}，占比为{1:f2}%", score_0_30, score_0_30 * 100.0 / students);
            Console.WriteLine("成绩区间31-59的总人数{0:d}，占比为{1:f2}%", score_31_59, score_31_59 * 100.0 / students);
            Console.WriteLine("成绩区间60-79的总人数{0:d}，占比为{1:f2}%", score_60_79, score_60_79 * 100.0 / students);
            Console.WriteLine("成绩区间80-89的总人数{0:d}，占比为{1:f2}%", score_80_89, score_80_89 * 100.0 / students);
            Console.WriteLine("成绩区间90-100的总人数{0:d}，占比为{1:f2}%", score_90_100, score_90_100 * 100.0 / students);
        }
    }
}

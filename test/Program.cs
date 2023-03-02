using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] scores = new int[3][];
        scores[0] = new int[] { 75, 80, 90 };
        scores[1] = new int[] { 85, 95 };
        scores[2] = new int[] { 65, 70, 75, 80 };

        Console.WriteLine("学生的成绩是：");
        for (int i = 0; i < scores.Length; i++)
        {
            Console.Write("第{0}个学生的成绩是：", i + 1);
            for (int j = 0; j < scores[i].Length; j++)
            {
                Console.Write("{0} ", scores[i][j]);
            }
            Console.WriteLine();
        }

        double[] avgScores = new double[scores.Length];
        double totalAvgScore = 0.0;
        for (int i = 0; i < scores.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < scores[i].Length; j++)
            {
                sum += scores[i][j];
            }
            avgScores[i] = (double)sum / scores[i].Length;
            totalAvgScore += avgScores[i];
        }

        Console.WriteLine("每个学生的平均分是：");
        for (int i = 0; i < avgScores.Length; i++)
        {
            Console.WriteLine("第{0}个学生的平均分是：{1:F2}", i + 1, avgScores[i]);
        }

        Console.WriteLine("所有学生的平均分是：{0:F2}", totalAvgScore / avgScores.Length);
    }
}

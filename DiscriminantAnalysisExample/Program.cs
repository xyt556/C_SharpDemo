using System;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Filters;

namespace WaterQuality
{
    class Program
    {
        static void Main(string[] args)
        {
            // 输入数据集
            double[][] inputs =
            {
                new double[] {7.0, 5.5, 2.0, 8.0, 200.0},
                new double[] {7.1, 6.0, 2.5, 9.0, 220.0},
                new double[] {6.0, 5.0, 2.2, 7.5, 180.0},
                new double[] {6.5, 5.8, 2.3, 8.0, 190.0},
                new double[] {7.2, 5.5, 2.1, 8.5, 205.0},
                new double[] {6.8, 5.5, 2.4, 7.5, 200.0},
                new double[] {7.5, 6.0, 2.5, 8.0, 230.0},
                new double[] {6.9, 5.5, 2.6, 8.0, 220.0},
                new double[] {7.3, 6.2, 2.0, 8.5, 210.0},
                new double[] {7.1, 5.5, 2.2, 8.0, 200.0},
                new double[] {7.2, 5.7, 2.3, 7.5, 210.0},
                new double[] {6.7, 5.5, 2.4, 8.5, 180.0},
            };

            // 输出数据集
            int[] outputs =
            {
                1, 1, 0, 1, 1, 0, 1, 1, 1, 0, 0, 0
            };

            // 将数据集分为训练集和测试集
            var teacher = new C45Learning();
            var tree = teacher.Learn(inputs, outputs);

            var inputsTest = new double[][]
            {
                new double[] {7.4, 5.5, 2.0, 8.0, 200.0},
                new double[] {6.5, 5.5, 2.5, 8.0, 180.0},
                new double[] {7.2, 5.5, 2.3, 7.5, 205.0},
            };
            var expected = new int[] { 1, 0, 1 };

            // 预测
            int[] predicted = tree.Decide(inputsTest);

            // 显示预测结果
            for (int i = 0; i < predicted.Length; i++)
            {
                Console.Write("预测结果：" + predicted[i]);
                if (expected[i] == predicted[i])
                {
                    Console.WriteLine("\t预测正确！");
                }
                else
                {
                    Console.WriteLine("\t预测不正确！");
                }
            }
            

            Console.ReadLine();
        }
    }
}

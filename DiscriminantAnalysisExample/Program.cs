using System;
using System.Linq;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels;

namespace DiscriminantAnalysisExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 数据集，这里以二维数据为例
            double[][] inputs =
            {
                new double[] { -5, -2 },
                new double[] { -5, -5 },
                new double[] {  2,  1 },
                new double[] {  1,  1 },
                new double[] {  1,  2 },
                new double[] {  3,  4 },
            };

            int[] outputs =
            {
                -1, -1, 1, 1, 1, 1
            };

            // 实例化支持向量机
            var teacher = new SequentialMinimalOptimization<Gaussian>()
            {
                Complexity = 100
            };

            // 训练判别模型
            var svm = teacher.Learn(inputs, outputs);

            // 预测新样本的类别
            double[][] pre =
            {
                new double[] {5.0,2.0},
                new double[] {-3.0,-1.0}
            };

            bool[] results = svm.Decide(pre);//返回值是bool类型
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine("预测结果：" + results[i]);
            }
            

            Console.ReadLine();
        }
    }
}

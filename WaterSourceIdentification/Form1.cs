using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Accord.MachineLearning;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels;
namespace WaterSourceIdentification
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "CSV文件|*.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = dialog.FileName;
            }
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text))
            {
                MessageBox.Show("请选择数据文件");
                return;
            }

            var data = File.ReadAllLines(txtFilePath.Text)
                .Skip(1)
                .Select(line => line.Split(',').Select(double.Parse).ToArray())
                .ToArray();

            if (data.Length == 0)
            {
                MessageBox.Show("数据文件为空");
                return;
            }
            var linearKernel = new Accord.Statistics.Kernels.Linear();
            var svm = new Accord.MachineLearning.VectorMachines.SupportVectorMachine<Accord.Statistics.Kernels.Linear>(2, linearKernel);

            var inputs = data.Select(d => d.Take(2).ToArray()).ToArray();
            var outputs = data.Select(d => d[2]).ToArray();

            var teacher = new Accord.MachineLearning.VectorMachines.Learning.SequentialMinimalOptimization<Accord.Statistics.Kernels.Linear>()
            {
                Complexity = 1.0
            };

            svm = teacher.Learn(inputs, outputs);

            var water = new double[] { double.Parse(txtPH.Text), double.Parse(txtTurbidity.Text) };
            var result = svm.Decide(water);

            if (result == 1)
            {
                lblResult.Text = "水质优";
            }
            else
            {
                lblResult.Text = "水质劣";
            }
        }
    }
}

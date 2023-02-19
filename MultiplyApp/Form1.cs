using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(num1TextBox.Text);
                double num2 = double.Parse(num2TextBox.Text);
                double result = num1 * num2;
                MessageBox.Show($"结果是 {result}！", "计算结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resultTextBox.Text=result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入有效的数值！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

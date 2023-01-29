using System.Drawing;

namespace 存款计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //变量声明
            double corpus_amount, interest_rate, interest_amount, income_amount;
            int deposit_years;
            string str;
            //提取输入界面中的本金与存款期限
            try
            {
                corpus_amount = double.Parse(corpus_textBox.Text);
                deposit_years = Int32.Parse(years_textBox.Text);
                interest_rate = double.Parse(interest_textBox.Text);
            }
            catch
            {
                MessageBox.Show("输入内容非数字！");
                return;
            }
            //计算本金与利息和
            income_amount = corpus_amount * Math.Pow((1 + interest_rate), deposit_years);
            //计算获取的利息
            interest_amount = income_amount - corpus_amount;
            //格式化欲输出信息
            str = string.Format("{0,3:d1},{1,10:c}{3,15:c}", deposit_years, corpus_amount, interest_amount, income_amount);
            //输出所需信息
            result_listBox.Items.Add(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
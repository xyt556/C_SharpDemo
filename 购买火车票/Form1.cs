namespace 购买火车票
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month;
            int num;
            double price;
            double sumprice;
            double rate1, rate2;
            rate1 = 1;
            rate2 = 1;
            month = Convert.ToInt16(textMonth.Text);
            num = Convert.ToInt16(textPerson.Text);
            price = Convert.ToDouble(textPrice.Text);
            if (radioYes.Checked == true)
            {
                if ((month >= 1 && month <= 3) || (month >= 7 && month <= 9))
                {
                    rate1 = 0.5;
                    if (num >= 10)
                    {
                        rate2 = 0.9;
                    }
                }
                else
                {
                    rate1 = 1;
                    rate2 = 1;

                }
            }
           
            sumprice=price*num*rate1*rate2;
            textSum.Text = sumprice.ToString();
        }

        private void textMonth_TextChanged(object sender, EventArgs e)
        {
            /*if (textMonth.Text == "")
                textMonth.Text = 0.ToString();*/
            int number = int.Parse(textMonth.Text);
            textMonth.Text = number.ToString();
            if (number <= 12 && number>=1)
            {
                return;
            }
            else
            {
                MessageBox.Show("输入月份无效，请重新输入！");
            }
            textMonth.Text = textMonth.Text.Remove(2);
            textMonth.SelectionStart = textMonth.Text.Length;
        }

        // 限制只能输入数值
        private void textMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }
    }
}
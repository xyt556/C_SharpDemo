using Gcd;
using System;

namespace 最大公约数最大公倍数_窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m, n,s;
            m = Convert.ToInt32(this.textBox1.Text);
            n = Convert.ToInt32(this.textBox2.Text);
            Pro gc = new Pro();
            s = gc.gcd(m, n);
            this.textBox3.Text = Convert.ToString(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int m, n, s;
            m = Convert.ToInt32(this.textBox1.Text);
            n = Convert.ToInt32(this.textBox2.Text);
            Pro gc = new Pro();
            s = gc.lcm(m, n);
            this.textBox4.Text = Convert.ToString(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int m, n, s;
            m = Convert.ToInt32(this.textBox1.Text);
            n = Convert.ToInt32(this.textBox2.Text);
            Pro gc = new Pro();
            this.textBox3.Text = Convert.ToString(gc.gcd(m, n));
            this.textBox4.Text = Convert.ToString(gc.lcm(m, n));
            
        }
    }
}
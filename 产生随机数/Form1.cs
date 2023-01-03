namespace 产生随机数
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.textBox1.Text = rnd.Next().ToString();
        }
    }
}
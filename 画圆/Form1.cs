namespace 画圆
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r;
            r = Convert.ToInt32(textBox1.Text);//取半径值
            Graphics gra = this.CreateGraphics();
            gra.Clear(this.BackColor);//清除
            Brush bush = new SolidBrush(Color.Blue);
            Pen pen = new Pen(colorDialog1.Color);//画笔颜色    
            //设置圆的填充色为蓝色
            gra.FillEllipse(bush, 0, 0, 2 * r, 2 * r);//画圆（//画填充椭圆的方法，x坐标、y坐标、宽、高，如果是100，则半径为50）
            gra.DrawEllipse(pen, 0, 0, 2 * r, 2 * r);
            //gra.DrawEllipse(pen, 250, 10, 100, 100);//画椭圆的方法，x坐标、y坐标、宽、高，如果是100，则半径为50
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gra = this.pictureBox1.CreateGraphics();
            gra.Clear(this.pictureBox1.BackColor);
            Font myFont = new Font("宋体", 20, FontStyle.Bold);
            Brush bush = new SolidBrush(colorDialog1.Color);//填充的颜色
            gra.DrawString("欢迎！", textBox1.Font, bush, 0, 0);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            {
                //显示颜色对话框
                DialogResult dr = colorDialog1.ShowDialog();
                DialogResult df = fontDialog1.ShowDialog();
                //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
                if (dr == DialogResult.OK)
                {
                    textBox1.ForeColor = colorDialog1.Color;
                    textBox1.Font = fontDialog1.Font;
                }
                if (df== DialogResult.OK)
                {
                    textBox1.Font = fontDialog1.Font;
                }
            }
        }
    }
}
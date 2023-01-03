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
            Brush bush = new SolidBrush(Color.Blue);
            Pen pen = new Pen(Color.Pink);//画笔颜色    
            //设置圆的填充色为蓝色
            gra.FillEllipse(bush, 0, 0, 2 * r, 2 * r);//画圆（//画填充椭圆的方法，x坐标、y坐标、宽、高，如果是100，则半径为50）
            gra.DrawEllipse(pen, 0, 0, 2 * r, 2 * r);
            gra.DrawEllipse(pen, 250, 10, 100, 100);//画椭圆的方法，x坐标、y坐标、宽、高，如果是100，则半径为50
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gra = this.CreateGraphics();
            Font myFont = new Font("宋体", 60, FontStyle.Bold);
            Brush bush = new SolidBrush(Color.Red);//填充的颜色
            gra.DrawString("欢迎！", myFont, bush, 300, 300);
        }
    }
}
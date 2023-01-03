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
        }
    }
}
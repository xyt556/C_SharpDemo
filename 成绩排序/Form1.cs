//包含排序算法。
namespace 成绩排序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;        //接收待排序的输入数据
            int[] int_Array;   //存储以前输入的排好序的数据
            int i;  //临时变量
            //分别存储折半查找时的找到的位置、起点、终点和中间点
            int foundPosition = 0, StartPosition = 0, endPositon = 0,midPosition=0;
            bool found;  //存储是否找到需要查找的数据，0表示未找到，1表示找到
            str = textBox1.Text.Trim();//接收戴插入排序的输入数据（去除空格）
            if (str.Length == 0)
            {
                MessageBox.Show("请输入戴处理的数据！");
                return;
            }
            //判断待处理的数据是否为数值
            for (i = 0; i < str.Length; i++)
            {
                if (!char.IsNumber(str[i]))
                {
                    MessageBox.Show("待处理的数据中有非数值存在！");
                    return;
                }
            }
            //数组实例化
            int_Array= new int[listBox1.Items.Count];
            //将以前输入并排序好的数据转到数组中
            for (i = 0; i < listBox1.Items.Count; i++)
            {
                int_Array[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            //折半查找法定位数据应该在数组中的位置
            if (listBox1.Items.Count == 0)
            {
                foundPosition = 0;//第一次插入数据时，不需寻找，直接插入到第一个位置
            }
            else
            {
                StartPosition = 0;
                endPositon = int_Array.Length - 1;
                found= false;
                //循环查找数组中是否有要插入的数据
                while (!found && StartPosition<=endPositon)
                {
                    midPosition = (StartPosition + endPositon) / 2;//取中间值
                    if (int_Array[midPosition].Equals(Int32.Parse(str)))
                    {
                        found = true;
                        foundPosition= midPosition;
                    }
                    else
                    {
                        if (Int32.Parse(str).CompareTo(int_Array[midPosition])<0)
                        {
                            endPositon = midPosition - 1;
                        }
                        //要插入的数据只能在左边
                        else
                        {
                            StartPosition= midPosition+1;
                        }
                        //要插入的数据只能在右边
                    }
                    //未找到，则修改返回点
                    if (!found)
                    {
                        foundPosition = StartPosition;
                    }
                }
            }
            listBox1.Items.Insert(foundPosition, Int32.Parse(str));
        }
    }
}
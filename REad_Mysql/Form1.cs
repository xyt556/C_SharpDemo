using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ReadMySQL
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public Form1()
        {
            //InitializeComponent();

            // 初始化连接
            string connectionString = "server=localhost;user id=root;password=123456;database=test;";
            connection = new MySqlConnection(connectionString);

            // 初始化数据适配器
            dataAdapter = new MySqlDataAdapter();

            // 初始化数据表
            dataTable = new DataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 打开连接
            connection.Open();

            // 获取表名列表
            DataTable table = connection.GetSchema("Tables");
            foreach (DataRow row in table.Rows)
            {
                string tableName = row["TABLE_NAME"].ToString();
                listBox1.Items.Add(tableName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = listBox1.SelectedItem.ToString();

            // 获取数据
            MySqlCommand command = new MySqlCommand($"SELECT * FROM `{tableName}`", connection);
            dataAdapter.SelectCommand = command;
            dataTable.Clear();
            dataAdapter.Fill(dataTable);

            // 显示数据
            dataGridView1.DataSource = dataTable;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 关闭连接
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

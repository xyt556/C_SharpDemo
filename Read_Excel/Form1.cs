using System;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
//using OfficeOpenXml.Core.ExcelPackage;
using ExcelPackage = OfficeOpenXml.ExcelPackage;
using System.Data;

namespace Read_Excel
{
    public partial class Form1 : Form
    {
        public string fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                    txtFilePath.Text = fileName;
                    LoadExcelData(fileName);
                }
            }
        }
        private void LoadExcelData(string fileName)
        {
            FileInfo file = new FileInfo(fileName);
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                int totalColumns = worksheet.Dimension.End.Column;
                for (int col = 1; col <= totalColumns; col++)
                {
                    string header = worksheet.Cells[1, col].Value?.ToString();
                    if (!string.IsNullOrEmpty(header))
                    {
                        listBox1.Items.Add(header);
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var package = new ExcelPackage(new FileInfo(fileName)))
            {
                // 获取第一个工作表
                var worksheet = package.Workbook.Worksheets[1];

                // 获取表格的范围
                var range = worksheet.Dimension;

                // 创建一个DataTable对象
                var dataTable = new DataTable();

                // 读取表头
                for (int col = 1; col <= range.Columns; col++)
                {
                    dataTable.Columns.Add(worksheet.Cells[1, col].Value.ToString());
                }

                // 读取数据
                for (int row = 2; row <= range.Rows; row++)
                {
                    var dataRow = dataTable.NewRow();
                    for (int col = 1; col <= range.Columns; col++)
                    {
                        dataRow[col - 1] = worksheet.Cells[row, col].Value;
                    }
                    dataTable.Rows.Add(dataRow);
                }

                // 将DataTable绑定到dataGridView
                dataGridView.DataSource = dataTable;
            }
        }
    }
}
using System;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
//using OfficeOpenXml.Core.ExcelPackage;
using ExcelPackage = OfficeOpenXml.ExcelPackage;
namespace Read_Excel
{
    public partial class Form1 : Form
    {
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
                    string fileName = openFileDialog.FileName;
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
    }
}
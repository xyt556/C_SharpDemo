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
        string[] file1;
        string path;
        public Form1()
        {
            InitializeComponent();
        }
        private int CountFiles(string path, string extension)
        {
            int count = 0;

            // 统计当前目录下的文件数量
            count += Directory.GetFiles(path, $"*{extension}").Length;

            // 遍历子目录
            foreach (string subDir in Directory.GetDirectories(path))
            {
                // 递归调用 CountFiles 函数
                count += CountFiles(subDir, extension);
            }

            return count;
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

        private void button2_Click(object sender, EventArgs e)
        {
            long totalSize = 0; // 总文件大小


            // 使用FolderBrowserDialog打开目录选择对话框
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // 清空TreeView
                    treeView1.Nodes.Clear();
                    path = folderDialog.SelectedPath;
                    // 获取所选目录下的子目录和文件
                    var subDirs = Directory.GetDirectories(folderDialog.SelectedPath);
                    var files = Directory.GetFiles(folderDialog.SelectedPath);
                    file1 = files;
                    int txtFileCount = Directory.GetFiles(folderDialog.SelectedPath, "*.pdf").Length;
                    textBox2.Text = txtFileCount.ToString();
                    // 创建根节点
                    var rootNode = new TreeNode(folderDialog.SelectedPath);
                    rootNode.Tag = folderDialog.SelectedPath;

                    // 将子目录添加为根节点的子节点
                    foreach (var subDir in subDirs)
                    {
                        var subNode = new TreeNode(Path.GetFileName(subDir));
                        subNode.Tag = subDir;
                        rootNode.Nodes.Add(subNode);
                    }

                    // 将文件添加为根节点的子节点
                    foreach (var file in files)
                    {
                        var fileNode = new TreeNode(Path.GetFileName(file));
                        fileNode.Tag = file;
                        rootNode.Nodes.Add(fileNode);
                    }

                    // 将根节点添加到TreeView中
                    treeView1.Nodes.Add(rootNode);
                }
            }
            try
            {
                // 获取目录中的所有文件
                //string[] files = Directory.GetFiles(subDirs, "*", SearchOption.AllDirectories);

                // 遍历文件，计算总文件大小
                foreach (string file in file1)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    totalSize += fileInfo.Length;
                }

                // 输出结果
                //Console.WriteLine($"目录 {path} 下的文件总大小为 {totalSize} 字节");
                int count = CountFiles(path, ".pdf");

                // 在文本框中显示结果
                textBox2.Text = $"目录 {path} 及其子目录下共有 {count} 个 pdf 文件。";
                textBox1.Text = (totalSize/1024.0).ToString()+"M";
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
using System;
using System.IO;
using OfficeOpenXml;

namespace ReadExcelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\test\data.xlsx";

            // 打开 Excel 文件
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                foreach (var wt in package.Workbook.Worksheets)
                {
                    Console.WriteLine(wt.Name);
                }
                // 读取第一个 sheet
                var worksheet = package.Workbook.Worksheets[1];//注意：从1开始

                // 获取行数和列数
                int rows = worksheet.Dimension.Rows;
                int columns = worksheet.Dimension.Columns;

                // 读取每一行存到一个数组中
                for (int row = 2; row <= rows; row++)
                {
                    string[] data = new string[columns];
                    for (int col = 1; col <= columns; col++)
                    {
                        data[col - 1] = worksheet.Cells[row, col].Value.ToString();
                    }
                    Console.WriteLine(string.Join(",", data));
                }
            }
            Console.ReadLine();
        }
    }
}

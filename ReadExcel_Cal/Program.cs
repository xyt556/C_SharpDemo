using System;
using System.Collections.Generic;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open the excel file
            var app = new Excel.Application();
            var workbook = app.Workbooks.Open(@"D:\C#\C_SharpDemo\ReadExcel_Cal\data.xlsx");
            var worksheet = workbook.Worksheets[1];

            // Get the used range of cells
            var range = worksheet.UsedRange;

            // Loop through each column except the first one
            for (int col = 2; col <= range.Columns.Count; col++)
            {
                // Get all the values in the column as an array except the first row
                var values = (object[,])range.Range[range.Cells[2, col], range.Cells[range.Rows.Count, col]].Value2;

                // Convert the array to a list of doubles
                var list = new List<double>();
                for (int row = 1; row <= values.GetLength(0); row++)
                {
                    if (values[row, 1] != null) // Skip null values
                    {
                        list.Add(Convert.ToDouble(values[row, 1]));
                    }
                }

                // Calculate the max, min and average of the list
                double max = list.Max();
                double min = list.Min();
                double average = list.Average();

                // Print the results
                Console.WriteLine($"Column {col}: Max={max}, Min={min}, Average={average}");
            }

            // Close the excel file
            workbook.Close(false);
            app.Quit();
        }
    }
}
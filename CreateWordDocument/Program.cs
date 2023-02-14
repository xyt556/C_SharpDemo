using System;
using System.Reflection;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;

namespace CreateWordDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建Word应用程序实例
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

            // 创建文档
            Document doc = word.Documents.Add();

            // 添加段落
            Paragraph para = doc.Content.Paragraphs.Add();
            para.Range.Text = "Hello World";
            para.Range.Font.Bold = 1;
            para.Range.Font.Size = 14;
            para.Format.SpaceAfter = 24;
            para.Range.InsertParagraphAfter();

            // 保存文档
            object filename = @"C:\HelloWorld.docx";
            doc.SaveAs2(ref filename);

            // 关闭Word应用程序
            word.Quit();
        }
    }
}

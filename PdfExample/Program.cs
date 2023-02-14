using System;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PdfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个Document对象
            Document document = new Document();

            // 创建一个PdfWriter对象
            PdfWriter.GetInstance(document, new FileStream(@"C:\example.pdf", FileMode.Create));

            // 打开文档
            document.Open();

            // 在文档中添加一些文字
            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\simhei.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font = new Font(baseFont, 12, Font.NORMAL);
            document.Add(new Paragraph("这是一个支持中文的PDF文档", font));

            // 关闭文档
            document.Close();
        }
    }
}

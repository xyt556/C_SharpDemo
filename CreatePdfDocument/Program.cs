using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Xml.Linq;

namespace CreatePdfDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建新的 PDF 文档
            PdfDocument document = new PdfDocument();
            document.Info.Title = "My PDF Document";

            // 添加一个页面
            PdfPage page = document.AddPage();

            // 获取页面的图形对象
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // 设置字体
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);

            // 在页面上绘制文本
            gfx.DrawString("Hello, PDF!", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormat.Center);
            gfx.DrawString("欢迎!", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormat.BottomCenter);
            // 保存 PDF 文档
            document.Save(@"C:\MyPdfDocument.pdf");
        }
    }
}

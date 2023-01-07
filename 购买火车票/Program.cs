
/*
学生火车票优惠如下:
每年的1 - 3月和7 - 9月凭学生证可打5折。
10人(含10人) 以上团购还可打9折。
请输入单张火车票的全价: (1~1000):45
是否为学生(Y / N) :y
请输入当前月份(1 - 12) :5
请输入需要订票的人数: 5
您应付的金额是: 225
*/


namespace 购买火车票
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
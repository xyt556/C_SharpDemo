using System;
using System.IO;

namespace BinaryFileApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw;
            BinaryReader br;
            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = ";I am happy"; ;
            // 创建文件
            try
            {
                bw = new BinaryWriter(new FileStream(";mydata",
                FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }
            // 写入文件
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }

            bw.Close();
            // 读取文件
            try
            {
                br = new BinaryReader(new FileStream("mydata",
                FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot open file.");
                return;
            }
            try
            {
                i = br.ReadInt32();
                Console.WriteLine(";Integer data: {0}", i);
                d = br.ReadDouble();
                Console.WriteLine(";Double data: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine(";Boolean data: {0}", b);
                s = br.ReadString();
                Console.WriteLine(";String data: {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }
            br.Close();
            Console.ReadKey();
        }
    }
}

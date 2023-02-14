using OSGeo.OSR;
using OSGeo.OGR;
using System;

namespace GdalExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化OGR
            Ogr.RegisterAll();

            // 创建数据源
            string strDriverName = "ESRI Shapefile";
            Driver oDriver = Ogr.GetDriverByName(strDriverName);
            if (oDriver == null)
            {
                Console.WriteLine("驱动不可用。");
                return;
            }

            string strDataSource = "lines.shp";
            DataSource oDS = oDriver.CreateDataSource(strDataSource, null);
            if (oDS == null)
            {
                Console.WriteLine("创建数据源失败。");
                return;
            }

            // 创建空间参考
            SpatialReference oSRS = new SpatialReference("");
            oSRS.ImportFromEPSG(4326);

            // 创建图层
            string strLayer = "lines";
            Layer oLayer = oDS.CreateLayer(strLayer, oSRS, wkbLineString, null);
            if (oLayer == null)
            {
                Console.WriteLine("创建图层失败。");
                return;
            }

            // 创建字段
            FieldDefn oFieldName = new FieldDefn("Name", FieldType.OFTString);
            oFieldName.SetWidth(32);
            oLayer.CreateField(oFieldName, 1);

            // 创建要素
            Feature oFeature = new Feature(oLayer.GetLayerDefn());
            oFeature.SetField(0, "Line 1");

            // 创建线段
            LineString oLine = new LineString(2);
            oLine.SetPoint(0, 0, 0);
            oLine.SetPoint(1, 1, 1);
            oFeature.SetGeometry(oLine);

            // 将要素写入图层
            oLayer.CreateFeature(oFeature);

            // 释放资源
            oLine.Dispose();
            oFeature.Dispose();
            oDS.Dispose();

            Console.WriteLine("矢量线图层创建成功。");
        }
    }
}

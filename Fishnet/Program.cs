using System;
using OSGeo.OSR;
using OSGeo.GDAL;
using OSGeo.OGC.Ogr;
using System.Reflection.Emit;

namespace Fishnet
{
    class Program
    {
        static void Main(string[] args)
        {
            // 设置GDAL的配置文件路径
            Gdal.SetConfigOption("GDAL_DATA", @"C:\gdal-data");

            // 初始化GDAL
            Gdal.AllRegister();

            // 创建空间参考
            SpatialReference sr = new SpatialReference("");
            sr.ImportFromEPSG(4326);

            // 创建数据源
            DataSource ds = Ogr.Open("fishnet.shp", 1);
            if (ds == null)
            {
                ds = Ogr.GetDriverByName("ESRI Shapefile").CreateDataSource("fishnet.shp");
            }

            // 创建图层
            Layer layer = ds.CreateLayer("fishnet", sr, wkbGeometryType.wkbPolygon, null);

            // 定义字段
            FieldDefn idField = new FieldDefn("id", FieldType.OFTInteger);
            layer.CreateField(idField, 1);

            // 创建fishnet
            int xSize = 10;
            int ySize = 10;
            int xCount = 10;
            int yCount = 10;
            double xMin = 0;
            double yMin = 0;
            double xMax = 100;
            double yMax = 100;
            for (int i = 0; i < yCount; i++)
            {
                for (int j = 0; j < xCount; j++)
                {
                    double x = xMin + j * xSize;
                    double y = yMax - i * ySize;
                    Geometry geom = Geometry.CreateFromWkt(string.Format("POLYGON(({0} {1},{2} {1},{2} {3},{0} {3},{0} {1}))", x, y, x + xSize, y - ySize));
                    Feature feature = new Feature(layer.GetLayerDefn());
                    feature.SetGeometry(geom);
                    feature.SetField(0, i * xCount + j);
                    layer.CreateFeature(feature);
                }
            }

            // 关闭数据源
            ds.Dispose();
        }
    }
}

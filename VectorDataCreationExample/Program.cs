using OSGeo.OGR;

namespace VectorDataCreationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化 OGR
            //Ogr.RegisterAll();
            //注册Ogr库  
            string pszDriverName = "ESRI Shapefile";
            OSGeo.OGR.Ogr.RegisterAll();
            //调用对Shape文件读写的Driver接口  
            OSGeo.OGR.Driver poDriver = OSGeo.OGR.Ogr.GetDriverByName(pszDriverName);
            // 创建数据源
            var dataSource = Ogr.Open("vector_data.shp", 1);
            if (dataSource == null)
            {
                dataSource = poDriver.CreateDataSource("vector_data.shp", null);
            }

            // 创建图层
            var layer = dataSource.CreateLayer("layer_name", null, wkbGeometryType.wkbPoint, null);

            // 创建字段
            var fieldDefinition = new FieldDefn("field_name", FieldType.OFTString);
            fieldDefinition.SetWidth(32);
            layer.CreateField(fieldDefinition, 1);

            // 创建要素
            var feature = new Feature(layer.GetLayerDefn());
            feature.SetField(0, "feature_name");

            // 创建几何形状
            var point = new Geometry(wkbGeometryType.wkbPoint);
            point.AddPoint(10, 10, 0);
            feature.SetGeometry(point);

            // 把要素写入图层
            layer.CreateFeature(feature);

            // 关闭数据源
            dataSource.Dispose();
        }
    }
}

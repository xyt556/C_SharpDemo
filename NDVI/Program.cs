using System;
using System.Data;
using OSGeo.GDAL;

namespace NDVI
{
    class Program
    {
        static void Main(string[] args)
        {
            Gdal.AllRegister();
            Dataset ds = Gdal.Open("your_raster_file_path.tif", Access.GA_ReadOnly);
            int xSize = ds.RasterXSize;
            int ySize = ds.RasterYSize;
            int bandCount = ds.RasterCount;
            if (bandCount < 2)
            {
                Console.WriteLine("The input raster should have at least 2 bands.");
                return;
            }
            Band redBand = ds.GetRasterBand(1);
            Band nirBand = ds.GetRasterBand(2);
            float[] redData = new float[xSize * ySize];
            float[] nirData = new float[xSize * ySize];
            redBand.ReadRaster(0, 0, xSize, ySize, redData, xSize, ySize, 0, 0);
            nirBand.ReadRaster(0, 0, xSize, ySize, nirData, xSize, ySize, 0, 0);
            float[] ndviData = new float[xSize * ySize];
            for (int i = 0; i < xSize * ySize; i++)
            {
                float redValue = redData[i];
                float nirValue = nirData[i];
                float ndviValue = (nirValue - redValue) / (nirValue + redValue);
                ndviData[i] = ndviValue;
            }
            Dataset ndviDs = Gdal.GetDriverByName("GTiff").Create("ndvi.tif", xSize, ySize, 1, DataType.GDT_Float32, null);
            Band ndviBand = ndviDs.GetRasterBand(1);
            ndviBand.WriteRaster(0, 0, xSize, ySize, ndviData, xSize, ySize, 0, 0);
            ndviBand.FlushCache();
            ndviDs.Dispose();
            ds.Dispose();
            Console.WriteLine("NDVI computation completed successfully.");
        }
    }
}

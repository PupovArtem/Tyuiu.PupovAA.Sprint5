using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PupovAA.Sprint5.Task3.V9.Lib
{
    public class DataService : ISprint5Task3V9
    {
        public string SaveToFileTextData(int x)
        {
            double y = Math.Pow(x, 3) / (Math.Pow(x, 2) - 1);
            y = Math.Round(y, 3);
            string fileName = "OutPutFileTask3.bin";
            string filepath = Path.Combine(Path.GetTempPath(), fileName);
            using(BinaryWriter writer = new BinaryWriter(File.Open(filepath, FileMode.Append)))
{
                writer.Write(y);
            }
            return filepath;
        }
    }
}

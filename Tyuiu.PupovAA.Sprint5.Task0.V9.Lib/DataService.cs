using System.IO;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PupovAA.Sprint5.Task0.V9.Lib
{
    public class DataService : ISprint5Task0V9
    {
        public string SaveToFileTextData(int x)
        {
            
            double y = Math.Pow(x, 3) / (Math.Pow(x, 2) - 1);
            y = Math.Round(y, 3);
            string fileName = "OutPutFileTask0.txt";
            string filePath = Path.Combine(Path.GetTempPath(), fileName);
            File.WriteAllText(filePath, Convert.ToString(y));
            return filePath;


        }
    }
}

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PupovAA.Sprint5.Task1.V22.Lib
{
    public class DataService : ISprint5Task1V22
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string fileName = "OutPutFileTask1.txt";
            string filePath = Path.Combine(Path.GetTempPath(), fileName);
            FileInfo fileInfo = new FileInfo(filePath);
            bool fileinfo = fileInfo.Exists;
            if (fileinfo)
            {
                File.Delete(filePath);

            }
            double y;
            string stry;
            for (int i = startValue;i <= stopValue;i++)
            {
                y = Math.Round((Math.Sin(i)+ ((Math.Cos(i) + 1) / (2 - i))+ 2 * i),2);
                if (Math.Abs(2 - i) < 1e-10)
                {
                    y = 0;
                }
                stry=Convert.ToString(y);
                if (i!=stopValue)
                {
                    File.AppendAllText(filePath, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(filePath, stry);
                }
            }
            return filePath;
        }
    }
}

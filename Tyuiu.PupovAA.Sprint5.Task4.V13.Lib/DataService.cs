using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PupovAA.Sprint5.Task4.V13.Lib
{
    public class DataService : ISprint5Task4V13
    {
        public double LoadFromDataFile(string path)
        {
           string strx = File.ReadAllText(path);
            strx = strx.Replace(".", ",");
           double x = Convert.ToDouble(strx);

            double res = Math.Cos(x) + (x * x) / 2;
            return Math.Round(res,3);

        }
    }
}

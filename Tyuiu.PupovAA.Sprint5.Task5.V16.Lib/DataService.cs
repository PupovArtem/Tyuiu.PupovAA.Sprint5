using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace Tyuiu.PupovAA.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            string[] str = strx.Split(',');
            double ret = 0;
            for (int  i = 0;  i < str.Length-1; i++)
            {
                double x = double.Parse(str[i]);
                if (x % 10 == 0)
                {
                    if (x > ret)
                    {
                        ret= x;
                    }
                }
            }return ret;




        }
    }
}

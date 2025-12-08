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
            
            double ret = double.MinValue;
            foreach(string str2 in str)
            {
                
                if (double.TryParse(str2.Trim(), out double res) && res % 10 == 0)
                {
                    if (res > ret)
                    {
                        ret= res;
                    }
                }

            }
            return ret;




        }
    }
}

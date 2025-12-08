using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PupovAA.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            
            string[] str1 = str.Split(" ");
            for (int i = 0; i < str1.Length; i++)
            {
                str1[i] = str1[i].Trim('?', '!', '.', ',', ';', ':', '"', '\'');
            }






            int counter = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                int len = 0;
                for (int j = 0; j < str1[i].Length; j++)
                {
                    len++;

                }
                if (len == 6)
                {
                    counter++;
                }
            }
            return counter;

            
        }
    }
}

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PupovAA.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {
        public string LoadDataAndSave(string path)
        {
            string[] str = File.ReadAllText(path).Split(" ");

            for(int i  = 0; i < str.Length; i++)
            {
                char[] chars = str[i].ToCharArray();
                for (int j = 0; j < chars.Length; j++)
                {
                    if ((chars[j] >= 'A' && chars[j] <= 'Z') || (chars[j] >= 'a' && chars[j] <= 'z'))
                    {
                        chars[j] = '#';
                    }
                }
                str[i] = new string(chars);
            }
            string res = string.Join(" ", str);
            
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V6.txt");
            File.WriteAllText(outputPath, res);
            return res;
        }
    }
}

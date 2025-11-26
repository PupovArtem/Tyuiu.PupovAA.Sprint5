using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PupovAA.Sprint5.Task2.V12.Lib
{
    public class DataService : ISprint5Task2V12
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string fileName = "OutPutFileTask1.csv";
            string filePath = Path.Combine(Path.GetTempPath(), fileName);
            FileInfo fileInfo = new FileInfo(filePath);
            bool fileinfo = fileInfo.Exists;
            if (fileinfo)
            {
                File.Delete(filePath);

            }
            for (int i=0;  i<matrix.GetLength(0); i++)
            {
                for (int j =0; j<matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string str = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j!= matrix.GetLength(1)-1)
                    {
                        str=str+ matrix[i, j]+";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                    
                }
                if (i != matrix.GetLength(0) - 1)
                {
                    File.AppendAllText(filePath, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(filePath, str);
                }
                str = "";
            }
            return filePath;

        }
    }
}

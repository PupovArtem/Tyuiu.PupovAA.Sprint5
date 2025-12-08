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

            List<double> results = new List<double>(); // Используем List вместо массива

            foreach (string str2 in str)
            {
                if (double.TryParse(str2.Trim(), out double res))
                {
                    // Округляем для избежания погрешности
                    res = Math.Round(res, 3);

                    // Проверяем, целое ли число и делится на 10
                    if (Math.Abs(res % 1) < 0.000001) // целое число
                    {
                        int intRes = (int)Math.Round(res);
                        if (intRes % 10 == 0)
                        {
                            // Исправленное условие: числа от -99 до -1 ИЛИ от 0 до 9
                            if (res > -100 && res < 10)
                            {
                                results.Add(res);
                            }
                        }
                    }
                }
            }

            if (results.Count == 0)
            {
                Console.WriteLine("Не найдено подходящих чисел");
                return 0; // или выбросить исключение
            }

            return results.Max();





        }
    }
}

using System.Runtime.Serialization.Formatters;
using Tyuiu.PupovAA.Sprint5.Task2.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mtrx = new int[3, 3] {
            { -5, -5, 9 },
            { -7, 3, -4},
            { 8, 7, 9 } };

        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл              *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #12                                                              *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич  | ИБКСб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("массив: ");
        for (int i = 0;i < mtrx.GetLength(0); i++)
        {
            for (int j = 0;j < mtrx.GetLength(1); j++)
            {
                Console.Write($"{mtrx[i, j]}\t");
            }
            Console.WriteLine();
        }

      
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                        *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(mtrx);
        Console.WriteLine("Файл:" + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}
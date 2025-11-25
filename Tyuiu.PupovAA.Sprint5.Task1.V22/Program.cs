using Tyuiu.PupovAA.Sprint5.Task1.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int start = -5;
        int end = 5;
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                            *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #22                                                              *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич  | ИБКСб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("start = " + start);
        Console.WriteLine("end = " + end);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                        *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(start, end);
        Console.WriteLine("Файл:" + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}

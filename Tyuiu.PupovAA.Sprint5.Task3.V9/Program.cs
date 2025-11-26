using Tyuiu.PupovAA.Sprint5.Task3.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int x = 3;
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                            *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич  | ИБКСб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("x = " + x);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                        *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл:" + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}
using Tyuiu.PupovAA.Sprint5.Task7.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine(ds.LoadDataAndSave(@"C:\Users\artem\source\repos\Tyuiu.PupovAA.Sprint5\DataSprint5\InPutDataFileTask7V6.txt"));
        Console.WriteLine("Выполнил Пупов Артём Андреевичю. Группа ИБКСб-25-1");
    }
}
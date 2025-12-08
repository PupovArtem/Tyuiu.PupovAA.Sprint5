using Tyuiu.PupovAA.Sprint5.Task6.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine(ds.LoadFromDataFile(@"C:\Users\artem\source\repos\Tyuiu.PupovAA.Sprint5\DataSprint5\InPutDataFileTask6V11.txt"));
    }
}
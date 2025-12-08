using Tyuiu.PupovAA.Sprint5.Task6.V11.Lib;
namespace Tyuiu.PupovAA.Sprint5.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\artem\source\repos\Tyuiu.PupovAA.Sprint5\DataSprint5\InPutDataFileTask6V11.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fx = fileInfo.Exists;
            Assert.AreEqual(true, fx);
            DataService ds = new DataService();
            var s = ds.LoadFromDataFile(path);
            Assert.AreEqual(3, s);
        }
    }
}

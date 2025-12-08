using Tyuiu.PupovAA.Sprint5.Task7.V6.Lib;
namespace Tyuiu.PupovAA.Sprint5.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\artem\source\repos\Tyuiu.PupovAA.Sprint5\DataSprint5\InPutDataFileTask7V6.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fx = fileInfo.Exists;
            Assert.AreEqual(true, fx);
            
        }
    }
}

using Tyuiu.PupovAA.Sprint5.Task2.V12.Lib;
namespace Tyuiu.PupovAA.Sprint5.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\artem\AppData\Local\Temp\OutPutFileTask1.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fx = fileInfo.Exists;
            Assert.AreEqual(true, fx);
        }
    }
}

using Tyuiu.PupovAA.Sprint5.Task1.V22.Lib;
namespace Tyuiu.PupovAA.Sprint5.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\artem\AppData\Local\Temp\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fx = fileInfo.Exists;
            Assert.AreEqual(true, fx);
        }
    }
}

using Tyuiu.PupovAA.Sprint5.Task0.V9.Lib;
namespace Tyuiu.PupovAA.Sprint5.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\artem\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fx= fileInfo.Exists;
            Assert.AreEqual(true, fx);
        }
    }
}

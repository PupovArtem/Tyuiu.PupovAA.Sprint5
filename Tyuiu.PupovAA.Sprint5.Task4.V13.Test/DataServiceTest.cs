using Tyuiu.PupovAA.Sprint5.Task4.V13.Lib;
namespace Tyuiu.PupovAA.Sprint5.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V13.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fx = fileInfo.Exists;
            Assert.AreEqual(true, fx);
        }
    }
}

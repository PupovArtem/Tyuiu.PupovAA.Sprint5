using Tyuiu.PupovAA.Sprint5.Task5.V16.Lib;
namespace Tyuiu.PupovAA.Sprint5.Task5.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V16.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fx = fileInfo.Exists;
            Assert.AreEqual(true, fx);
        }
    }
}

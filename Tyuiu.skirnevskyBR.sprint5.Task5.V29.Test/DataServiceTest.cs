using System.IO;
using Tyuiu.skirnevskyBR.sprint5.Task5.V29.Lib;
namespace Tyuiu.skirnevskyBR.sprint5.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CValidLoadFromDataFile_WithRealData()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V29.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
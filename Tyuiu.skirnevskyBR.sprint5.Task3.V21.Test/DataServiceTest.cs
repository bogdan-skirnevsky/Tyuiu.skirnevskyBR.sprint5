using System.IO;
using Tyuiu.skirnevskyBR.sprint5.Task3.V21.Lib;
namespace Tyuiu.skirnevskyBR.sprint5.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int x = 3;

            string actualPath = ds.SaveToFileTextData(x);

            FileInfo fileInfo = new FileInfo(actualPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists, $"Файл не найден по пути: {actualPath}");
        }
    }
}

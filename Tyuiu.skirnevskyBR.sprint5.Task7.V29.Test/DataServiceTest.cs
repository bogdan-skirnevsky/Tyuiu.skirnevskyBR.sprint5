using System.IO;
using Tyuiu.skirnevskyBR.sprint5.Task7.V29.Lib;
namespace Tyuiu.skirnevskyBR.sprint5.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\DataSprint5\InPutDataFileTask7V29.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, res, $"Входной файл не найден по пути: {path}");
        }
    }
}
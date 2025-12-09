using System.IO;
using Tyuiu.skirnevskyBR.sprint5.Task1.V27.Lib;
namespace Tyuiu.skirnevskyBR.sprint5.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\user\AppData\Local\Temp\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            bool wait = false;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
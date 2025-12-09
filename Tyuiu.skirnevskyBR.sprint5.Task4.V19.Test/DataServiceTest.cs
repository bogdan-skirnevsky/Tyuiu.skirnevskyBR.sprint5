using System.IO;
using Tyuiu.skirnevskyBR.sprint5.Task4.V19.Lib;
namespace Tyuiu.skirnevskyBR.sprint5.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\DataSprint5\InPutDataFileTask4V19.txt";
            FileInfo fileInfo = new FileInfo(path);

            bool res = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, res, $"Входной файл не найден по пути: {path}");
        }

        [TestMethod]
        public void ValidLoadFromDataFile()
        {

            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, "1.5"); 

            try
            {
                DataService ds = new DataService();

                double x = 1.5;
                double expected = Math.Pow(x / Math.Cos(x), 2);
                expected = Math.Round(expected, 3);

                double actual = ds.LoadFromDataFile(tempPath);

                Assert.AreEqual(expected, actual, 0.001, "Результат вычисления неверный");
            }
            finally
            {

                if (File.Exists(tempPath))
                {
                    File.Delete(tempPath);
                }
            }
        }
    }
}
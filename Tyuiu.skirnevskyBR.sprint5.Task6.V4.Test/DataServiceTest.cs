using System.IO;
using Tyuiu.skirnevskyBR.sprint5.Task6.V4.Lib;
namespace Tyuiu.skirnevskyBR.sprint5.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\user\source\repos\Tyuiu.skirnevskyBR.Sprint5\Tyuiu.skirnevskyBR.Sprint5.Task6.V4\bin\Debug\net8.0\InPutDataFileTask6V4.txt";


            string testData = "Привет МИР! Это Тестовый Текст с Заглавными Буквами: А, Б, В и Ё.";
            File.WriteAllText(path, testData, System.Text.Encoding.Default);

            try
            {
                var res = ds.LoadFromDataFile(path);

                int wait = 13;

                Assert.AreEqual(wait, res);
            }
            finally
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V4.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists, $"Файл не найден по пути: {path}");
        }
    }
}
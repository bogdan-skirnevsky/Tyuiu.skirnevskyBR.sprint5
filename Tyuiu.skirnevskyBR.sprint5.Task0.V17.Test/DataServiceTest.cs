using Tyuiu.skirnevskyBR.sprint5.Task0.V17.Lib;
namespace Tyuiu.skirnevskyBR.sprint5.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {

            DataService ds = new DataService();
            int x = 3;

            double expected = 2.4 * Math.Pow(3, 3) + 0.4 * Math.Pow(3, 2) - 1.4 * 3 + 4.1;
            expected = Math.Round(expected, 3);

            string path = ds.SaveToFileTextData(x);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists, "Файл не был создан");

            string fileContent = File.ReadAllText(path);
            double actual = double.Parse(fileContent);

            Assert.AreEqual(expected, actual, 0.001, "Значение в файле не соответствует ожидаемому");
        }
    }
}
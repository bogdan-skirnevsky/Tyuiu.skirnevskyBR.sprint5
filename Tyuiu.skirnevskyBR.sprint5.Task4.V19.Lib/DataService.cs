using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.skirnevskyBR.sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path).Trim();

            double x = double.Parse(fileContent, System.Globalization.CultureInfo.InvariantCulture);

            double y = Math.Pow(x / Math.Cos(x), 2);

            return Math.Round(y, 3);
        }
    }
}
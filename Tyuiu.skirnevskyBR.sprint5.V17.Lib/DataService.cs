using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.skirnevskyBR.sprint5.V17.Lib
{
    public class DataService : ISprint5Task0V17
    {
        public string SaveToFileTextData(int x)
        {

            double result = 2.4 * Math.Pow(x, 3) + 0.4 * Math.Pow(x, 2) - 1.4 * x + 4.1;

            result = Math.Round(result, 3);

            string path = Path.GetTempFileName();

            File.WriteAllText(path, result.ToString());

            return path;
        }
    }
}
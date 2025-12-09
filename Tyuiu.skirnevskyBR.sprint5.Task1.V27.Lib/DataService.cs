using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.skirnevskyBR.sprint5.Task1.V27.Lib
{
    public class DataService : ISprint5Task1V27
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempPath = Path.GetTempPath();
            string filePath = Path.Combine(tempPath, "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(filePath);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(filePath);
            }
            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((3 * x - 1.5) / (Math.Sin(x) - 3 + x) + 2, 2);

                if (double.IsNaN(y) || double.IsInfinity(y))
                {
                    y = 0;
                }

                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(filePath, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(filePath, strY);
                }
            }
            return filePath;
        }
    }
}
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.skirnevskyBR.sprint5.Task2.V19.Lib
{
    public class DataService : ISprint5Task2V19
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string tempPath = Path.GetTempPath();
            string filePath = Path.Combine(tempPath, "OutPutFileTask2.csv");

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] processedMatrix = (int[,])matrix.Clone();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (processedMatrix[i, j] % 2 != 0)
                    {
                        processedMatrix[i, j] = 0;
                    }
                }
            }

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                List<string> rowElements = new List<string>();

                for (int j = 0; j < cols; j++)
                {
                    rowElements.Add(processedMatrix[i, j].ToString());
                }

                string row = string.Join(";", rowElements);

                if (i == 0)
                {
                    File.WriteAllText(filePath, row + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(filePath, row + (i < rows - 1 ? Environment.NewLine : ""));
                }

                Console.WriteLine(row);
                output.AppendLine(row);
            }

            return filePath;
        }
    }
}
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.skirnevskyBR.sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29
    {
        public string LoadDataAndSave(string path)
        {
            string tempPath = Path.GetTempPath();
            string pathSaveFile = Path.Combine(tempPath, "OutPutDataFileTask7V29.txt");

            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    strLine = "";

                    for (int i = 0; i < line.Length; i++)
                    {
                        char currentChar = line[i];

                        if (char.IsDigit(currentChar))
                        {


                            bool isStartOfLine = (i == 0);
                            bool isEndOfLine = (i == line.Length - 1);
                            bool prevIsDigit = (!isStartOfLine && char.IsDigit(line[i - 1]));
                            bool nextIsDigit = (!isEndOfLine && char.IsDigit(line[i + 1]));

                            if (prevIsDigit || nextIsDigit)
                            {
                                strLine += currentChar;
                            }

                        }
                        else
                        {

                            strLine += currentChar;
                        }
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                }
            }

            return pathSaveFile;
        }
    }
}
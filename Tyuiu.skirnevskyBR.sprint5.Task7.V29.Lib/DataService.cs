using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.skirnevskyBR.sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29
    {
        public string LoadDataAndSave(string path)
        {
            StringBuilder result = new StringBuilder();

            using (StreamReader reader = new StreamReader(path, Encoding.Default))
            {
                string text = reader.ReadToEnd();

                for (int i = 0; i < text.Length; i++)
                {
                    char current = text[i];

                    if (char.IsDigit(current))
                    {

                        bool prevIsDigit = (i > 0 && char.IsDigit(text[i - 1]));
                        bool nextIsDigit = (i < text.Length - 1 && char.IsDigit(text[i + 1]));

                        if (prevIsDigit || nextIsDigit)
                        {

                            result.Append(current);
                        }

                    }
                    else
                    {
                        result.Append(current);
                    }
                }
            }

            string finalResult = result.ToString();
            finalResult = finalResult.Replace("  ", " ");

            return finalResult.Trim();
        }
    }
}
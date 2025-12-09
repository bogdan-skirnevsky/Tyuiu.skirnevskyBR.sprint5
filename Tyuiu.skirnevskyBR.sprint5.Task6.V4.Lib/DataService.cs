using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.skirnevskyBR.sprint5.Task6.V4.Lib
{
    public class DataService : ISprint5Task6V4
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            using (StreamReader reader = new StreamReader(path, Encoding.Default))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];

                        if ((c >= 'А' && c <= 'Я') || c == 'Ё')
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}
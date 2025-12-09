using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.skirnevskyBR.sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {

            string text = File.ReadAllText(path);

            string[] strings = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            double[] numbers = new double[strings.Length];

            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

            for (int i = 0; i < strings.Length; i++)
            {
                numbers[i] = double.Parse(strings[i], formatter);
            }

            double minTwoDigitInt = double.MaxValue;
            bool found = false;

            foreach (double num in numbers)
            {

                if (num == Math.Floor(num))
                {
                    int intNum = (int)num;

                    if (intNum >= 10 && intNum <= 99)
                    {
                        if (intNum < minTwoDigitInt)
                        {
                            minTwoDigitInt = intNum;
                            found = true;
                        }
                    }
                }
            }

            if (!found)
            {
                return 0;
            }

            return Math.Round(minTwoDigitInt, 3);
        }
    }
}
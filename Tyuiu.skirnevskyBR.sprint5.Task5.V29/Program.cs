using Tyuiu.skirnevskyBR.sprint5.Task5.V29.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл C:\\DataSprint\\InPutDataFileTask5V29.txt в котором есть набор  *");
        Console.WriteLine("* значений. Найти минимальное целое число в файле, которое является       *");
        Console.WriteLine("* двузначным числом. Полученный результат вывести на консоль.             *");
        Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint\InPutDataFileTask5V29.txt";

        Console.WriteLine("Файл находится: " + path);

        if (!File.Exists(path))
        {
            Console.WriteLine("\n⚠️  Файл не найден!");
            Console.WriteLine("Пожалуйста, выполните следующие шаги:");
            Console.WriteLine("1. Создайте папку C:\\DataSprint\\");
            Console.WriteLine("2. Поместите в неё файл InPutDataFileTask5V29.txt");
            Console.WriteLine("3. Запустите программу снова");
            Console.WriteLine("\nСодержимое файла должно быть:");
            Console.WriteLine("5 9 18 -0.48 18.17 12 11 -4.71 -5.7 18 -3.92 -4 -1.03 9 8.08 2.78 8.76 -9.75 -3 -4");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("\nСодержимое файла:");
        string fileContent = File.ReadAllText(path);
        Console.WriteLine(fileContent);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        try
        {
            double result = ds.LoadFromDataFile(path);

            if (result == 0)
            {
                Console.WriteLine("В файле не найдено двузначных целых чисел.");
            }
            else
            {
                Console.WriteLine($"Минимальное двузначное целое число: {result}");
                Console.WriteLine($"Округленный результат: {result:F3}");

                Console.WriteLine("\n=== Анализ данных ===");
                Console.WriteLine($"Всего чисел в файле: {fileContent.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length}");

                string[] strings = fileContent.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                IFormatProvider formatter = new System.Globalization.NumberFormatInfo { NumberDecimalSeparator = "." };

                Console.Write("Найденные двузначные целые числа: ");
                bool hasTwoDigit = false;
                foreach (string str in strings)
                {
                    double num = double.Parse(str, formatter);
                    if (num == Math.Floor(num))
                    {
                        int intNum = (int)num;
                        if (intNum >= 10 && intNum <= 99)
                        {
                            Console.Write($"{intNum} ");
                            hasTwoDigit = true;
                        }
                    }
                }

                if (!hasTwoDigit)
                {
                    Console.Write("не найдены");
                }
                Console.WriteLine();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("ОШИБКА: Файл содержит некорректные числовые данные");
            Console.WriteLine("Убедитесь, что в файле только числа, разделенные пробелами");
        }
        catch (Exception ex)
        {
            Console.WriteLine("ОШИБКА: " + ex.Message);
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
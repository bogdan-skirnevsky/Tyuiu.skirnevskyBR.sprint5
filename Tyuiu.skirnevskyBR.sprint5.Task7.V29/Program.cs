using Tyuiu.skirnevskyBR.sprint5.Task7.V29.Lib;

class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask7V29.txt в котором есть набор *");
        Console.WriteLine("* символьных данных. Удалить все однозначные числа из файла.              *");
        Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V29.txt.       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask7V29.txt";

        Console.WriteLine("Данные находятся в файле: " + path);

        if (!File.Exists(path))
        {
            Console.WriteLine("\n⚠️  Файл не найден!");
            Console.WriteLine("Пожалуйста, выполните следующие шаги:");
            Console.WriteLine("1. Создайте папку C:\\DataSprint5\\");
            Console.WriteLine("2. Поместите в неё файл InPutDataFileTask7V29.txt из архива");
            Console.WriteLine("3. Запустите программу снова");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("\nСодержимое входного файла:");
        Console.WriteLine("========================================");
        string inputContent = File.ReadAllText(path);
        Console.WriteLine(inputContent);
        Console.WriteLine("========================================");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Находится в файле: ");

        try
        {
            string pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);

            Console.WriteLine("\nСодержимое выходного файла:");
            Console.WriteLine("========================================");
            if (File.Exists(pathSaveFile))
            {
                string outputContent = File.ReadAllText(pathSaveFile);
                Console.WriteLine(outputContent);

                Console.WriteLine("\n=== Сравнение ===");
                Console.WriteLine($"Длина исходного текста: {inputContent.Length} символов");
                Console.WriteLine($"Длина обработанного текста: {outputContent.Length} символов");

                int singleDigitCount = 0;
                for (int i = 0; i < inputContent.Length; i++)
                {
                    if (char.IsDigit(inputContent[i]))
                    {
                        bool isStart = (i == 0);
                        bool isEnd = (i == inputContent.Length - 1);
                        bool prevIsDigit = (!isStart && char.IsDigit(inputContent[i - 1]));
                        bool nextIsDigit = (!isEnd && char.IsDigit(inputContent[i + 1]));

                        if (!prevIsDigit && !nextIsDigit)
                        {
                            singleDigitCount++;
                        }
                    }
                }
                Console.WriteLine($"Удалено однозначных чисел: {singleDigitCount}");
            }
            else
            {
                Console.WriteLine("Выходной файл не был создан!");
            }
            Console.WriteLine("========================================");
        }
        catch (Exception ex)
        {
            Console.WriteLine("ОШИБКА: " + ex.Message);
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
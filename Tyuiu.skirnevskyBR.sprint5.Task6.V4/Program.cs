using Tyuiu.skirnevskyBR.sprint5.Task6.V4.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask6V4.txt в котором есть набор  *");
        Console.WriteLine("* символьных данных. Найти количество заглавных русских букв в заданной   *");
        Console.WriteLine("* строке.                                                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");

        string path = @"C:\DataSprint5\InPutDataFileTask6V4.txt";

        Console.WriteLine("Данные находятся в файле: " + path);

        if (!File.Exists(path))
        {
            Console.WriteLine("\n⚠️  Файл не найден!");
            Console.WriteLine("Пожалуйста, выполните следующие шаги:");
            Console.WriteLine("1. Создайте папку C:\\DataSprint5\\");
            Console.WriteLine("2. Поместите в неё файл InPutDataFileTask6V4.txt из архива");
            Console.WriteLine("3. Запустите программу снова");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("\nСодержимое файла:");
        Console.WriteLine("========================================");
        string fileContent = File.ReadAllText(path, System.Text.Encoding.Default);
        Console.WriteLine(fileContent);
        Console.WriteLine("========================================");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        try
        {
            int res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество заглавных русских букв: " + res);

            Console.WriteLine("\n=== Анализ данных ===");
            Console.WriteLine($"Длина строки: {fileContent.Length} символов");

            Console.Write("Найденные заглавные русские буквы: ");
            bool foundAny = false;
            foreach (char c in fileContent)
            {
                if ((c >= 'А' && c <= 'Я') || c == 'Ё')
                {
                    Console.Write($"{c} ");
                    foundAny = true;
                }
            }

            if (!foundAny)
            {
                Console.Write("не найдены");
            }
            Console.WriteLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("ОШИБКА: " + ex.Message);
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
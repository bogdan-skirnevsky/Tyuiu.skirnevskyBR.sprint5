using Tyuiu.skirnevskyBR.sprint5.Task4.V19.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask4V0.txt в котором есть        *");
        Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо  *");
        Console.WriteLine("* X в формуле y = (x/cos(x))². Вычислить значение по формуле, округлить   *");
        Console.WriteLine("* до трёх знаков после запятой и вернуть полученный результат на консоль. *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        string path = @"C:\DataSprint5\InPutDataFileTask4V0.txt";

        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("Формула: y = (x / cos(x))²");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        try
        {
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Результат: " + res);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("ОШИБКА: Файл не найден по пути " + path);
            Console.WriteLine("Убедитесь, что:");
            Console.WriteLine("1. Существует папка C:\\DataSprint5\\");
            Console.WriteLine("2. В ней находится файл InPutDataFileTask4V19.txt");
            Console.WriteLine("3. Файл содержит вещественное число");
        }
        catch (FormatException)
        {
            Console.WriteLine("ОШИБКА: Файл не содержит корректное вещественное число");
        }
        catch (Exception ex)
        {
            Console.WriteLine("ОШИБКА: " + ex.Message);
        }

        Console.ReadKey();
    }
}
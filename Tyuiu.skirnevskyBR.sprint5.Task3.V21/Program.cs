using Tyuiu.skirnevskyBR.sprint5.Task3.V21.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 3;

        Console.Title = "Спринт #5 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в  *");
        Console.WriteLine("* бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до    *");
        Console.WriteLine("* трёх знаков после запятой.                                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("x = " + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(x);

        // Для отображения результата читаем из бинарного файла
        double resultValue;
        using (BinaryReader reader = new BinaryReader(File.Open(res, FileMode.Open)))
        {
            resultValue = reader.ReadDouble();
        }

        Console.WriteLine("Результат: " + resultValue);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}
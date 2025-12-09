using Tyuiu.skirnevskyBR.sprint5.Task1.V27.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int startValue = -5;
        int stopValue = 5;

        Console.Title = "Спринт #5 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Табулирование функции на заданном диапазоне                       *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #27                                                             *");
        Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана функция, F(x) = (3x-1.5)/(sin(x)-3+x) + 2                          *");
        Console.WriteLine("* Произвести табулирование f(x) на заданном диапазоне [-5; 5] с шагом 1.  *");
        Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть 0.     *");
        Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести      *");
        Console.WriteLine("* на консоль в таблицу. Значения округлить до двух знаков после запятой.  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Начало шага: " + startValue);
        Console.WriteLine("Конец шага: " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(startValue, stopValue);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}
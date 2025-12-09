using Tyuiu.skirnevskyBR.sprint5.V17.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение F(x) = 2.4x^3 + 0.4x^2 - 1.4x + 4.1, вычислить           *");
        Console.WriteLine("* его значение при x = 3, результат сохранить в текстовый файл            *");
        Console.WriteLine("* OutPutFileTask0.txt и вывести на консоль.                               *");
        Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 3;
        Console.WriteLine("x = " + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(x);

        string fileContent = File.ReadAllText(res);

        Console.WriteLine("Результат выражения: " + fileContent);
        Console.WriteLine("Файл создан: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}
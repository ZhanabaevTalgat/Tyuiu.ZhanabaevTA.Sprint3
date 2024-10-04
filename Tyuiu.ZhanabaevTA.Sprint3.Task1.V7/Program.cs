using Tyuiu.ZhanabaevTA.Sprint3.Task1.V7.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint3.Task1.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Жанабаев Т.А | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Оператор цикла while                                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Жанабаев Талгат Асылбекович | РППб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
            Console.WriteLine("* по формуле p = (a^k + 1)sin(5)                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a = 0.25;
            int start = 1;
            int end = 9;

            Console.WriteLine("a = " + a);
            Console.WriteLine("начальный шаг = " + start);
            Console.WriteLine("конечный шаг = " + end);

            DataService ds = new DataService();
            double MultiplySeries = ds.GetMultiplySeries(a, start, end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(MultiplySeries);
            Console.ReadKey();
        }
    }
}

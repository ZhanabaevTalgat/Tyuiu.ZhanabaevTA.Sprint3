using Tyuiu.ZhanabaevTA.Sprint3.Task4.V23.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint3.Task4.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Жанабаев Т.А | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Использование операторов continue и break в циклах               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Жанабаев Талгат Асылбекович | РППб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке вычислить значение функции y=(cos(x)/x)+3                    *");
            Console.WriteLine("* При х = 0 прервать цикл. Полученные значения перемножать.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            Console.WriteLine("Начальный шаг = " + startValue);

            int stopValue = 5;
            Console.WriteLine("Конечный шаг = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.Calculate(startValue, stopValue);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

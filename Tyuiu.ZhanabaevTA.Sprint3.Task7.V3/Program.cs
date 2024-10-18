using Tyuiu.ZhanabaevTA.Sprint3.Task7.V3.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint3.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Жанабаев Т.А | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Жанабаев Талгат Асылбекович | РППб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = (3x - 15) / (sin(x) - 3 + x) + 2 произвести тубулирование на     *");
            Console.WriteLine("* заданном диапазоне с шагом 1. Произвести проверку на 0. Прт делении на  *");
            Console.WriteLine("* 0 вернуть 0. Значение округлить до 2 знаков после запятой.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Заданный диапазон = [-5;5]");
            int start = -5; int end = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(start, end);
            Console.WriteLine("+---------------+---------------+");
            Console.WriteLine("|       X       |      f(x)     |");
            Console.WriteLine("+---------------+---------------+");
            for (int i = 0; i <= res.Length - 1; i++)
            {
                Console.WriteLine("|{0,5:d}          |{1,5:f2}          |", start, res[i]);
                start++;
            }
            Console.ReadKey();
        }
    }
}
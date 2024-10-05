using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZhanabaevTA.Sprint3.Task4.V23.Lib
{
    public class DataService : ISprint3Task4V23
    {
        public double Calculate(int startValue, int stopValue)
        {
            double result = 1;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                result *= (Math.Cos(x) / x) + 3;
            }

            return Math.Round(result, 3);
        }
    }
}

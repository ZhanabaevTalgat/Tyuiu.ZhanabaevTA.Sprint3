using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZhanabaevTA.Sprint3.Task1.V7.Lib
{
    public class DataService : ISprint3Task1V7
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            while (startValue <= stopValue)
            {
                MultiplySeries *= (Math.Pow(value, startValue) + 1) * Math.Sin(5);
                startValue++;
            }

            return Math.Round(MultiplySeries, 3);
        }
    }
}

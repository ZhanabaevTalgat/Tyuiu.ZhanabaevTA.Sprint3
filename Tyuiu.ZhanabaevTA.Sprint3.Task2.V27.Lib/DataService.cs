using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZhanabaevTA.Sprint3.Task2.V27.Lib
{
    public class DataService : ISprint3Task2V27
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double SumSeries = 0;

            do
            {
                SumSeries += Math.Pow(4/(1+Math.Pow(value,startValue)), startValue);
                startValue++;
            } while (startValue <= stopValue);

            return Math.Round(SumSeries, 3);
        }
    }
}

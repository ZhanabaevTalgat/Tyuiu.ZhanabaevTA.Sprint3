using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZhanabaevTA.Sprint3.Task7.V3.Lib
{
    public class DataService : ISprint3Task7V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Sin(x) - 3 + x) == 0)
                {
                    res[count] = 0;
                    count++;
                }
                else
                {
                    res[count] = Math.Round((3 * x - 1.5) / (Math.Sin(x) - 3 + x) + 2, 2);
                    count++;
                }
            }

            return res;
        }
    }
}

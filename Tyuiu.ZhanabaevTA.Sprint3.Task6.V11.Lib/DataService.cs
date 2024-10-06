using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZhanabaevTA.Sprint3.Task6.V11.Lib
{
    public class DataService : ISprint3Task6V11
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int SumTheDivisors = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 10; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        SumTheDivisors++;
                    }
                }
            }

            return SumTheDivisors;
        }
    }
}

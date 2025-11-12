
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.OzdoevaLM.Sprint3.Task9.Lib
{
    public class DataService : ISprint3Task5V9

    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            int i, k;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    sum = sum + ((1 / Math.Sin(k)) + x);
                }
            }
            return Math.Round(sum, 3); 
        }

    }
}

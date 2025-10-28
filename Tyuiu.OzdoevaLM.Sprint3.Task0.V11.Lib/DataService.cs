using System;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.OzdoevaLM.Sprint3.Task0.V11.Lib
{
    public class DataService : ISprint3Task0V11
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + Math.Pow(1.0 / Math.Pow(value, i), 2);
            }
            return Math.Round(sumSeries,3);
        }
    }
}

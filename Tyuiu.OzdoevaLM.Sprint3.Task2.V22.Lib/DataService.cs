using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.OzdoevaLM.Sprint3.Task2.V22.Lib
{
    public class DataService : ISprint3Task2V22
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            do
            {
                MultiplySeries = MultiplySeries * Math.Pow(3.0 / (startValue + Math.Pow(value, -startValue)), 2);
                startValue++;
            }
            while (startValue <= stopValue);
            return Math.Round(MultiplySeries, 3);
        }
    }
}
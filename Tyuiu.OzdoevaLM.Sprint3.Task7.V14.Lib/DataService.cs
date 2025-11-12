using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.OzdoevaLM.Sprint3.Task7.V14.Lib
{
    public class DataService : ISprint3Task7V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) + 1;
                double y;

                if (denominator == 0)
                {
                    y = 0; // при делении на ноль вернуть 0
                }
                else
                {
                    y = 2 * x - 4 + ((2 * x - 1) / denominator);
                }

                valueArray[index] = Math.Round(y, 2);
                index++;
            }

            return valueArray;
        }
    }
}
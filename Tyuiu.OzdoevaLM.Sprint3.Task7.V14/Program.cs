using Tyuiu.OzdoevaLM.Sprint3.Task7.V14.Lib;
namespace Tyuiu.OzdoevaLM.Sprint3.Task7.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************");
            Console.WriteLine("Исходные данные");
            Console.WriteLine("****************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            double[] valueArray = ds.GetMassFunction(startValue, stopValue);
            int len = valueArray.Length;

            Console.WriteLine("****************");
            Console.WriteLine("РЕЗУЛЬТАТ");
            Console.WriteLine("****************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|   X      |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            int xValue = startValue;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"|{xValue,5}     | {valueArray[i],7:F2}  |");
                xValue++;
            }

            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
using Tyuiu.OzdoevaLM.Sprint3.Task9.Lib;
namespace Tyuiu.OzdoevaLM.Sprint3.Task5.V9
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполниа: Оздоева Л.М. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Вложенные циклы                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполниа: Оздоева Л.М. | ИИПб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*написать программу, которая вычисляет сумму сумм ряда по формуле, при х=5*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 14;
            

            Console.WriteLine("Старт шага первой суммы ряда = " + startValue1);
            Console.WriteLine("Конец шага первой суммы ряда = " + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда= " + startValue2);
            Console.WriteLine("Конец шага второй суммы ряда = " + stopValue2);
            Console.WriteLine("Переменная Х = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма сумм ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

            Console.ReadKey();
        }
    }
}



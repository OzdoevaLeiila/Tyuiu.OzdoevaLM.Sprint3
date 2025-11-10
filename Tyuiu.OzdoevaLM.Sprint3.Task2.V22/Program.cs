using Tyuiu.OzdoevaLM.Sprint3.Task2.V22.Lib;

namespace Tyuiu.OzdoevaLM.Sprint3.Task2.V22
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполниа: Оздоева Л.М. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполниа: Оздоева Л.М. | ИИПб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу используя цикл do-while,которая вычисляет произведение*");
            Console.WriteLine("* ряда по формуле, при х=5                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 7;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("старт шага = " + startValue);
            Console.WriteLine("конец шага = " + stopValue);


            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("Сумма рада = " + ds.GetMultiplySeries(value, startValue, stopValue));

            Console.ReadKey();
        }
    }
}



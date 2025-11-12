using Tyuiu.OzdoevaLM.Sprint3.Task4.V17.Lib;

namespace Tyuiu.OzdoevaLM.Sprint3.Task4.V17
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполниа: Оздоева Л.М. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Использование операторов continue и break в циклах               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполниа: Оздоева Л.М. | ИИПб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=cos(x)/sin(x). При х = 0 прервать цикл. значения перемножать. *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.Calculate(startValue, stopValue));

            Console.ReadKey();
        }
    }
}


using Tyuiu.OzdoevaLM.Sprint3.Task6.V14.Lib;
namespace Tyuiu.OzdoevaLM.Sprint3.Task6.V14
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполниа: Оздоева Л.М. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполниа: Оздоева Л.М. | ИИПб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Напишите программу, которая ищет среди целых чисел, принадлежащих отрезку*");
            Console.WriteLine("*[7, 16] количество всех делителей больше 5                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

          
            int startValue = 7;
            int stopValue = 16;

            Console.WriteLine("начало отрезка = " + startValue);
            Console.WriteLine("конец отрезка = " + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("количество делителей > 5 = " + ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadKey();
        }
    }
}



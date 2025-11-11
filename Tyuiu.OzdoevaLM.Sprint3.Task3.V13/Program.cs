using Tyuiu.OzdoevaLM.Sprint3.Task3.V13.Lib;

namespace Tyuiu.OzdoevaLM.Sprint3.Task3.V13
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполниа: Оздоева Л.М. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполниа: Оздоева Л.М. | ИИПб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach удалить все буквы и знаки препинания, оставить   *");
            Console.WriteLine("* цифру затем преобразовать в число в строке: ?sd!! 5gh. s!               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string value = "?sd!! 5gh.s!";
            int result = 5;

            Console.WriteLine($" Исходная строка = " + value);
            Console.WriteLine($" Искомая буква, которую нужно удалить = " + result);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Результат = " + ds.ConvertStringToInt(value));

            Console.ReadKey();
        }
    }
}
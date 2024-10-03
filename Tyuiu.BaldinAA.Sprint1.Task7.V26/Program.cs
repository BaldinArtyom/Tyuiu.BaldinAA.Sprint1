using Tyuiu.BaldinAA.Sprint1.Task7.V26.Lib;
namespace Tyuiu.BaldinAA.Sprint1.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Балдин А. А. | ИБКСб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Балдин А. А. | ИБКСб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает задачу про минуты и часы,            *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("          2");
            Console.WriteLine("      sinx  +   y           xy  -  12");
            Console.WriteLine(" z = -------------   -     -----------");
            Console.WriteLine("        y  +  1                    2");
            Console.WriteLine("                          34  +  x");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");

            double x,y;

            Console.WriteLine("* Введите число значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("* Введите число значение Y:");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x,y));
        }
    }
}

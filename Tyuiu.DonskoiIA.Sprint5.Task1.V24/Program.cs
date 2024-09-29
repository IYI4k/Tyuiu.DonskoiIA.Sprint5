using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint5.Task1.V24.Lib;

namespace Tyuiu.DonskoiIA.Sprint5.Task1.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Донской И. А. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая получает от пользователя промежуток         *");
            Console.WriteLine("* значений, которые она подставит в формулу и полученные значения запишет *");
            Console.WriteLine("* в файл, после чего выведит путь к этому файлу на экран.                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                          3cos(x)                                        *");
            Console.WriteLine("*                     y = --------- + sin(x) - 5x - 2                     *");
            Console.WriteLine("*                          4x-0.5                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int start;

            Console.WriteLine("Введите начало промежутка:");
            start = int.Parse(Console.ReadLine());

            int end;

            Console.WriteLine("Введите конец промежутка:");
            end = int.Parse(Console.ReadLine()) + 1;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Файл: " + ds.SaveToFileTextData(start, end));
            Console.WriteLine("Создан!");

            Console.ReadLine();
        }
    }
}
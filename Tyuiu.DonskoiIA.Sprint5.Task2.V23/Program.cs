using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint5.Task2.V23.Lib;

namespace Tyuiu.DonskoiIA.Sprint5.Task2.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Донской И. А. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая получает от пользователя двумерный массив   *");
            Console.WriteLine("* чисел 3 на 3, заменяет нечётные значения на 0, записывает новую матрицу *");
            Console.WriteLine("* в файл с названием \"OutPutFileTask2.csv\", после чего выводит путь к   *");
            Console.WriteLine("* этому файлу на экран.                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[3, 3];

            Console.WriteLine("Введите матрицу 3 на 3, разделитель между столбами - ';':");
            
            for (int i = 0; i < 3; i++)
            {
                string[] t = Console.ReadLine().Split(';');

                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(t[j]);
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Файл: " + ds.SaveToFileTextData(matrix));
            Console.WriteLine("Создан!");

            Console.ReadLine();
        }
    }
}
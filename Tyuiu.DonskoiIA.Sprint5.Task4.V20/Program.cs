﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DonskoiIA.Sprint5.Task4.V20.Lib;

namespace Tyuiu.DonskoiIA.Sprint5.Task4.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Донской И. А. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Донской Иван Андреевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая получает от пользователя путь к файлу,      *");
            Console.WriteLine("* получает значение для X, вычисляет формулу и выводит полученный         *");
            Console.WriteLine("* результат на экран                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                          x^2                                            *");
            Console.WriteLine("*                       (--------)^3                                      *");
            Console.WriteLine("*                         sin(x)                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path;

            Console.WriteLine("Введите путь к файлу:");

            path = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.LoadFromDataFile(path));
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkOleg.General
{
    class Homework2_Operation
    {
        public static void StartHomework2_Operation()
        {
            {
                Console.WriteLine("ДОМАШКА");
                Console.WriteLine("1 - Задача 1");
                Console.WriteLine("2 - Задача 2");
                Console.WriteLine("3 - Задача 3");
                Console.Write("---> ");
                string usersChoice = Console.ReadLine();

                if (usersChoice == "1")
                {
                    Start1();

                }
                else if (usersChoice == "2")
                {
                    Start2();
                }
                else if (usersChoice == "3")
                {
                    Start3();
                }
                else
                {
                    Console.WriteLine("Алло");
                }
            }
        }
        public static void Start1()
        {
            Console.WriteLine("Какое число больше?");
            Console.Write("Введите число 1: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число 2: ");
            int y = Convert.ToInt32(Console.ReadLine());

            string operation = Console.ReadLine();

            if (x == y)
            {
                Console.Write("РАВНЫ");
            }
            else if (x < y)
            {
                Console.Write($"result of {x} < {y} = {y}");
            }
            else
            {
                Console.Write($"result of {x} > {y} = {x}");

            }
        }
        public static void Start2()
        {
            Console.WriteLine("Пренадлежит ли число диапазону от 0 до 100?");
            Console.Write("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());


            if (x > 0 && x < 100)
            {
                Console.WriteLine($"result of {x} > 0 && {x} < 100");
            }
            else if (x > 100)
            {
                Console.WriteLine("GG");
            }
        }
        public static void Start3()
        {
            string cordXStr;
            string cordYStr;

            Console.WriteLine("к какой четверти относяться координаты ");

            Console.Write("введите координату х: ");
            cordXStr = Console.ReadLine();

            Console.Write("введите кординаты у: ");
            cordYStr = Console.ReadLine();

            int cordX = Convert.ToInt32(cordXStr);
            int cordY = Convert.ToInt32(cordYStr);

            if (cordX > 0 && cordY > 0)
            {
                Console.Write("2");
            }
            else if (cordX < 0 && cordY < 0)
            {
                Console.Write("3");
            }
            else if (cordX < 0 && cordY > 0)
            {
                Console.Write("2");
            }
            else if (cordX > 0 && cordY < 0)
            {
                Console.Write("4");
            }
        }
    }
}



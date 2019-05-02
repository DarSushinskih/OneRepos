﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СastleOpen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Открой замок!");
            Console.WriteLine("Для того что бы подобрать замок, вы должы подоборать числа только к остальным значениям ячеек!");
            Random rnd = new Random();
            Dictionary<int, int> Castle = new Dictionary<int, int> { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, 
                                { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 }, { 10, 0 }};
            Castle[rnd.Next(1, 11)] = rnd.Next(1, 7);
            Castle[rnd.Next(1, 11)] = rnd.Next(1, 7);

            foreach (var x in Castle)
            {
                Console.WriteLine(x.Key.ToString() + ". = " + x.Value.ToString());
            }

            Console.WriteLine("Теперь по очерёдно вводите значения ячеек от 1 до 6:");

            for (int i = 1; i < Castle.Count + 1; i++)
            {
                vvod:
                if (Castle[i] != 0) continue;
                Console.WriteLine("Введите значение для ячейки №" + i + ":");
                int input = -1;
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Не верно введено значение!");
                    goto vvod;
                }
                if (input < 1 || input > 7)
                {
                    Console.WriteLine("Не верно введено значение!");
                    goto vvod;
                }
                Castle[i] = input;
            }
            Console.WriteLine("Замок имеет вид: ");
            foreach (var x in Castle)
            {
                Console.WriteLine("№" + x.Key + " = " + x.Value);
            }


            if (SeachWin(Castle))
            {
                Console.WriteLine("Поздравляю! Вы открыли замок!");
            }
            else
            {
                Console.WriteLine("Увы! В другой раз =(");
            }

            Console.ReadLine();
        }

        private static bool SeachWin(Dictionary<int, int> castle)
        {
            int result = 0;
            for (int i = 3; i < 11; i++)
            {
                result = castle[i] + castle[i - 1] + castle[i - 2];
                if (result == 10) return true;
                else result = 0;
            }
            return false;
        }
    }
}
//do
            //{
            //    Console.WriteLine("Для этого выберите первый номер, соответствующий номеру ячейки:");
            //    Console.WriteLine("1.\t2.\t3.\t4.\t5.\t6.\t7.\t8.\t9.\t10.");
            //    try
            //    {
            //        number1 = Convert.ToInt32(Console.ReadLine());
            //        if (number1 < 1 || number1 > 11) Console.WriteLine("Не верно введено значение!");
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Не верно введено значение!");
            //    }

            //} while (number1 < 1 || number1 > 11);

            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Теперь установите значиние от 1 до 6 у выбранной ранее ячейки");
            //        value1 = Convert.ToInt32(Console.ReadLine());
            //        if (value1 < 1 || value1 > 7) Console.WriteLine("Не верно введено значение!");     
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("Не верно введено значение!");
            //    }
                       
            //} while (value1 < 1 || value1 > 7);

            //do
            //{
            //    Console.WriteLine("Теперь выберите номер второй ячейки, соответствующий номеру ячейки:");
            //    Console.WriteLine("1.\t2.\t3.\t4.\t5.\t6.\t7.\t8.\t9.\t10.");
            //    try
            //    {
            //        number1 = Convert.ToInt32(Console.ReadLine());
            //        if (number1 < 1 || number1 > 11) Console.WriteLine("Не верно введено значение!");
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Не верно введено значение!");
            //    }

            //} while (number1 < 1 || number1 > 11);

            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Теперь установите значиние от 1 до 6 у выбранной ранее ячейки");
            //        value1 = Convert.ToInt32(Console.ReadLine());
            //        if (value1 < 1 || value1 > 7) Console.WriteLine("Не верно введено значение!");     
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("Не верно введено значение!");
            //    }
                       
            //} while (value1 < 1 || value1 > 7);
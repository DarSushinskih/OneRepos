﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÑastleOpen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Открой замок!!");
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
                Console.WriteLine("Ââåäèòå çíà÷åíèå äëÿ ÿ÷åéêè ¹" + i + ":");
                int input = -1;
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Íå âåðíî ââåäåíî çíà÷åíèå!");
                    goto vvod;
                }
                if (input < 1 || input > 7)
                {
                    Console.WriteLine("Íå âåðíî ââåäåíî çíà÷åíèå!");
                    goto vvod;
                }
                Castle[i] = input;
            }
            Console.WriteLine("Çàìîê èìååò âèä: ");
            foreach (var x in Castle)
            {
                Console.WriteLine("¹" + x.Key + " = " + x.Value);
            }


            if (SeachWin(Castle))
            {
                Console.WriteLine("Ïîçäðàâëÿþ! Âû îòêðûëè çàìîê!");
            }
            else
            {
                Console.WriteLine("Óâû! Â äðóãîé ðàç =(");
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

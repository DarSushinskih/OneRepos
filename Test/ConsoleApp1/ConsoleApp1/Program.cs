using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Открой замок!");
            Console.WriteLine("Для того что бы подобрать замок, вы должы подоборать числа только к остальным значениям ячеек!");
            Random rnd = new Random();                                                                              //1 
            Dictionary<int, int> Castle = new Dictionary<int, int> { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 },        //2
                                { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 }, { 10, 0 }};
            Castle[rnd.Next(1, 11)] = rnd.Next(1, 7);
            Castle[rnd.Next(1, 11)] = rnd.Next(1, 7);

            foreach (var x in Castle)                                                                           //3
            {
                Console.WriteLine(x.Key.ToString() + ". = " + x.Value.ToString());                              //4 
            }

            Console.WriteLine("Теперь по очерёдно вводите значения ячеек от 1 до 6:");
                
            
            for (int i = 1; i < Castle.Count + 1; i++)                                                       //5 
            {
            vvod:                                                                                  //6
            if (Castle[i] != 0) continue;
            Console.WriteLine("Введите значение для ячейки №" + i + ":");                         
            int input = -1;
            try                                                                                  //7
            {
                  input = Convert.ToInt32(Console.ReadLine());                                    //8
            }
            catch (Exception e)                                                                 //9
            {
            Console.WriteLine("Не верно введено значение!");                                //10
            goto vvod;
            }
            if (input < 1 || input >= 7)                                                        //11
            {
            Console.WriteLine("Не верно введено значение!");                                //12
            goto vvod;
            }
            Castle[i] = input;                                                               //13
            }
              
            Console.WriteLine("Замок имеет вид: ");

            foreach (var x in Castle)                                                           //14
            {
                Console.WriteLine("№" + x.Key + " = " + x.Value);                               //15
            }


            if (SeachWin(Castle))                                                               //16
            {
                Console.WriteLine("Поздравляю! Вы открыли замок!");                             //17
            }
            else                                                                                //18
            {
                Console.WriteLine("Увы! В другой раз =(");                                      //19
            }

            Console.ReadLine();                                                                 //20                                                          
        }                                                           

        public static bool SeachWin(Dictionary<int, int> castle)                              //21
        {
            int result = 0;                                                                     //22
            for (int i = 3; i < 11; i++)                                                        //23
            {
                result = castle[i] + castle[i - 1] + castle[i - 2];                                //24-26
                if (result == 10) return true;      
                else result = 0;
            }
            return false; 
        }
    }
}

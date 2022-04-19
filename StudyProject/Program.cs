using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String code
            //string a = "My";
            //string b = "study work";
            //Console.WriteLine("1: {0} {1}"  , a , b);
            //Console.ReadKey();
            #endregion String code

            #region Triangle 1 simple
            //string symbol = "*";

            //Console.Write("Введите высоту треугольника: ");
            //int hight = int.Parse(Console.ReadLine());

            //for (int currentRow = 0; currentRow < hight; currentRow++)
            //{
            //    for (int symbolFillengLine = hight; symbolFillengLine > currentRow; symbolFillengLine--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int symbolFillengLine = 0; symbolFillengLine <= currentRow; symbolFillengLine++)
            //    {
            //        Console.Write(symbol);

            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion Triangle 1 simple

            #region Triangle 2 cursor to a specific position
            string symbol = "* ";  // Пробел добавлено, так как смещать мы можем только на дискретный шаг символа

            Console.Write("Введите высоту треугольника: ");
            int hight = int.Parse(Console.ReadLine());

            for (int currentRow = 0; currentRow < hight; currentRow++)
            {
                Console.SetCursorPosition((Console.WindowWidth / 2 - currentRow), currentRow + 2);       // Смещать мы можем только на дискретный шаг символа
                for (int symbolFillengLine = 0; symbolFillengLine <= currentRow; symbolFillengLine++)
                {
                    Console.Write(symbol);
                }
            }
            Console.ReadKey();
            #endregion Triangle 2 cursor to a specific position



        }
    }
}

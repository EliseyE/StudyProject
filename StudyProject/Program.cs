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

            //string symbol = "* ";  // Пробел добавлен, так как смещать мы можем только на дискретный шаг символа

            //Console.Write("Введите высоту треугольника: ");
            //int hight = int.Parse(Console.ReadLine());

            //for (int currentRow = 0; currentRow < hight; currentRow++)
            //{
            //    Console.SetCursorPosition((Console.WindowWidth / 2 - currentRow), currentRow + 2);       // Смещать мы можем только на дискретный шаг символа
            //    for (int symbolFillengLine = 0; symbolFillengLine <= currentRow; symbolFillengLine++)
            //    {
            //        Console.Write(symbol);
            //    }
            //}
            //Console.ReadKey();
            #endregion Triangle 2 cursor to a specific position

            #region Array 1

            //int[] myArray = new int[5];

            //myArray[0] = 1;
            //myArray[1] = 2;
            //myArray[2] = 3;
            //myArray[3] = 4;
            //myArray[4] = 5;

            //Console.WriteLine(myArray.Length);
            //Console.ReadKey();

            #endregion Array 1

            #region Array 2

            //Console.Write("Введите количество элементов массива:\t");

            //int elementsCount = int.Parse(Console.ReadLine());

            //int[] myArray = new int[elementsCount];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write($"Введите элемент массива под индексом {i}:\t");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Вывод массива");

            //for (int i = myArray.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(myArray[i]);

            //}
            //Console.ReadLine();

            #endregion Array 2

            #region Pascal Triangle

            string messageInputSizePascalTriangle = "Введите размер треугольника Паскаля:";
            Console.Write($"{messageInputSizePascalTriangle} ");

            int pascalTriangleSize = int.Parse(Console.ReadLine());

            int[] pascalTriangleRow = new int[pascalTriangleSize];                  
            int[] tempArray = new int[pascalTriangleSize];
            int lenght = 0;
                              
            for (int rowNumber = 0; rowNumber < pascalTriangleSize; rowNumber++)
            {
                tempArray = pascalTriangleRow;
                pascalTriangleRow = Enumerable.Repeat(0, pascalTriangleSize).ToArray();
                Console.SetCursorPosition((Console.WindowWidth / 2) - lenght / 2, rowNumber + 3);
                lenght = 0;

                for (int rowValueNumber = 0; rowValueNumber <= rowNumber; rowValueNumber++)
                {
                    if ((rowValueNumber == 0 | rowValueNumber == rowNumber))
                    {
                        pascalTriangleRow[rowValueNumber] = 1;
                    }
                    else
                    {
                        pascalTriangleRow[rowValueNumber] = tempArray[rowValueNumber - 1] + tempArray[rowValueNumber];
                    }
                    
                    Console.Write($"{pascalTriangleRow[rowValueNumber], 7}");
                    //считаем длину строки 
                    lenght = lenght + $"{pascalTriangleRow[rowValueNumber], 7}".Length;
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            #endregion Pascal Triangle
            
            









        }
    }
}

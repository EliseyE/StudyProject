using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyFunctionsMethods
{
    internal class Program
    {
        //Methods
        #region Functions and Methods 1
        //static void PrintResult(int result)
        //{
        //    Console.WriteLine("Результат сложения: " + result);
        //}

        //static int Sum(int a, int b)
        //{
        //    int result = a + b;

        //    return result;

        //    //return a + b;

        //}

        //static int Sum(int a, int b, int c)
        //{
        //    int result = a + b + c;

        //    return result;

            //return a + b;

        //}

        #endregion Functions and Methods 1

        #region Functions and Methods 2
        //static void PrintLine(string symbol, uint symbolsCount)
        //{
        //    for (int i = 0; i < symbolsCount; i++)
        //    {
        //        Console.Write(symbol);
        //    }
        //}
        //static void PrintLineChar(char symbol, uint symbolsCount)
        //{
        //    for (int i = 0; i < symbolsCount; i++)
        //    {
        //        Console.Write(symbol);
        //    }
        //}

        #endregion Functions and Methods 2

        #region Functions and Methods 3

        //static int IndexOf(int[] array, int value)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] == value)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        //static int[] GetRandomArray(uint length, int minValue, int maxVelue)
        //{
        //    int[] myArray = new int[length];

        //    Random rdm = new Random();

        //    for (int i = 0; i < myArray.Length; i++)
        //    {
        //        myArray[i] = rdm.Next(minValue, maxVelue);
        //    }

        //    return myArray;

        //}

        #endregion Functions and Methods 3



        static void Main(string[] args)
        {

            #region Functions and Methods 1

            //int a, b, c;

            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());

            //c = Sum(a, b);

            //PrintResult(c);

            //Console.ReadKey();

            #endregion Functions and Methods 1

            #region #region Functions and Methods 2

            //Console.Write("Введите символы: ");
            //string str = Console.ReadLine();
            //PrintLine($"{str}\t", 100);


            //Console.WriteLine();
            //Console.Write("Введите один символ: ");
            //char chr = Console.ReadKey().KeyChar;
            //PrintLine($"{chr}\t", 100);

            //Console.ReadKey();

            #endregion Functions and Methods 2

            #region Functions and Methods 3

            //int[] myArray = {-345, 65, 456, 345, 45};

            //int index = IndexOf(myArray, 45);

            //Console.WriteLine(index);

            //Console.ReadKey();

            //2 Random and search

            //int[] myArray1 = GetRandomArray(1000, 4, 7000);

            //for (int i = 0; i < myArray1.Length; i++)
            //{
            //    Console.Write(myArray1[i] + "\t");
            //}

            //Random rdm1 = new Random();
            //int index = 0;
            //int search = myArray1[0];
            //int search1 = -1;

            //while(search != search1)
            //{
            //    int i = 0;
            //    for (; i < myArray1.Length; i++)
            //    {
            //        search = rdm1.Next(10, 20000);
            //        search1 = myArray1[i];

            //    }
            //}

            //index = IndexOf(myArray1, search);
            //Console.WriteLine("\nНайден: " + (index + 1) + " : " + search);

            //Console.ReadKey();

            #endregion Functions and Methods 3

            #region Functions and Methods 4 Null

            //string str = null;

            ////string result = str ?? "";

            //string result = str ??= string.Empty;

            //Console.WriteLine("Кол-во символов в строке: " + result.Length);

            //Console.ReadKey();

            #endregion Functions and Methods 4 Null


        }









    }

}

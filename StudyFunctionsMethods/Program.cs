using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyFunctionsMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////notice: All of my study tasks is written in methods in the class named Program under the method Main. It's made to simplify run in the Main of any study task only.


            ////Functions and Methods 1
            //Sum2or3values();

            ////Functions and Methods 2
            //SymbolsPrintingToConsole();

            ////Functions and Methods 3
            //FindValueInSimpleAndRandomArray();

            ////ref keyword
            //RefKeywordUse();

            //ref Task. Resize array.
            //ResizeArrayTask();

            //Add, Delet of array's elements
            //TaskEditArrayByRef();

            //out keyword
            //OutKeywordUse();

            //params keyword
            //ParamsKeywordUse();
            //ParamsKeywordUseObjectValue();

            //Recursion
            //Recursion();
            //CycleForByRecursionUse();
            //RecursionUseWithClass();

            //Task actions with array by recursion
            //TaskPrintArrayByRecursion();

            //
            TaskSumOfElementsOfNumber();




            Console.ReadKey();
        }

        #region Functions and Methods 1

        static void PrintResult(int result)
        {
            Console.WriteLine("Результат сложения: " + result);
        }

        static int Sum(int a, int b)
        {
            int result = a + b;

            return result;

            //return a + b;

        }

        static int Sum(int a, int b, int c)
        {
            int result = a + b + c;

            return result;

            //return a + b;

        }

        static void Sum2or3values()
        {
            int a, b, c, d;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            d = Sum(a, b);

            PrintResult(d);
        }

        #endregion Functions and Methods 1

        #region Functions and Methods 2

        static void PrintLine(string symbol, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol);
            }
        }

        static void PrintLineChar(char symbol, string shift, uint symbolsCount)
        {
            for (int i = 0; i < symbolsCount; i++)
            {
                Console.Write(symbol + shift);
            }
        }

        static void SymbolsPrintingToConsole()
        {
            Console.Write("Введите символы: ");
            string str = Console.ReadLine();
            PrintLine($"{str}\t", 100);

            Console.WriteLine();
            Console.Write("Введите один символ: ");
            char chr = Console.ReadKey().KeyChar;
            Console.WriteLine();
            PrintLineChar(chr, "\t", 100);
        }

        #endregion Functions and Methods 2

        #region Functions and Methods 3

        static int IndexOf(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        static int[] GetRandomArray(uint length, int minValue, int maxVelue)
        {
            int[] myArray = new int[length];

            Random rdm = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rdm.Next(minValue, maxVelue);
            }
            return myArray;
        }

        static void FindValueInSimpleAndRandomArray()
        {
            int[] myArray = { -345, 65, 456, 345, 45 };

            int index1 = IndexOf(myArray, 45);

            Console.WriteLine(index1);

            Console.ReadKey();

            //2 Random and search
            int[] myArray1 = GetRandomArray(1000, 4, 7000);

            for (int i = 0; i < myArray1.Length; i++)
            {
                Console.Write(myArray1[i] + "\t");
            }

            Random rdm1 = new Random();
            int index = 0;
            int search = myArray1[0];
            int search1 = -1;

            while (search != search1)
            {
                int i = 0;
                for (; i < myArray1.Length; i++)
                {
                    search = rdm1.Next(10, 20000);
                    search1 = myArray1[i];
                }
            }

            index = IndexOf(myArray1, search);
            Console.WriteLine("\nНайден: " + (index + 1) + " : " + search);
        }

        #endregion Functions and Methods 3

        #region ref keyword

        struct refFunctionStruct
        {
            public int a;
            public int b;
            public int c;
        }

        static void RefFunctionStructMethod(ref refFunctionStruct refFunction)
        {
            refFunction.a = 10;
            refFunction.b = 4;
            refFunction.c = 3;
        }

        static void RefFunction(ref int a)
        {
            a = 10;
        }
        static ref int RefReturnVariable(int[] numbers)
        {
            return ref numbers[0];
        }

        static void RefKeywordUse()
        {
            int a = 4;
            RefFunction(ref a);
            Console.WriteLine(a);

            refFunctionStruct refStruct = new refFunctionStruct();

            RefFunctionStructMethod(ref refStruct);

            int[] array = { 3, 4, 6 };

            ref int b = ref array[0];

            b = 10;

            b = ref RefReturnVariable(array);
        }

        #endregion ref

        #region ref use to resize array

        static void ResizeArray(ref int[] array, int reSize)
        {
            int[] newArray = new int[reSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        static void ResizeArrayAnyType<T>(ref T[] array, int reSize)
        {
            T[] newArray = new T[reSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        static void ResizeArrayTask()
        {
            int[] array = { 2, 4, 5 };

            ResizeArray(ref array, 6);
        }

        #endregion ref use to resize array

        #region TaskEditArrayByRef

        static void InsertElementIntoArray(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index; i < array.Length; i++)
                newArray[i + 1] = array[i];

            array = newArray;
        }

        static void AddFirstElementIntoArray(ref int[] array, int value)
        {
            InsertElementIntoArray(ref array, value, 0);
        }

        static void AddLastElementIntoArray(ref int[] array, int value)
        {
            int lastArrayElementIndex = array.Length;
            InsertElementIntoArray(ref array, value, lastArrayElementIndex);
        }

        static void DeleteArrayElement(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index; i < array.Length - 1; i++)
                newArray[i] = array[i + 1];

            array = newArray;
        }

        static void DeleteFirstArrayElement(ref int[] array)
        {
            DeleteArrayElement(ref array, 0);
        }

        static void DeleteLastArrayElement(ref int[] array)
        {
            int lastArrayElementIndex = array.Length;
            DeleteArrayElement(ref array, lastArrayElementIndex);
        }

        static void TaskEditArrayByRef()
        {
            int[] myArray = { 2, 4, 5, 7, 9 };

            InsertElementIntoArray(ref myArray, 44, 0);

            AddFirstElementIntoArray(ref myArray, 100);

            AddLastElementIntoArray(ref myArray, 55);

            DeleteArrayElement(ref myArray, 6);

            DeleteFirstArrayElement(ref myArray);

            DeleteLastArrayElement(ref myArray);
        }

        #endregion TaskEditArrayByRef

        #region out keyword

        //We have to assign value if use out keyword in a method. We can not assign 
        static void AssignValueByOutKeyword(out int value)
        {
            value = 11;
        }

        static void OutKeywordUse()
        {
            ////variant 1
            //int a;
            //AssignValueByOutKeyword(out a);

            ////variant 2. C# > 6.0 give us the next code variant 
            AssignValueByOutKeyword(out int a);

            Console.WriteLine(a);
        }

        #endregion out keyword

        #region params keyword

        //Part 1
        static int SumByParams(params int[] parameters)
        {
            int result = 0;

            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }

            return result;
        }

        static void ParamsKeywordUse()
        {
            int result = SumByParams(1, 2, 4, 5);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        //Part 2
        static void DetermineInputValue(params object[] parameters)
        {
            string msg = "Тип данных {0}, значение {1}";

            foreach (var item in parameters)
            {
                Console.WriteLine(msg, item.GetType(), item);
            }
        }

        static void ParamsKeywordUseObjectValue()
        {
            DetermineInputValue("Hello", -4, 'r', 4.44f, true);
        }

        #endregion params keyword

        #region recursion

        static void Recursion()
        {
            Console.WriteLine("recursion");
            Recursion();
        }

        static void CycleForByRecursion(int i, int last)
        {
            Console.WriteLine(i);
            if (i >= last)
            {
                return;
            }

            i++;
            CycleForByRecursion(i, last);
        }

        static void CycleForByRecursionUse()
        {
            CycleForByRecursion(0, 3);
        }

        //Пример применения рекусии в практике
        class Item
        {
            public int Value { get; set; }

            //включает в себя самого себя
            public Item Child { get; set; }
        }

        static void PrintRecursion(Item item)
        {
            if (item != null)
            {
                Console.WriteLine(item.Value);
                PrintRecursion(item.Child);
            }
        }

        static Item InitItem()
        {
            return new Item()
            {
                Value = 4,
                Child = new Item()
                {
                    Value = 7,
                    Child = new Item()
                    {
                        Value = 9
                    }
                }
            };
        }

        static void RecursionUseWithClass()
        {
            Item item = InitItem();

            //by Recursion
            PrintRecursion(item);
            Console.WriteLine();

            //by for
            for (Item i = item; i != null; i = i.Child)
            {
                Console.WriteLine(i.Value);
            }
        }

        #endregion recursion

        #region Task actions with array by recursion

        static void PrintArrayByRecursion(int[] array, int index = 0)
        {
            if (index >= array.Length)
            {
                return;
            }

            Console.WriteLine(array[index]);

            index++;
            PrintArrayByRecursion(array, index);
        }

        static int SumArrayElementsByRecursion(int[] array, int index = 0)
        {
            if (index >= array.Length)
            {
                return 0;
            }

            int result = SumArrayElementsByRecursion(array, index + 1);
            return array[index] + result;
        }

        static void TaskPrintArrayByRecursion()
        {
            int[] array = { 2, 4, 5 };
            PrintArrayByRecursion(array);

            Console.WriteLine();

            int sumArrayElements = SumArrayElementsByRecursion(array);
            Console.WriteLine(sumArrayElements);
        }

        #endregion Task actions with array by recursion

        #region Task sum of elements of number

        static int SumOfElementsOfNumber(int value)
        {
            if (value < 10)
                return value;

            int digit = value % 10;

            int nextValue = value / 10;

            return digit + SumOfElementsOfNumber(nextValue);
        }

        static void TaskSumOfElementsOfNumber()
        {
            int number = 561;
            int result = SumOfElementsOfNumber(number);
            Console.WriteLine(result);
        }

        #endregion Task sum of elements of number



    }

}

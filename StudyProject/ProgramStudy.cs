using System;
using System.Globalization;
using System.Linq;

namespace StudyProject
{
    internal class ProgramStudy
    {
        static void Main(string[] args)
        {
            ////notice: All of my study tasks is written in methods in the class named Program under the method Main. It's made to simplify run in the Main of any study task only.


            //SimpleStringCode();

            //NumeralConvertion();

            //SimpleArithmeticOperations();

            //TriangleSimple();

            //TtriangleSpecificPositioningByCursor();

            //SimpleArray();

            //SimpleArrayInputDataOutputToConsole();

            //PascalTriangleWithSpecificPositioningByCursor();

            //ArraySumEvenValuesFindMinValue();

            //SimpleSwitch();

            //OddEvenCounter();

            //SimpleRectangleDrawWithSpecificPositioningByCursor();

            //MovingDotBaubleInConsoleSpace();

            //SimpleTernaryOperator();

            //Array2D();

            //JaggedArray();

            //MultiDimensionalArray();

            //TranspositionOfMatrixes();

            //MatrixMultiplication();

            //FinancialTableReport();

            //Lesson1FromEngineerSpock();

            //NullСheckThenAssignmentOperators();

            //ConditionalNull();

            //NullableTypes();

            //EnumLessonPart1();
            //EnumLessonPart2();
            //EnumLessonPart3();
            //EnumLessonPart4();

            //Lesson2FromEngineerSpock();

            int[] a = { 5, 4, 6, 2 };
            int[] b = a;
            a[0] = 99;
            
            Console.WriteLine($"{a[0]} {b[0]}");


            Console.ReadKey();

        }

        static void SimpleStringCode()
        {
            string a = "My";
            string b = "study work";
            Console.WriteLine("Вывод данных: {0} {1}", a, b);
            Console.ReadKey();
        }

        static void NumeralConvertion()
        {
            string a = "2.8";

            //NumberFormatInfo need using System.Globalization;
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double b = Convert.ToDouble(a, numberFormatInfo);

            Console.WriteLine(b);

            string str1 = "34";
            int d1 = int.Parse(str1);
            Console.WriteLine(d1);

            string str2 = "3.4";
            double d2 = double.Parse(str2, numberFormatInfo);
            Console.WriteLine(d2);

            //Отслеживание ошибоки и обработка её
            string srt3 = "3.4ddfssd";
            try
            {
                double d3 = double.Parse(srt3, numberFormatInfo);
                Console.WriteLine(d3);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка при конвертации");
            }

            Console.Write("Введите число для преобразования: ");
            string srt4 = Console.ReadLine();
            double d4;
            bool tryParseresult = double.TryParse(srt4, out d4);
            Console.WriteLine($"{d4}  {tryParseresult}");

            if (tryParseresult)
            {
                Console.WriteLine("Успешное преобразование, значение: " + d4);
            }
            else
            {
                Console.WriteLine("Неверный ввод. Введены недопустимые значения, знаки, либо разделитель - точна (вводите запятую)");
            }

            Console.ReadKey();
        }

        static void SimpleArithmeticOperations()
        {
            int a = 2;

            int b = a % 2;

            Console.WriteLine(b);

            a = ++a * a;

            Console.WriteLine(a);

            int x = 89;
            int key = 133;

            int encrypt = x ^ key;
            Console.WriteLine($"Зашифрованное число: {encrypt}");

            int decrypt = encrypt ^ key;
            Console.WriteLine($"Зашифрованное число: {decrypt}");

            Console.ReadKey();
        }

        static void TriangleSimple()
        {
            string symbol = "*";

            Console.Write("Введите высоту треугольника: ");
            int hight = int.Parse(Console.ReadLine());

            for (int currentRow = 0; currentRow < hight; currentRow++)
            {
                for (int symbolFillengLine = hight; symbolFillengLine > currentRow; symbolFillengLine--)
                {
                    Console.Write(" ");
                }
                for (int symbolFillengLine = 0; symbolFillengLine <= currentRow; symbolFillengLine++)
                {
                    Console.Write(symbol);

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void TtriangleSpecificPositioningByCursor()
        {
            string symbol = "* ";  // Пробел добавлен, так как смещать мы можем только на дискретный шаг символа

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
        }

        static void SimpleArray()
        {
            int[] myArray = new int[5];

            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            myArray[3] = 4;
            myArray[4] = 5;

            Console.WriteLine(myArray.Length);
            Console.ReadKey();
        }

        static void SimpleArrayInputDataOutputToConsole()
        {
            Console.Write("Введите количество элементов массива:\t");

            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вывод массива");

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);

            }
            Console.ReadLine();
        }

        static void PascalTriangleWithSpecificPositioningByCursor()
        {
            string messageInputSizePascalTriangle = "Введите размер треугольника Паскаля:";
            Console.Write($"{messageInputSizePascalTriangle} ");

            int pascalTriangleSize = int.Parse(Console.ReadLine());

            int[] pascalTriangleRow = new int[pascalTriangleSize];
            int[] tempArray = new int[pascalTriangleSize];
            int lenght = 0;

            for (int rowNumber = 0; rowNumber < pascalTriangleSize; rowNumber++)
            {
                tempArray = pascalTriangleRow;

                //Enumerable.Repeat(0, pascalTriangleSize).ToArray() need using System.Linq;
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

                    Console.Write($"{pascalTriangleRow[rowValueNumber],7}");
                    //считаем длину строки 
                    lenght = lenght + $"{pascalTriangleRow[rowValueNumber],7}".Length;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void ArraySumEvenValuesFindMinValue()
        {
            int[] Array1 = { 12, 21, 34, 4, 57, 63, 74 };

            int sumEvenValues = 0;

            for (int i = 0; i < Array1.Length; i++)
            {
                if (Array1[i] % 2 == 0)
                {
                    sumEvenValues += Array1[i];
                }
            }
            Console.WriteLine(sumEvenValues);

            int minValue = Array1[0];

            for (int i = 1; i < Array1.Length; i++)
            {
                if (Array1[i] < minValue)
                {
                    minValue = Array1[i];
                }
            }
            Console.WriteLine(minValue);

            Console.ReadKey();
        }

        static void SimpleSwitch()
        {
            string switchString = "Min";

            switch (switchString)
            {
                case "Min":
                    Console.WriteLine("MIN!!!");
                    break;
                default:
                    Console.WriteLine("Отмена!");
                    break;
            }

            ConsoleKey consoleKey = Console.ReadKey().Key;

            //Пишем switch и нажать Tab 2 раза, при появлении активного поля!!

            switch (consoleKey)
            {
                case ConsoleKey.Backspace:
                    break;
                case ConsoleKey.Tab:
                    break;
                case ConsoleKey.Clear:
                    break;
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.Pause:
                    break;
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.Spacebar:
                    Console.WriteLine("\nПробел!");
                    break;
                case ConsoleKey.PageUp:
                    break;
                case ConsoleKey.PageDown:
                    break;
                case ConsoleKey.End:
                    break;
                case ConsoleKey.Home:
                    break;
                case ConsoleKey.LeftArrow:
                    break;
                case ConsoleKey.UpArrow:
                    break;
                case ConsoleKey.RightArrow:
                    break;
                case ConsoleKey.DownArrow:
                    break;

                default:
                    Console.WriteLine("\nНажата кнопка не из списка");
                    break;
            }

            Console.ReadKey();
        }

        static void OddEvenCounter()
        {
            int oddNumbercounter = 0;
            int evenNumbercounter = 0;

            int sumOddNumbers = 0;
            int sumEvenNumbers = 0;

            Console.Write("Введине начало диапазона:\t");
            int currentValue = int.Parse(Console.ReadLine());
            Console.Write("Введине конец диапазона:\t");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue != 0)
                {
                    if (currentValue % 2 == 0)
                    {
                        evenNumbercounter++;
                        sumEvenNumbers += currentValue;
                    }
                    else
                    {
                        oddNumbercounter++;
                        sumOddNumbers += currentValue;
                    }
                }
                currentValue++;
            }

            Console.WriteLine("\nКоличество нечётных чисел: " + oddNumbercounter);
            Console.WriteLine("Сумма нечётных чисел: " + sumOddNumbers);
            Console.WriteLine("\nКоличество чётных чисел: " + evenNumbercounter);
            Console.WriteLine("Сумма чётных чисел: " + sumEvenNumbers);

            Console.ReadKey();
        }

        static void SimpleRectangleDrawWithSpecificPositioningByCursor()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2, i + 1);

                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || i == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (j == 1 || j == 5)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void MovingDotBaubleInConsoleSpace()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, 5);
            Console.WriteLine("Используйте стрелки для перемещения");

            ConsoleKey consoleKey = Console.ReadKey().Key;
            Console.SetCursorPosition(Console.WindowWidth / 2, 1);
            string bauble = "*";
            int y = 1;
            int x = 1;
            // Нужно делать прерывание при нажатии на кливишу, защиту от залипания, или счётчик нажатий. Возможно использовать струтуру ветвления.
            //Дальнейшее развитие: игра Змейка, рисовалка. Для начала надо научить рисовать.

            while (true)
            {
                System.Threading.Thread.Sleep(100);
                consoleKey = Console.ReadKey().Key;

                if (consoleKey != 0)
                {
                    Console.Clear();
                }
                if (consoleKey == ConsoleKey.Escape)
                {
                    break;
                }

                switch (consoleKey)
                {
                    case ConsoleKey.DownArrow:
                        y++;
                        break;

                    case ConsoleKey.UpArrow:
                        y--;
                        break;

                    case ConsoleKey.RightArrow:
                        x++;
                        break;

                    case ConsoleKey.LeftArrow:
                        x--;
                        break;

                }
                if (consoleKey != 0)  //Чтобы постоянно не рисовало на одном и том же месте
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 + x, y);
                    Console.Write(bauble);
                    consoleKey = ConsoleKey.W;      //someting wrong. I need to assign to consoleKey Key "W"
                }
            }
            Console.SetCursorPosition(Console.WindowWidth / 2, 5);
            Console.WriteLine("..::GAME OVER::..");

            Console.ReadKey();
        }

        static void SimpleTernaryOperator()
        {
            int a = 0;
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            a = b == c ? 70 : 99;
            Console.WriteLine(a);

            Console.ReadKey();
        }

        static void Array2D()
        {
            //1
            int[,] myArray;
            myArray = new int[3, 5]
            {
                {1, 4, 6, 7, 8 },
                {45, 65, 4, 65, 55},
                {434, 545, 33, 5, 9}
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(myArray[i, j] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //2
            foreach (var item in myArray)
            {
                Console.Write(item + "\t ");
            }
            Console.WriteLine();

            //3
            int hight = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            Console.WriteLine($"{myArray.GetLength(0)} x {myArray.GetLength(1)}");
            Console.WriteLine();

            for (int y = 0; y < hight; y++)
            {

                for (int x = 0; x < width; x++)
                {
                    Console.Write(myArray[y, x] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //4
            int[,] myArrayFilling = new int[3, 2];

            int hight1 = myArrayFilling.GetLength(0);
            int width1 = myArrayFilling.GetLength(1);

            for (int y = 0; y < hight1; y++)
            {

                for (int x = 0; x < width1; x++)
                {
                    Console.Write($"Введите значение ячейки массива номер {y}, {x} (y, x): ");
                    myArrayFilling[y, x] = int.Parse(Console.ReadLine());

                }
            }

            for (int y = 0; y < hight1; y++)
            {

                for (int x = 0; x < width1; x++)
                {
                    Console.Write(myArrayFilling[y, x] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //5

            int[,] myArrayRandom = new int[10, 6];

            int hight2 = myArrayRandom.GetLength(0);
            int width2 = myArrayRandom.GetLength(1);

            Random rdm = new Random();

            for (int y = 0; y < hight2; y++)
            {

                for (int x = 0; x < width2; x++)
                {
                    myArrayRandom[y, x] = rdm.Next(1, 155);

                }
            }

            for (int y = 0; y < hight2; y++)
            {

                for (int x = 0; x < width2; x++)
                {
                    Console.Write(myArrayRandom[y, x] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        static void JaggedArray()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[10];
            jaggedArray[1] = new int[2];
            jaggedArray[2] = new int[12];

            int height = jaggedArray.GetLength(0);
            int width;

            Random rdm = new Random();

            for (int y = 0; y < height; y++)
            {
                width = jaggedArray[y].GetLength(0);

                for (int x = 0; x < width; x++)
                {
                    jaggedArray[y][x] = rdm.Next(7, 5555);
                }
            }

            for (int y = 0; y < height; y++)
            {
                width = jaggedArray[y].GetLength(0);

                for (int x = 0; x < width; x++)
                {
                    Console.Write(jaggedArray[y][x] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadKey();
        }

        static void MultiDimensionalArray()
        {
            //int[,,,] multiArray =
            //{
            //    {
            //        {   {2, 4, 3},          //example of 4d array initialization
            //            {45,45,33}
            //        },

            //        {   {2, 4, 3},
            //            {45,45,33}
            //        },

            //        {   {2, 4, 3},
            //            {45,45,33}
            //        },
            //    },

            //    {
            //        {   {2, 4, 3},
            //            {45,45,33}
            //        },

            //        {   {2, 4, 3},
            //            {45,45,33}
            //        },

            //        {   {2, 4, 3},
            //            {45,45,33}
            //        }
            //    }
            //};

            Random rnd = new Random();
            Console.Write("Введите количество элементов первого измерения массива: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите количество элементов второго измерения массива: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите количество элементов третьего измерение измерения массива: ");
            int c = int.Parse(Console.ReadLine());

            int[,,] multiArray = new int[a, b, c];

            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    for (int k = 0; k < multiArray.GetLength(2); k++)
                    {
                        multiArray[i, j, k] = rnd.Next(1, 800);
                    }
                }
            }

            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                Console.WriteLine("Page №:" + (i + 1));
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    for (int k = 0; k < multiArray.GetLength(2); k++)
                    {
                        Console.Write(multiArray[i, j, k] + "\t");


                    }
                    Console.WriteLine();
                }
                Console.WriteLine("= = = = = = = = = = = = = = = =");
            }

            Console.ReadKey();
        }

        static void TranspositionOfMatrixes()
        {
            Console.WriteLine("Операция транспонирования матрицы");
            Console.Write("Введите количество строк матрицы А: ");
            int aMatrixRows = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов матрицы А: ");
            int aMatrixColumns = int.Parse(Console.ReadLine());

            int[,] aMatrix = new int[aMatrixRows, aMatrixColumns];

            Random rdm = new Random();

            for (int i = 0; i < aMatrixRows; i++)
            {
                for (int j = 0; j < aMatrixColumns; j++)
                {
                    aMatrix[i, j] = rdm.Next(1, 10);
                }
            }

            Console.WriteLine($"\nМатрица А {aMatrixRows} х {aMatrixColumns}:\n");
            for (int i = 0; i < aMatrixRows; i++)
            {
                for (int j = 0; j < aMatrixColumns; j++)
                {
                    Console.Write(aMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int aMatrixTcolumns = aMatrix.GetLength(0);      //кол-во столбцов
            int aMatrixTrows = aMatrix.GetLength(1);        //кол-во строк
            int[,] aMatrixT = new int[aMatrixTrows, aMatrixTcolumns];

            for (int i = 0; i < aMatrixTrows; i++)
            {
                for (int j = 0; j < aMatrixTcolumns; j++)
                {
                    aMatrixT[i, j] = aMatrix[j, i];
                }
            }

            Console.WriteLine($"\nМатрица А {aMatrixTrows} х {aMatrixTcolumns} транспонированная:\n");
            for (int i = 0; i < aMatrixTrows; i++)
            {
                for (int j = 0; j < aMatrixTcolumns; j++)
                {
                    Console.Write(aMatrixT[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void MatrixMultiplication()
        {

            Console.WriteLine("Умножение матриц. Матрицы должны быть согласованы (количество столбцов матрицы A долно быть равно количеству строк матрицы B!");
            while (true)
            {
                //Multiply of matrixes

                //Solid values matrix A variant
                //int[,] aMatrix = new int[,] { { 1, 3, 5, 2 }, { 2, 4, 6, 4 }, { 1, 3, 4, 2 } };
                //int aMatrixRows = aMatrix.GetLength(0);
                //int aMatrixColumns = aMatrix.GetLength(1);

                //Adjustable matrix A variant with ramdom values
                Console.Write("Введите количество строк матрицы А:\t");
                int aMatrixRows = int.Parse(Console.ReadLine());
                Console.Write("Введите количество столбцов матрицы А:\t");
                int aMatrixColumns = int.Parse(Console.ReadLine());

                int[,] aMatrix = new int[aMatrixRows, aMatrixColumns];

                Random rdm = new Random();

                for (int i = 0; i < aMatrixRows; i++)
                {
                    for (int j = 0; j < aMatrixColumns; j++)
                    {
                        aMatrix[i, j] = rdm.Next(1, 10);
                    }
                }

                Console.WriteLine($"\nМатрица А {aMatrixRows} х {aMatrixColumns}:\n");
                for (int i = 0; i < aMatrixRows; i++)
                {
                    for (int j = 0; j < aMatrixColumns; j++)
                    {
                        Console.Write(aMatrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                //Solid values matrix B variant
                //int[,] bMatrix = new int[,] { { 7, 4 , }, { 2, 1 }, { 5, 3 } };
                //int bMatrixRows = bMatrix.GetLength(0);
                //int bMatrixColumns = bMatrix.GetLength(1);

                //Adjustable matrix B variant with ramdom values
                Console.WriteLine();
                Console.Write("Введите количество строк матрицы B:\t");
                int bMatrixRows = int.Parse(Console.ReadLine());
                Console.Write("Введите количество столбцов матрицы B:\t");
                int bMatrixColumns = int.Parse(Console.ReadLine());

                int[,] bMatrix = new int[bMatrixRows, bMatrixColumns];

                for (int i = 0; i < bMatrixRows; i++)
                {
                    for (int j = 0; j < bMatrixColumns; j++)
                    {
                        bMatrix[i, j] = rdm.Next(1, 10);
                    }
                }

                Console.WriteLine($"\nМатрица B {bMatrixRows} х {bMatrixColumns}:\n");
                for (int i = 0; i < bMatrixRows; i++)
                {
                    for (int j = 0; j < bMatrixColumns; j++)
                    {
                        Console.Write(bMatrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                //Multiplication of matrix B and matrix B
                int[,] abMultiplyMatrix = new int[aMatrixRows, bMatrixColumns];
                int abMultiplyMatrixRows = abMultiplyMatrix.GetLength(0);
                int abMultiplyMatrixColumns = abMultiplyMatrix.GetLength(1);

                if (aMatrixColumns == bMatrixRows)
                {
                    for (int currentRow = 0; currentRow < abMultiplyMatrixRows; currentRow++)
                    {
                        for (int currentColumn = 0; currentColumn < abMultiplyMatrixColumns; currentColumn++)
                        {
                            for (int k = 0; k < aMatrixColumns; k++)
                            {
                                abMultiplyMatrix[currentRow, currentColumn] = abMultiplyMatrix[currentRow, currentColumn] + (aMatrix[currentRow, k] * bMatrix[k, currentColumn]);
                            }
                        }
                    }

                    Console.WriteLine($"\nМатрица результат умножения матрицы А и матрицы B размер {abMultiplyMatrixRows} х {abMultiplyMatrixColumns} :\n");
                    for (int i = 0; i < abMultiplyMatrixRows; i++)
                    {
                        for (int j = 0; j < abMultiplyMatrixColumns; j++)
                        {
                            Console.Write(abMultiplyMatrix[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }

                else
                {
                    Console.WriteLine("\nМатрицы не согласованы (количество столбцов матрицы A не равно количеству строк матрицы B! Умножение невозможно!");
                }

                //if () //дописать, если потребуется сделать выход из бесконечного цикла
                //{
                //    break;
                //}
                Console.WriteLine("===================");
                Console.WriteLine();
            }

        }

        static void FinancialTableReport()
        {
            string[] haederArray = new string[4] { "Месяц", "Выручка", "Издержки", "Прибыль" };
            int[] monthsArray = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] revenueArray = new int[12] { 10, 60, 15, 25, 15, 78, 22, 44, 1, 33, 80, 44 };
            int[] costsArray = new int[12] { 26, 10, 20, 10, 5, 45, 14, 22, 5, 3, 38, 25 };
            int[] profitArray = new int[12];

            for (int i = 0; i < monthsArray.Length; i++)
            {
                profitArray[i] = revenueArray[i] - costsArray[i];
            }

            int[][] summaryArray = new int[12][];
            summaryArray[0] = monthsArray;
            summaryArray[1] = revenueArray;
            summaryArray[2] = costsArray;
            summaryArray[3] = profitArray;

            int summaryLength0 = summaryArray.GetLength(0);
            int summaryLength1 = haederArray.GetLength(0);

            for (int i = 0, lenghtHeader = 17; i < summaryLength1; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth / 3 + lenghtHeader / 2), 1);
                Console.Write(haederArray[i]);
                lenghtHeader = lenghtHeader + 20;

            }
            Console.WriteLine();

            for (int i = 0; i < summaryLength0; i++)
            {
                for (int j = 0, lenghtData = 20; j < summaryLength1; j++)
                {
                    Console.SetCursorPosition((Console.WindowWidth / 3 + lenghtData / 2), 2 + i);
                    Console.Write(summaryArray[j][i]);
                    lenghtData = lenghtData + 20;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Положительная прибыль была в месяцах: ");

            for (int i = 0; i < summaryLength0; i++)
            {
                if (summaryArray[3][i] > 0)
                {
                    Console.Write($"{i + 1}, ");
                }
            }

            Console.ReadKey();
        }

        static void Lesson1FromEngineerSpock()
        {
            //защита от переполнерия. Использовать checked, будет выпадать ошибка, программа упадёт
            //Но надо писать код так, чтобы не было переполнений. Просто если очень важно там, жизненно.6

            checked
            {
                //код
            }

            int x = 1;

            x = x++ + x;
            Console.WriteLine($"Постфиксное значение: {x}");

            x = 1;

            x = ++x + x;
            Console.WriteLine($"Префиксное значение: {x}");

            Console.ReadKey();
        }

        static void NullСheckThenAssignmentOperators()
        {
            //Сheck and then assign default value
            string str1 = null;
            string result1 = str1 ?? "na data";
            Console.WriteLine(result1);
            Console.WriteLine();

            //Сheck and then assign default value without exception 1
            string str2 = null;
            string result2 = str2 ?? "";
            Console.WriteLine("Кол-во символов в строке: " + result2.Length);
            Console.WriteLine();

            //Сheck and then assign default value without exception 2. Better use this variant
            string str3 = null;
            string result3 = str3 ?? string.Empty;
            Console.WriteLine("Кол-во символов в строке: " + result3.Length);
            Console.WriteLine();

            //Сheck and then assign default value in one time for origin variable without exception
            //need to  write in the project file configuration < LangVersion > 8.0 </ LangVersion >
            string str4 = null;
            //str4 ??= string.Empty;
            str4 ??= "default value";
            Console.WriteLine(str4);
            Console.WriteLine("??= Кол-во символов в строке: " + str4.Length);

            Console.ReadKey();
        }

        static void ConditionalNull()
        {
            int[] array = { 1, 2, 3 };
            array = null;

            //if array is null, then operation Sum will not run
            Console.WriteLine("1 Сумма элементов массива: " + array?.Sum());

            //if array is null, then operation Sum will not run, but there is default value for array
            Console.WriteLine("2 Сумма элементов массива: " + (array?.Sum() ?? 0));

            Console.ReadKey();
        }

        static void NullableTypes()
        {
            int? value = null;

            Console.WriteLine(value == null);   //True

            Console.WriteLine(value.HasValue);  //False

            Console.WriteLine(value.GetValueOrDefault());   //0

            Console.WriteLine(value.GetValueOrDefault(77));  //77

            Console.WriteLine(value ?? 55); //55 оператор объединения с null

            //Console.WriteLine(value.Value); //InvalidOperationException

            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime);

            Nullable<DateTime> dateTime1 = DateTime.Now;
            //the same
            DateTime? dateTime2 = null;

            int a = 4;

            int? b = null;

            int? result = a + b;

            Console.WriteLine(result);  //null

        }

        //EnumLessonPart1
        static void EnumLessonPart1()
        {
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;

                int keyCode = (int)key;

                Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Вы нажали Enter!");
                }
            }
        }

        //EnumLessonPart2
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static DayOfWeek GetNextDay(DayOfWeek day)
        {
            if (day < DayOfWeek.Sunday)
                return day + 1;

            return DayOfWeek.Monday;
        }

        static void EnumLessonPart2()
        {
            DayOfWeek dayOfWeek = DayOfWeek.Sunday;

            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));

            Console.WriteLine(dayOfWeek);

            Console.WriteLine((int)dayOfWeek);

            Console.WriteLine((DayOfWeek)3);

            DayOfWeek nextDay = GetNextDay(dayOfWeek);
            Console.WriteLine(nextDay);

            //check for correct value enum number input
            int value = 41;

            if (Enum.IsDefined(typeof(DayOfWeek), value))
            {
                dayOfWeek = (DayOfWeek)value;
            }
            else
            {
                throw new Exception("Invalid DayOfWeek value.");
            }
            Console.WriteLine(dayOfWeek);
        }

        //EnumLessonPart3
        enum Color
        {
            White,
            Red,
            Green,
            Blue,
            Orange
        }

        //Get info about all enum values
        static void EnumLessonPart3()
        {
            var values = Enum.GetValues(typeof(Color));

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            string inputColor = Console.ReadLine();
            Color color = (Color)Enum.Parse(typeof(Color), inputColor, ignoreCase: true);
            Console.WriteLine(color);

        }

        //Parse enum values
        static void EnumLessonPart4()
        {
            string inputColor = Console.ReadLine();
            Color color = (Color)Enum.Parse(typeof(Color), inputColor, ignoreCase: true);
            Console.WriteLine(color);

            //int test = int.Parse(Console.ReadLine());
            //Console.WriteLine(test);

            switch (color)
            {
                case Color.White:
                    break;
                case Color.Red:
                    break;
                case Color.Green:
                    break;
                case Color.Blue:
                    break;
                case Color.Orange:
                    break;
                default:
                    break;
            }
        }

        static void Lesson2FromEngineerSpock()
        {
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));

            Console.WriteLine(Math.Round(1.5));
            Console.WriteLine(Math.Round(2.5));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));

            string s1 = "fihsdfg";
            char first = s1[0];
            char last = s1[s1.Length - 1];
            Console.WriteLine($"First: {first}. Last: {last}");

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            Console.WriteLine($"It's {now.Date}, {now.Hour}:{now.Minute}");

            DateTime dt = new DateTime(2016, 2, 28);
            DateTime newDt = dt.AddDays(1);
            Console.WriteLine(newDt);

            TimeSpan ts = now - dt;
            ts = now.Subtract(dt);
            Console.WriteLine(ts.Days);
        }

        


    }
}

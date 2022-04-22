using System;
using System.Collections.Generic;
using System.Globalization;
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
            //Console.WriteLine("Вывод данных: {0} {1}", a, b);
            //Console.ReadKey();

            #endregion String code

            #region Convertion

            //string a = "2.8";

            //NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            //{
            //    NumberDecimalSeparator = ".",
            //};

            //double b = Convert.ToDouble(a, numberFormatInfo);

            //Console.WriteLine(b);

            //string str1 = "34";
            //int d1 = int.Parse(str1);
            //Console.WriteLine(d1);

            //string str2 = "3.4";
            //double d2 = double.Parse(str2, numberFormatInfo);
            //Console.WriteLine(d2);

            ////Отслеживание ошибоки и обработка её
            //string srt3 = "3.4ddfssd";
            //try
            //{
            //    double d3 = double.Parse(srt3, numberFormatInfo);
            //    Console.WriteLine(d3);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Ошибка при конвертации");
            //}

            //Console.Write("Введите число для преобразования: ");
            //string srt4 = Console.ReadLine();
            //double d4;
            //bool tryParseresult = double.TryParse(srt4, out d4);
            //Console.WriteLine($"{d4}  {tryParseresult}");

            //if (tryParseresult)
            //{
            //    Console.WriteLine("Успешное преобразование, значение: " + d4);
            //}
            //else
            //{
            //    Console.WriteLine("Неверный ввод. Введены недопустимые значения, знаки, либо разделитель - точна (вводите запятую)");
            //}

            //Console.ReadKey();

            #endregion Convertion

            #region Arithmetic operations

            //int a = 2;

            //int b = a % 2;

            //Console.WriteLine(b);

            //a = ++a * a ;

            //Console.WriteLine(a);

            //int x = 89;
            //int key = 133;

            //int encrypt = x ^ key;
            //Console.WriteLine($"Зашифрованное число: {encrypt}");

            //int decrypt = encrypt ^ key;
            //Console.WriteLine($"Зашифрованное число: {decrypt}");

            //Console.ReadKey();

            #endregion Arithmetic operations

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

            //string messageInputSizePascalTriangle = "Введите размер треугольника Паскаля:";
            //Console.Write($"{messageInputSizePascalTriangle} ");

            //int pascalTriangleSize = int.Parse(Console.ReadLine());

            //int[] pascalTriangleRow = new int[pascalTriangleSize];                  
            //int[] tempArray = new int[pascalTriangleSize];
            //int lenght = 0;

            //for (int rowNumber = 0; rowNumber < pascalTriangleSize; rowNumber++)
            //{
            //    tempArray = pascalTriangleRow;
            //    pascalTriangleRow = Enumerable.Repeat(0, pascalTriangleSize).ToArray();
            //    Console.SetCursorPosition((Console.WindowWidth / 2) - lenght / 2, rowNumber + 3);
            //    lenght = 0;

            //    for (int rowValueNumber = 0; rowValueNumber <= rowNumber; rowValueNumber++)
            //    {
            //        if ((rowValueNumber == 0 | rowValueNumber == rowNumber))
            //        {
            //            pascalTriangleRow[rowValueNumber] = 1;
            //        }
            //        else
            //        {
            //            pascalTriangleRow[rowValueNumber] = tempArray[rowValueNumber - 1] + tempArray[rowValueNumber];
            //        }

            //        Console.Write($"{pascalTriangleRow[rowValueNumber], 7}");
            //        //считаем длину строки 
            //        lenght = lenght + $"{pascalTriangleRow[rowValueNumber], 7}".Length;
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            #endregion Pascal Triangle

            #region Array 3

            //int[] Array1 = { 12, 21, 34, 4, 57, 63, 74};

            //int result = 0;

            //for (int i = 0; i < Array1.Length; i++)
            //{
            //    if (Array1[i] % 2 == 0)
            //    {
            //        result += Array1[i];
            //    }
            //}
            //Console.WriteLine(result);

            //int minValue = Array1[0];

            //for (int i = 1; i < Array1.Length; i++)
            //{
            //    if (Array1[i] < minValue)
            //    {
            //        minValue = Array1[i];
            //    }
            //}
            //Console.WriteLine(minValue);

            //Console.ReadKey();

            #endregion Array 3

            #region Switch

            //string switchString = "Min";

            //switch (switchString)
            //{
            //    case "Min":
            //        Console.WriteLine("MIN!!!");
            //        break;
            //    default:
            //        Console.WriteLine("Отмена!");
            //        break;
            //}

            //ConsoleKey consoleKey = Console.ReadKey().Key;
            //switch (consoleKey)                                 //Пишет switch и Tab 2 раза!!
            //{
            //    case ConsoleKey.Backspace:
            //        break;
            //    case ConsoleKey.Tab:
            //        break;
            //    case ConsoleKey.Clear:
            //        break;
            //    case ConsoleKey.Enter:
            //        break;
            //    case ConsoleKey.Pause:
            //        break;
            //    case ConsoleKey.Escape:
            //        break;
            //    case ConsoleKey.Spacebar:
            //        Console.WriteLine("\nПробел!");
            //        break;
            //    case ConsoleKey.PageUp:
            //        break;
            //    case ConsoleKey.PageDown:
            //        break;
            //    case ConsoleKey.End:
            //        break;
            //    case ConsoleKey.Home:
            //        break;
            //    case ConsoleKey.LeftArrow:
            //        break;
            //    case ConsoleKey.UpArrow:
            //        break;
            //    case ConsoleKey.RightArrow:
            //        break;
            //    case ConsoleKey.DownArrow:
            //        break;

            //}

            //Console.ReadKey();

            #endregion Switch

            #region for(). Odd and Even nembers counter.

            //int oddNumbercounter = 0;
            //int evenNumbercounter = 0;

            //int sumOddNumbers = 0;
            //int sumEvenNumbers = 0;

            //Console.Write("Введине начало диапазона:\t");
            //int currentValue = int.Parse(Console.ReadLine());
            //Console.Write("Введине конец диапазона:\t");
            //int limit = int.Parse(Console.ReadLine()); 

            //while (currentValue <= limit)
            //{
            //    if (currentValue != 0)
            //    {
            //        if (currentValue % 2 == 0)
            //        {
            //            evenNumbercounter++;
            //            sumEvenNumbers += currentValue;
            //        }
            //        else
            //        {
            //            oddNumbercounter++;
            //            sumOddNumbers += currentValue;

            //        }
            //    }
            //    currentValue++;
            //}

            //Console.WriteLine ("\nКоличество нечётных чисел: " + oddNumbercounter);
            //Console.WriteLine("Сумма нечётных чисел: " + sumOddNumbers);
            //Console.WriteLine ("\nКоличество чётных чисел: " + evenNumbercounter);
            //Console.WriteLine("Сумма чётных чисел: " + sumEvenNumbers);

            //Console.ReadKey();

            #endregion for(). Odd and Even nembers counter.

            #region Rectangle

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.SetCursorPosition(Console.WindowWidth / 2, i + 1);

            //    for (int j = 1; j <= 5; j++)
            //    {

            //        if (i == 1 || i == 5)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            if (j == 1 || j == 5)
            //            {
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //    }
            //   Console.WriteLine();
            //}
            //Console.ReadLine();

            #endregion Rectangle

            #region Moving bauble 

            //Console.SetCursorPosition(Console.WindowWidth / 2, 5);
            //Console.WriteLine("Используйте стрелки для перемещения");

            //ConsoleKey consoleKey = Console.ReadKey().Key;
            //Console.SetCursorPosition(Console.WindowWidth / 2, 1);
            //string bauble = "*";
            //int y = 1;
            //int x = 1;
            //// Нужно делать прерывание при нажатии на кливишу, защиту от залипания, или счётчик нажатий. Возможно использовать струтуру ветвления.
            ////Дальнейшее развитие: игра Змейка, рисовалка. Для начала надо научить рисовать.

            //while (true)
            //{
            //    System.Threading.Thread.Sleep(100);
            //    consoleKey = Console.ReadKey().Key;
                
            //    if (consoleKey != 0)
            //    {
            //        Console.Clear();
            //    }
            //    if (consoleKey == ConsoleKey.Escape)
            //    {
            //        break;
            //    }

            //    switch (consoleKey)
            //    {
            //        case ConsoleKey.DownArrow:
            //            y++;
            //            break;

            //            case ConsoleKey.UpArrow:
            //            y--;
            //            break;

            //            case ConsoleKey.RightArrow:
            //            x++;
            //            break;

            //            case ConsoleKey.LeftArrow:
            //            x--;
            //            break;

            //    }
            //    if (consoleKey != 0)  //Чтобы постоянно не рисовало на одном и том же месте
            //    {
            //        Console.SetCursorPosition(Console.WindowWidth / 2 + x, y);
            //        Console.Write(bauble);
            //        consoleKey = ConsoleKey.W;
            //    }
            //}
            //Console.SetCursorPosition(Console.WindowWidth / 2, 5);
            //Console.WriteLine("..::GAME OVER::..");
            //Console.ReadKey();

            #endregion Moving bauble

            #region 1







            #endregion 1








        }
    }
}

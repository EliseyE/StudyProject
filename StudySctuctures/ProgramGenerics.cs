using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyGenerics
{
    internal class ProgramGenerics
    {
        //it's like List, similar, but not so much
        public class MyList<T>
        {
            private T[] _array = Array.Empty<T>();

            public T this[int index]
            {
                get
                {
                    return  _array[index];
                }
                set
                {
                    _array[index] = value;
                }
            }

            public int Count { get { return _array.Length; } }

            public void Add(T value)
            {
                var newArray = new T[_array.Length + 1];

                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }

                newArray[_array.Length] = value;
                _array = newArray;
            }

        }
        static void Main(string[] args)
        {
            //1
            double a = 1;
            double b = 5.7;

            Console.WriteLine($"a = {a}\t b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}\t b = {b}");

            Console.WriteLine("\n");

            //2
            string str1 = "Hello";
            string str2 = "World";

            Console.WriteLine($"str1 = {str1}\t str2 = {str2}");
            Swap(ref str1, ref str2);
            Console.WriteLine($"str1 = {str1}\t str2 = {str2}");

            int result = Method<int>();

            Console.WriteLine("\n");

            //3
            MyList<int> myList = new MyList<int>();
            myList.Add(5);
            myList.Add(55);
            myList.Add(8);
            myList.Add(9);

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }



            Console.ReadKey();
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static T Method<T>()
        {
            return default(T);
        }
    }
}

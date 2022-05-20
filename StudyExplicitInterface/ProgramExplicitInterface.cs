using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyExplicitInterface
{
    interface IFirstInterface
    {
        void Action();
    }

    interface ISecondInterface
    {
        void Action();
    }

    class MyClass : IFirstInterface, ISecondInterface
    {
        public void Action()
        {
            Console.WriteLine("MyClass Action...");
        }
    }

    class MyOtherClass : IFirstInterface, ISecondInterface
    {
        void IFirstInterface.Action()
        {
            Console.WriteLine("MytherClass IFirstInterface.Action...");
        }

        void ISecondInterface.Action()
        {
            Console.WriteLine("MytherClass ISecondInterface.Action...");
        }
    }

    internal class ProgramExplicitInterface
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Method1(myClass);
            Method2(myClass);

            Console.WriteLine();

            //1 long way to use methods
            MyOtherClass myOtherClass = new MyOtherClass();
            //Method1(myOtherClass);
            //Method2(myOtherClass);

            Console.WriteLine();

            //2 use Explicited Interface methods in value area
            IFirstInterface firstInterface = myOtherClass;
            firstInterface.Action();
            ((IFirstInterface)myOtherClass).Action();

            //3
            //Wrong way: !!! It will call exception in runing program
            //object obj = new object();
            //((IFirstInterface)obj).Action();

            // Need to use "is" or "as" opertaors
            object obj = new object();
            if (obj is IFirstInterface firstInterface1)
            {
                firstInterface1.Action();
            }

            Console.ReadKey();
        }

        static void Method1(IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }
        static void Method2(ISecondInterface secondInterface)
        {
            secondInterface.Action();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1
            //CreatingOfObjectOfClassPoint();

            ////2
            //StudentDataToConsole();

            ////3
            //Shooting();

            ////4
            //PointTaskUsingGetAndSet();


            ////5
            //CountingOfExemplarsofClassCreated();

            ////6
            //SeeWhatIsStaticConstructor();

            ////6a
            SimulateDBLinkConfiguration();

            Console.ReadKey();

        }

        //1
        enum Color
        {
            White,
            Red,
            Green,
            Blue,
            Orange
        }

        class ClassPoint
        {
            public int x;
            public int y;
            public Color color;
        }

        static void CreatingOfObjectOfClassPoint()
        {
            ClassPoint p1 = new ClassPoint();
            p1.x = 5;
            p1.y = 2;
            p1.color = Color.White;

            ClassPoint p2 = new ClassPoint();
            p2.x = 9;
            p2.y = 3;
            p2.color = Color.Red;
        }

        //2
        class Student
        {
            public Student()
            {

            }
            public Student(string lastName, DateTime birthday)
            {
                this.lastName = lastName;
                this.birthday = birthday;
            }

            //Upper constructor are using in next constructor. Inner code will be shoter due to using of upper constructor 
            public Student(string lastName, DateTime birthday, string firstName) : this(lastName, birthday)
            {
                this.firstName = firstName;
            }

            public Guid id;
            public string firstName;
            public string lastName;
            public string middleName;
            public int age;
            public DateTime birthday;
            public string group;
        }

        static Student GetStudentData()
        {
            var student = new Student();

            student.id = Guid.NewGuid();
            student.firstName = "Alex";
            student.lastName = "Frost";
            student.middleName = "-";
            student.age = 28;
            student.group = "IT4385-22";

            return student;
        }

        static void PrintStudentData(Student student)
        {
            Console.WriteLine($"Информация о студенте:");
            Console.WriteLine($"Id: {student.id}");
            Console.WriteLine($"Фамилия: {student.lastName}");
            Console.WriteLine($"Имя: {student.firstName}");
            Console.WriteLine($"Отчество: {student.middleName}");
            Console.WriteLine($"Возраст: {student.age}");
            Console.WriteLine($"Группа: {student.group}");
        }

        static void StudentDataToConsole()
        {
            var firstStudent = GetStudentData();

            PrintStudentData(firstStudent);
        }

        //3
        class Gun
        {
            public Gun(bool isLoaded)
            {
                _isLoaded = isLoaded;

            }

            private bool _isLoaded;
            private void Reload()
            {
                Console.WriteLine("Reloading..");
                _isLoaded = true;
                Console.WriteLine("Loaded!");
            }

            public void Shoot()
            {
                if (!_isLoaded)
                {
                    Console.WriteLine("Gun isn't loaded!");
                    Reload();
                }
                Console.WriteLine("Gunshot");
                _isLoaded = false;
            }
        }

        static void Shooting()
        {
            Gun gun = new Gun(false);
            gun.Shoot();
            Console.WriteLine();
            gun.Shoot();
        }

        //4
        class Point
        {
            //Getter and Setter of value x by methods
            private int x;

            public void SetX(int x)
            {
                if (x < 1)
                {
                    this.x = 1;
                    return;
                }
                if (x > 7)
                {
                    this.x = 7;
                    return;
                }

                this.x = x;
            }

            public int GetX()
            {
                return x;
            }

            //get and get by property, acsessors
            private int y;

            public int Y
            {
                get
                {
                    return y;
                }
                set
                {
                    if (value < 1)
                    {
                        y = 1;
                        return;
                    }
                    if (value > 10)
                    {
                        y = 10;
                        return;
                    }

                    y = value;
                }
            }

            //Shoter version of get and set
            public int Z { get; private set; }
        }

        static void PointTaskUsingGetAndSet()
        {
            Point point = new Point();

            point.Y = 5;

        }

        //5 Counter of exemplars of class

        class ThatClassNeedsToCountExemplars
        {
            public ThatClassNeedsToCountExemplars()
            {
                Counter++;
            }

            private static int counter;

            //1st variant to extract private counter value, it's by property. This is for encapsulation
            public static int Counter
            {
                get { return counter; }
                private set { counter = value; }
            }

            //if needs to get value to object level, it needs to delete "static" modificator in the property and delete "set" accessor for defence counter value
            public int ObjectsCounter
            {
                get { return counter; }
            }

            //2nd variant to extract private counter value, it's by the method. This is for encapsulation
            public static int GetCounterValue()
            {
                return counter;
            }

            //if needs to get value to object level, it needs to delete "static" modificator in the method
            public int GetObjectsCounterValue()
            {
                return counter;
            }

        }

        static void CountingOfExemplarsofClassCreated()
        {
            ThatClassNeedsToCountExemplars classToNeedCountExemplarNumber1 = new ThatClassNeedsToCountExemplars();
            ThatClassNeedsToCountExemplars classToNeedCountExemplarNumber2 = new ThatClassNeedsToCountExemplars();


            Console.WriteLine(ThatClassNeedsToCountExemplars.Counter);

            Console.WriteLine(ThatClassNeedsToCountExemplars.GetCounterValue());

            Console.WriteLine(classToNeedCountExemplarNumber1.ObjectsCounter);

            Console.WriteLine(classToNeedCountExemplarNumber2.GetObjectsCounterValue());

        }

        //6
        class ClassForStudyStaticConstructor
        {
            public ClassForStudyStaticConstructor()
            {
                Console.WriteLine("Constructor");
            }

            static ClassForStudyStaticConstructor()
            {
                Console.WriteLine("Static Constructor");
            }

            public static int a = 5;

        }

        static void SeeWhatIsStaticConstructor()
        {
            int b = ClassForStudyStaticConstructor.a;
            Console.WriteLine(b);

            ClassForStudyStaticConstructor staticConstructor1 = new ClassForStudyStaticConstructor();

            new ClassForStudyStaticConstructor();
            new ClassForStudyStaticConstructor();
            new ClassForStudyStaticConstructor();
        }

        //6a Simulation of connetion to DB by an external configuration file. It's using static configutarion and configuration for all of class objects
        class DbRepository
        {
            private static string connectionKey;

            static DbRepository()
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                connectionKey = configurationManager.GetConnetionKey();
            }

            public void ViewConnectionKey()
            {
                Console.WriteLine("Using: " + connectionKey);
            }
        }

        class ConfigurationManager
        {
            public string GetConnetionKey()
            {
                return "local addrDB";
            }
        }

        static void SimulateDBLinkConfiguration()
        {

            DbRepository dbRepository = new DbRepository();

            dbRepository.ViewConnectionKey();
        }
    }
}

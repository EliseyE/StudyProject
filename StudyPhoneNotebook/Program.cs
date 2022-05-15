using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPhoneNotebook
{
    internal class Program
    {
        struct PhoneBookEntry
        {

            public PhoneBookEntry()
            {
                indexOfEntry = 1;
                firstName = "blank";
                lastName = "blank";
                middleName = "blank";
                age = 0;
                phoneNumber = "blank";
            }

            private static int counter;

            private int indexOfEntry;
            private string firstName;
            private string lastName;
            private string middleName;
            private int age;
            private string phoneNumber;

            public int IndexOfEntry { get { return indexOfEntry; } }
            public string FirstName { get { return firstName; } }
            public string LastName { get { return lastName; } }
            public string MiddleName { get { return middleName; } }
            public int Age { get { return age; } }
            public string PhoneNumber { get { return phoneNumber; } }

            //Method of creation of new entry
            public static PhoneBookEntry CreateNewPhoneBookEntry()
            {
                var newNameOfEntry = new PhoneBookEntry();

                Console.WriteLine($"Index of entry : {PhoneBookEntry.counter}");
                Console.WriteLine("Filling new entry..");

                Console.Write("FirstName:\t");
                newNameOfEntry.firstName = Console.ReadLine();

                Console.Write("LastName:\t");
                newNameOfEntry.lastName = Console.ReadLine();

                counter++;
                Console.WriteLine(counter);

                return newNameOfEntry;


            }

            public static void GetPhoneBookEntry()
            {


            }
        }


        static void Main(string[] args)
        {

            var phoneBookEntry1 = PhoneBookEntry.CreateNewPhoneBookEntry();

            Console.WriteLine(phoneBookEntry1.FirstName);
            Console.WriteLine(phoneBookEntry1.LastName);

            Console.WriteLine();


            Console.ReadKey();
        }
    }
}

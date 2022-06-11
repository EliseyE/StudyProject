using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace StudyPhoneNotebook
{
    internal class ProgramPhoneNotebook
    {
        class Entry
        {
            private Guid _id;
            private string _name;
            private string _familyName;
            private string _phoneNumber;

            public Entry()
            {
                _id = Guid.NewGuid();
            }

            public Guid Id { get { return _id; } }
            public string Name { get { return _name; } set { _name = value; } }
            public string FamilyName { get { return _familyName; } set { _familyName = value; } }
            public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        }

        class PhoneBook
        {
            //вопрос в инициализации. как лучше сделать инициализацию поля, содержащего массив
            public Entry[] EntryBook { get; set; }

            public PhoneBook()
            {
                EntryBook = new Entry[0];
            }

            public Entry[] AddNewEntry(Entry entry, Entry[] entryBook)
            {
                    int newIndex = entryBook.Length + 1;
                    Entry[] addedEntryBook = new Entry[newIndex];
                    addedEntryBook[entryBook.Length] = entry;

                    for (int i = 0; i < entryBook.Length; i++)
                            addedEntryBook[i] = entryBook[i];
                    
                entryBook = addedEntryBook;
                return entryBook;
            }

            public Entry[] DeleteEntry(int deletedIndex, Entry[] entryBook)
            {
                int newIndex = entryBook.Length - 1;
                Entry[] reducedEntryBook = new Entry[newIndex];

                for(int i = 0; i < deletedIndex; i++)
                    reducedEntryBook[i] = entryBook[i];

                for(int i = deletedIndex; i < entryBook.Length - 1; i++)
                    reducedEntryBook[i] = entryBook[i + 1];
                
                entryBook = reducedEntryBook;

                return entryBook;
            }

            public Entry[] EditEntry(int editedIndex, Entry entry, Entry[] entryBook)
            {
                entryBook[editedIndex] = entry;
                return entryBook;
            }
        }

        class Validator
        {
            public bool CheckInput(Entry entry)
            {
                return true;
            }

            public bool CheckInputE(string inputData)
            {
                bool checkResult = false;
                bool checkSpace = false;
                bool checkLettersOrDigits = false;

                foreach (Char c in inputData)
                {
                    if (c == ' ')
                        checkSpace = true;

                    if (Char.IsLetterOrDigit(c))
                        checkLettersOrDigits = true;
                }

                if ((inputData != "") || ((checkSpace = false) && (checkLettersOrDigits = true)) || (inputData == null))
                    checkResult = true;

                    return checkResult;
            }
        }

        class Inputer
        {
            public Entry CreateEntry()
            {
                Validator validator = new Validator();
                Entry entry = new();

                //1st varian
                //entry.Id = Guid.NewGuid();
                //Console.WriteLine($"Id: {entry.Id}");
                //Console.Write("Input name: ");
                //entry.Name = Console.ReadLine();

                //2nd variant
                foreach (PropertyInfo field in entry.GetType().GetTypeInfo().DeclaredProperties)
                {
                    if(field.CanWrite == true)
                    {
                        Console.Write("Input {0}: ", field.Name);
                        string inputData = Console.ReadLine();

                        if (validator.CheckInputE(inputData) == false)
                        {
                            inputData = "no data";
                        }

                        field.SetValue(entry, inputData);
                    }
                }

                return entry;
            }
        }

        class EntryProgram
        {
            PhoneBook phoneBook = new PhoneBook();
            Validator validator = new Validator();
            Inputer inputer = new Inputer();
            Printer printer = new Printer();
            Sorter sorter = new Sorter();
            Сomparator сomparator = new Сomparator();
            Editor editor = new Editor();

            public void AddNewEntry()
            {
                ConsoleKey consoleKey = ConsoleKey.Clear;

                while (consoleKey != ConsoleKey.Escape)
                {
                    Console.WriteLine();
                    Console.WriteLine("New entry");
                    Entry entry = inputer.CreateEntry();
                    if (validator.CheckInput(entry))
                        phoneBook.EntryBook = phoneBook.AddNewEntry(entry, phoneBook.EntryBook);
                    Console.WriteLine();

                    Console.WriteLine("To stop adding process press Escape. To continue press any key");
                    consoleKey = Console.ReadKey().Key;
                }
                Console.WriteLine();
            }

            public void FindEntry()
            {
                Console.WriteLine();
                Console.WriteLine("Finding process");
                Console.WriteLine("Input what you are looking for:");
                string requestToFind = Console.ReadLine();
                Console.WriteLine();
                bool findingStatus = false;

                for (int i = 0; i < phoneBook.EntryBook.Length; i++)
                {
                    string[] entryProperties = sorter.Sorting(phoneBook.EntryBook[i]);
                    
                    for (int j = 0; j < entryProperties.Length; j++)
                    {
                        bool findingResult = сomparator.ComparingOfRequestAndEntryProperties(requestToFind, entryProperties[j]);

                        if (findingResult)
                        {
                            Console.WriteLine($"Entry number: {i}");
                            printer.PrintEntry(phoneBook.EntryBook[i]);
                            findingStatus = true;
                            break;
                        }
                    }
                }
                if (findingStatus == false)
                {
                    Console.Beep(450, 500);
                    Console.WriteLine("Result: Not found. Please try again.");
                    Console.WriteLine();
                }
            }

            public void EditEntry()
            {
                Console.WriteLine();
                Console.WriteLine("Edit entry process");
                Console.WriteLine("If the data does not need to be changed, input symbol: -");
                Console.WriteLine("Input entry number:");
                bool checkNumber = int.TryParse(Console.ReadLine(), out int entryNumberToEdit);
                Console.WriteLine();

                if ((checkNumber == true) && (entryNumberToEdit < phoneBook.EntryBook.Length) && (entryNumberToEdit >= 0))
                {
                    //int entryNumber = entryNumberToEdit;
                    Console.WriteLine("This Entry needs to edit:");
                    printer.PrintEntry(phoneBook.EntryBook[entryNumberToEdit]);
                    Entry oldEntry = phoneBook.EntryBook[entryNumberToEdit];

                    //1st variant
                    //Console.WriteLine("Input new data:");
                    //phoneBook.EntryBook[entryNumber] = inputer.CreateEntry();
                    //phoneBook.EntryBook[entryNumber].Id = oldEntry.Id;
                    
                    //2nd variant
                    foreach (PropertyInfo field in oldEntry.GetType().GetTypeInfo().DeclaredProperties)
                    {
                        if (field.CanWrite)
                        {
                            Console.Write("Input new {0}: ", field.Name);
                            string inputData = Console.ReadLine();

                            if(inputData != "-")
                            {
                                while (validator.CheckInputE(inputData) == false)
                                {
                                    Console.WriteLine("Incorrect input data. Try again.");
                                    inputData = Console.ReadLine();
                                }
                                field.SetValue(oldEntry, inputData);
                            }
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Edited entry:");
                    printer.PrintEntry(phoneBook.EntryBook[entryNumberToEdit]);
                }
                else
                {
                    Console.WriteLine("Incorrect entry number. Try Again.");
                }
            }

            public void PrintAll()
            {
                Console.WriteLine();
                if (phoneBook.EntryBook.Length != 0)
                {
                    printer.PrintPhoneBook(phoneBook.EntryBook);
                }
                else
                {
                    Console.Beep(450, 500);
                    Console.WriteLine("Phonebook is empty.");
                    Console.WriteLine();
                }
            }

            public void DeleteEntry()
            {
                Console.WriteLine();
                Console.WriteLine("Delete entry process");
                Console.WriteLine("input entry number:");
                bool checkNumber = int.TryParse(Console.ReadLine(), out int result);
                Console.WriteLine();

                if ((checkNumber == true) && (result < phoneBook.EntryBook.Length))
                {
                    int entryNumber = result;
                    Console.WriteLine("You selected this entry to delete:");
                    printer.PrintEntry(phoneBook.EntryBook[entryNumber]);

                    Console.WriteLine("To confirm deleting operation write Y");
                    string questionForClosing = Console.ReadLine();

                    if ((questionForClosing == "Y") || (questionForClosing == "y"))
                        phoneBook.EntryBook = phoneBook.DeleteEntry(entryNumber, phoneBook.EntryBook);
                }
                else
                {
                    Console.WriteLine("Incorrect entry number. Try Again.");
                }
            }

            internal void DeleteAllEntries()
            {
                Console.WriteLine();
                Console.WriteLine("To confirm deleting operation write Y");
                string questionForClosing = Console.ReadLine();
                Console.WriteLine();

                if ((questionForClosing == "Y") || (questionForClosing == "y"))
                {
                    phoneBook.EntryBook = new Entry[0];
                    Console.Beep(450, 200);
                    Console.Beep(450, 200);
                    Console.Beep(450, 200);
                    Console.WriteLine("Now the Phonebook is empty.");
                }

                Console.WriteLine();
            }
        }
        
        class Editor
        {
            public Entry EditCurrentEntry(Entry entry)
            {
                foreach (PropertyInfo field in entry.GetType().GetTypeInfo().DeclaredProperties)
                {
                    if (field.CanWrite)
                    {
                        Console.WriteLine("Input new {0}: ", field.Name);
                        field.SetValue(entry, Console.ReadLine());
                    }
                }

                Console.WriteLine();

                return entry;
            }
        }

        class Printer
        {
            public void PrintPhoneBook(Entry[] entryBook)
            {
                for (int i = 0; i < entryBook.Length; i++)
                {
                    Console.WriteLine($"Entry number: {i}");
                    PrintEntry(entryBook[i]);
                    Console.WriteLine();
                }
            }

            public void PrintEntry(Entry entry)
            {
                if (entry == null)
                    Console.WriteLine("Not found");
                else
                {
                    //1st varian
                    //Console.WriteLine("Id:\t" + entry.Id);
                    //Console.WriteLine("Name:\t" + entry.Name);
                    //Console.WriteLine();

                    //2nd
                    foreach (PropertyInfo field in entry.GetType().GetTypeInfo().DeclaredProperties)
                    {
                        Console.WriteLine("{0}: {1}" , field.Name, field.GetValue(entry));
                    }

                    Console.WriteLine();
                }
            }
        }

        class Sorter
        {
            public string[] Sorting(Entry entry)
            {
                //1st working process of field's enumeration
                //how is it working??
                //IEnumerable<FieldInfo> fields = entry.GetType().GetTypeInfo().DeclaredFields;
                //foreach (var field in fields.Where(x => !x.IsStatic))
                //{
                //    Console.WriteLine(field.GetValue(entry));
                //}

                //2.1
                //PropertyInfo[] entryPropertyInfo;
                //Type entryType = typeof(Entry);
                //entryPropertyInfo = entryType.GetProperties();
                //string[] propertyArray = new string[entryPropertyInfo.Length];

                //2.2
                int i = 0;
                string[] propertyArray = new string[entry.GetType().GetTypeInfo().DeclaredProperties.ToArray().Length];

                //2 way to get fields
                foreach (PropertyInfo field in entry.GetType().GetTypeInfo().DeclaredProperties)
                {
                    for (; i < propertyArray.Length; )
                    {
                        propertyArray[i] = field.GetValue(entry).ToString();
                        i++;
                        break;
                    }
                }

                return propertyArray;
            }
        }

        class Сomparator
        {
            public bool ComparingOfRequestAndEntryProperties(string requestToFind, string property)
            {
                requestToFind = requestToFind.ToLower();
                property = property.ToLower();
                bool findingResult = false;

                for (int i = 0; i < property.Length; i++)
                {
                    if ((property[i] == requestToFind[0]) && (requestToFind.Length <= property.Length - i))
                    {
                        for (int j = 0, charCounterOfRequestToFind = 0; j < requestToFind.Length; j++)
                        {
                            if (property[j + i] == requestToFind[j])
                            {
                                charCounterOfRequestToFind++;
                            }

                            if (charCounterOfRequestToFind == requestToFind.Length)
                            {
                                findingResult = true;
                                i = property.Length;
                                break;
                            }
                        }
                    }
                }
                
                return findingResult;
            }
        }

        static void Main(string[] args)
        {
            EntryProgram entryProgram = new EntryProgram();

            bool close = true;

            while (close)
            {
                Console.WriteLine("Select what you want to do. Enter one of the commands:" +
                    "\naddnew - to add new entry" +
                    "\nfind - to find the entry in the book" +
                    "\nedit - to edit the entry" +
                    "\nprint - to print all entries" +
                    "\ndelete - to delete the entry" +
                    "\ndelall - to delete all entries in the Phonebook" +
                    "\nclear - to clear display" +
                    "\nclose - to close program" +
                    "\n");

                switch (Console.ReadLine())
                {
                    case "addnew":
                        entryProgram.AddNewEntry();
                        break;
                    case "find":
                        entryProgram.FindEntry();
                        break;
                    case "edit":
                        entryProgram.EditEntry();
                        break;
                    case "print":
                        entryProgram.PrintAll();
                        break;
                    case "delete":
                        entryProgram.DeleteEntry();
                        break;
                    case "delall":
                        entryProgram.DeleteAllEntries();
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "close":
                        close = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect command. Please try again.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}






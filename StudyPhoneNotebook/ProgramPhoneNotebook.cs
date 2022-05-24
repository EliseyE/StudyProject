using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPhoneNotebook
{
    //in process..
    //
    //

    internal class ProgramPhoneNotebook
    {
        class Entry
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
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
        }

        class Inputer
        {
            public Entry CreateEntry()
            {
                Entry entry = new();
                entry.Id = Guid.NewGuid();
                Console.WriteLine($"Id: {entry.Id}");
                Console.Write("Input name: ");
                entry.Name = Console.ReadLine();

                return entry;
            }
        }

        class EntryProgram
        {
            PhoneBook phoneBook = new PhoneBook();
            Validator validator = new Validator();
            Inputer inputer = new Inputer();
            Printer printer = new Printer();

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
            }

            public void  FindEntry()
            {
                Console.WriteLine("I'm finding something");
            }

            public void EditEntry()
            {
                Console.WriteLine();
                Console.WriteLine("Edit entry process");
                Console.WriteLine("Input entry number:");
                bool checkNumber = int.TryParse(Console.ReadLine(), out int result);
                Console.WriteLine();

                if (checkNumber == true && result < phoneBook.EntryBook.Length)
                {
                    int entryNumber = result;
                    Console.WriteLine("This Entry needs to edit:");
                    printer.PrintEntry(phoneBook.EntryBook[entryNumber]);
                    Entry oldEntry = phoneBook.EntryBook[entryNumber];

                    Console.WriteLine("Input new data:");
                    phoneBook.EntryBook[entryNumber] = inputer.CreateEntry();
                    phoneBook.EntryBook[entryNumber].Id = oldEntry.Id;

                    Console.WriteLine();
                    Console.WriteLine("Edited entry:");
                    printer.PrintEntry(phoneBook.EntryBook[entryNumber]);
                }
                else
                {
                    Console.WriteLine("Incorrect entry number. Try Againg.");
                }

            }
            public void PrintAll()
            {
                printer.PrintPhoneBook(phoneBook.EntryBook);
            }

            public void DeleteEntry()
            {
                Console.WriteLine();
                Console.WriteLine("Delete entry process");
                Console.WriteLine("input entry number:");
                bool checkNumber = int.TryParse(Console.ReadLine(), out int result);
                Console.WriteLine();

                if (checkNumber == true && result < phoneBook.EntryBook.Length)
                {
                    int entryNumber = result;
                    Console.WriteLine("You selected this entry to delete:");
                    printer.PrintEntry(phoneBook.EntryBook[entryNumber]);

                    Console.WriteLine("To confirm deleting operation write Y");
                    string questionForClosing = Console.ReadLine();
                    if (questionForClosing == "Y" || questionForClosing == "y")
                        phoneBook.EntryBook = phoneBook.DeleteEntry(entryNumber, phoneBook.EntryBook);
                }
                else
                {
                    Console.WriteLine("Incorrect entry number. Try Again.");
                }
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
                    Console.WriteLine("Id:\t" + entry.Id);
                    Console.WriteLine("Name:\t" + entry.Name);
                    Console.WriteLine();
                }
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
                    case "close":
                        close = false;
                        break;
                }

                //Console.WriteLine();
                //Console.Write("Close? Write Y to close program: ");
                //string questionForClosing = Console.ReadLine();
                //if (questionForClosing == "Y" || questionForClosing == "y")
                //    close = false;
                //Console.WriteLine();
            }
        }
    }
}






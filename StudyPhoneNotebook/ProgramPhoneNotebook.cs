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
        struct PhoneBookEntry
        {
            private int idEntry;
            private string firstName;
            private string lastName;
            private string middleName;
            private int age;
            private string phoneNumber;

            public int IndexOfEntry { get { return idEntry; } }
            public string FirstName { get { return firstName; } }
            public string LastName { get { return lastName; } }
            public string MiddleName { get { return middleName; } }
            public int Age { get { return age; } }
            public string PhoneNumber { get { return phoneNumber; } }
            public PhoneBookEntry(int idEntry, string firstName, string lastName, string middleName, int age, string phoneNumber)
            {
                this.idEntry = idEntry;
                this.firstName = firstName;
                this.lastName = lastName;
                this.middleName = middleName;
                this.age = age;
                this.phoneNumber = phoneNumber;
            }
        }
        class PhoneBook
        {
            List<PhoneBookEntry> phoneBookEntries;

            public void NewEntry(PhoneBookEntry phoneBookEntry)
            {
                phoneBookEntries.Add(phoneBookEntry);
            }
        }


        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            PhoneBookEntry phoneBookEntry = new PhoneBookEntry(1, "Vasia", "Petrov", "Victorovich", 12, "2325");
            phoneBook.NewEntry(phoneBookEntry);


            Console.ReadKey();
        }

    }
}

        ////
        ///


        
                NoterProgram noterProgram = new NoterProgram();

                bool close = true;

                while (close)
                {
                    Console.WriteLine("Select what you want to do: addnew");

                    switch (Console.ReadLine())
                    {
                        case "Addnew":
                            noterProgram.Addnew();
                            break;
                        case "Find":
                            noterProgram.PrintNote(noterProgram.FindName("Slava"));
                            break;

                    }

                    Console.WriteLine("close?");

                }

       

        public class NoterProgram
        {
            BookNote bookNote = new BookNote();
            Validate validate = new Validate();
            Inputer inputer = new Inputer();

            public void Addnew()
            {
                Note note = inputer.CreateNote();
                if (validate.CheckInput(note))
                    bookNote.Add(note);
            }

            public Note FindName(string name)
            {
                foreach (Note note in bookNote.notes)
                {
                    if (note.Name == name)
                        return note;
                }
                for (int i = 0; i < bookNote.notes.Count; i++)
                {
                    if (bookNote.notes[i].Name == name)
                        return bookNote.notes[i];
                }

                return null;
            }

            public void PrintNote(Note note)
            {
                if (note == null)
                    Console.WriteLine("Not find");
                else
                {
                    Console.WriteLine(note.Name);
                    Console.WriteLine(note.Id);
                }
            }


        }



        public class Note
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class BookNote
        {
            public List<Note> notes;

            public void Add(Note note)
            {
                notes.Add(note);
            }
        }

        public class Validate
        {
            public bool CheckInput(Note note)
            {
                return true;
            }
        }

        public class Inputer
        {
            public Note CreateNote()
            {
                Note note = new();
                Console.WriteLine("input name");
                note.Name = Console.ReadLine();

                return note;
            }
        }

    

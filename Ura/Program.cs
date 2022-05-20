using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ura
{
    interface IСongratulation
    {
        void HappyBirthday(DateTime BirthdayDate);
    }

    class Ura
        
    {
        public static string Name = "Ura";
        public DateTime BirthdayDate { get; set; }
    }

    class Elisey : IСongratulation
    {
        public string Name = "Elisey";
        public void HappyBirthday(DateTime BirthdayDate)
        {
            DateTime today = DateTime.Today;

            if (BirthdayDate.Month == today.Month && BirthdayDate.Day == today.Day)

            Console.WriteLine($"{Name} says: Happy Birthday, {Ura.Name}!");
            else
            {
                Console.WriteLine("Not today, Ura, not today..");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Ura ura = new Ura();
            ura.BirthdayDate = new DateTime(1988, 5, 19);

            IСongratulation elisey = new Elisey();

            elisey.HappyBirthday(ura.BirthdayDate);

            Console.ReadKey();
        }
    }
}

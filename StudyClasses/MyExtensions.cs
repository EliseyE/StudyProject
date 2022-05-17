using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyClasses;

namespace StudyClasses_MyExtensions
{
    
    static class MyExtensions
    {
        //7 Extension methods for DateTime
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }

        //parameters in extension methods
        public static bool IsDayOfWeek(this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek;
        }

        //7 Extension methods for sealed class SealedStudentClass
        public static string GetFullName(this SealedStudentClass student)
        {
            return student.LastName + " " + student.FirstName;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace StudyExcel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (BO.ExcelHelper helper = new BO.ExcelHelper())
                {
                    if (helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, "TestLT.xlsx")))
                    {
                        helper.Set(column:"A", row: 1, data:"fdfjkdf");
                        helper.Set(column: "B", row: 2, data: DateTime.Now);

                        helper.Save();
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}

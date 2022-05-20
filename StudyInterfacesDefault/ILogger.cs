using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyInterfacesDefault
{
    public interface ILogger
    {
        void Log(LogLevel loglevel, string message);

        void MethodPrintTest()
        {
            Console.WriteLine("Test");
        }
    }
}

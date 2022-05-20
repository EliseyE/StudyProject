using System;

namespace StudyInterfacesDefault
{
    //Interfaces Default realisation in C# 8.0

    

    internal class ProgramInterfacesDefault
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            consoleLogger.Log(LogLevel.Debug, "some event");
            consoleLogger.MethodPrintTest();
            consoleLogger.Log(LogLevel.Warning, "some warning");
            consoleLogger.Log(LogLevel.Fatal, "some fatal error");


        }
    }
}

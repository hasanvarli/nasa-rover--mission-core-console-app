using NASARoverMissionConsoleApp.Enums;
using System;

namespace NASARoverMissionConsoleApp.Operations
{
    /// <summary>
    /// Store common methods
    /// </summary>
    public class CommonOperations
    {
        /// <summary>
        /// Only write console screen
        /// </summary>
        /// <param name="text">Entered Value</param>
        /// <param name="consoleWriteType">Write Type</param>
        public static void WriteConsole(string text, ConsoleWriteType consoleWriteType)
        {
            switch (consoleWriteType)
            {
                case ConsoleWriteType.I:
                    Console.Write(text);
                    break;
                case ConsoleWriteType.N:
                    Console.WriteLine(text);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Exit app
        /// </summary>
        public static void Exit()
        {
            Console.WriteLine("Enter to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}

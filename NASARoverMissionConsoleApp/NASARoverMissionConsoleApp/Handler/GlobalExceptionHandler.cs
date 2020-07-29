using NASARoverMissionConsoleApp.Enums;
using NASARoverMissionConsoleApp.Operations;
using System;

namespace NASARoverMissionConsoleApp.Handler
{
    /// <summary>
    /// Exception handler
    /// </summary>
    public class GlobalExceptionHandler
    {
        /// <summary>
        /// Catch Unhandled exception
        /// </summary>
        public static void UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            CommonOperations.WriteConsole("Bir hata oluştu tekrar deneyiniz. Çıkmak için bir tuşa basınız.", ConsoleWriteType.N);
            Console.ReadKey();
        }
    }
}

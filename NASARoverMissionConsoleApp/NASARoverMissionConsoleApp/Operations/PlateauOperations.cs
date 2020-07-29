using NASARoverMissionConsoleApp.Enums;
using NASARoverMissionConsoleApp.Model;
using System;
using System.Drawing;

namespace NASARoverMissionConsoleApp.Operations
{
    /// <summary>
    /// Store plateau operations
    /// </summary>
    public class PlateauOperations
    {
        /// <summary>
        /// Create plateau
        /// </summary>
        /// <returns></returns>
        public static Plateau initPlateau()
        {
            Plateau mars = new Plateau();
            CommonOperations.WriteConsole("Plateau created. -> " + mars.id + "-" + mars.name, ConsoleWriteType.N);

            mars.size = SetSize();

            CommonOperations.WriteConsole(mars.name + " size is: " + mars.size, ConsoleWriteType.N);
            CommonOperations.WriteConsole("---------------------------", ConsoleWriteType.N);
            return mars;
        }

        /// <summary>
        /// Show created plateau size
        /// </summary>
        /// <param name="size">Plateau Size</param>
        public static void ShowPlateau(Point size)
        {
           CommonOperations.WriteConsole("Plateau looks like the following:", ConsoleWriteType.N);
            for (int i = 0; i < size.Y; i++)
            {
                for (int k = 0; k < size.X; k++)
                {
                    CommonOperations.WriteConsole("* ", ConsoleWriteType.I);
                }
                CommonOperations.WriteConsole("", ConsoleWriteType.N);
            }
            CommonOperations.WriteConsole("", ConsoleWriteType.N);
        }

        /// <summary>
        /// Set plateau size by x and y
        /// </summary>
        /// <returns></returns>
        private static Point SetSize()
        {
            while (true)
            {
                CommonOperations.WriteConsole("Enter plateau size (like X Y):", ConsoleWriteType.N);
                string[] size = Console.ReadLine().ToString().Split(' ');
                Point point = new Point(int.Parse(size[0]), int.Parse(size[1]));
                if (point.X > 0 && point.Y > 0)
                {
                    return point;
                }
                else
                {
                    Console.WriteLine("Please enter greater than zero");
                }
            }
        }
    }
}

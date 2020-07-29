using NASARoverMissionConsoleApp.Enums;
using NASARoverMissionConsoleApp.Model;
using System;
using System.Drawing;
using System.Linq;

namespace NASARoverMissionConsoleApp.Operations
{
    /// <summary>
    /// Store rover operations
    /// </summary>
    public class RoverOperations
    {
        /// <summary>
        /// Create rovers
        /// </summary>
        /// <param name="plateauSize">Plateau Size</param>
        /// <returns></returns>
        public static Rover[] DeclareRovers(Point plateauSize)
        {
            Rover[] rovers;
            CommonOperations.WriteConsole("Enter the rover numbers: ", ConsoleWriteType.I);
            rovers = new Rover[int.Parse(Console.ReadLine())];

            for (int i = 0; i < rovers.Length; i++)
            {
                var enteredData = setRoverPositionsAndDirection(plateauSize, i);
                rovers[i] = new Rover();
                rovers[i].id = i + 1;
                rovers[i].name = "ROVER-" + (i + 1);
                rovers[i].position = new Point(int.Parse(enteredData[0]), int.Parse(enteredData[1]));
                rovers[i].direction = CalculationOperations.SetDirection(enteredData[2].ToString().ToUpper());
                CommonOperations.WriteConsole("Enter command for ROVER-" + (i + 1) + "(like LLMRM): ", ConsoleWriteType.N);
                rovers[i].command = Console.ReadLine().ToUpper().ToCharArray();
                rovers[i].state = State.NONE;
                rovers[i].roverCoordinatValidation = RoverCoordinatValidation.VALID;
            }
            return rovers;
        }

        /// <summary>
        /// Show created rovers
        /// </summary>
        /// <param name="rovers">Created Rovers</param>
        public static void ShowRoverDetail(Rover[] rovers)
        {
            string validationMsg;
            for (int i = 0; i < rovers.Length; i++)
            {
                validationMsg = "OK";
                if (rovers[i].roverCoordinatValidation==RoverCoordinatValidation.INVALID)
                {
                    validationMsg = "FAIL -> LEFT THE MAP";
                }
                CommonOperations.WriteConsole(rovers[i].id + ", " + rovers[i].name + ", " + rovers[i].position + ", " + rovers[i].direction + ", " + rovers[i].state + ", " + validationMsg + ", " + new String(rovers[i].command), ConsoleWriteType.N);
            }
        }

        /// <summary>
        /// Show rovers on map
        /// </summary>
        /// <param name="rovers">Processed rovers</param>
        /// <param name="plateauSize">Plateau Size</param>
        public static void ShowRoverOnMap(Rover[] rovers, Point plateauSize)
        {
            for (int i = plateauSize.Y; i > 0; i--)
            {
                for (int k = 1; k <= plateauSize.X; k++)
                {
                    var asd = rovers.Any(item => item.position.X == k && item.position.Y == i);
                    if (asd)
                    {
                        CommonOperations.WriteConsole("X ", ConsoleWriteType.I);
                    }
                    else
                    {
                        CommonOperations.WriteConsole("* ", ConsoleWriteType.I);
                    }
                }
                CommonOperations.WriteConsole("", ConsoleWriteType.N);
            }
            CommonOperations.WriteConsole("", ConsoleWriteType.N);
        }

        /// <summary>
        /// Enter rover position and direction
        /// </summary>
        /// <param name="plateauSize">Plateau Size</param>
        /// <param name="roverID">Rover ID</param>
        /// <returns></returns>
        private static string[] setRoverPositionsAndDirection(Point plateauSize, int roverID)
        {
            while (true)
            {
                CommonOperations.WriteConsole("Enter starting position and direction for ROVER-" + (roverID + 1) + " (like 2 3 N): ", ConsoleWriteType.N);
                var data = Console.ReadLine().ToString().ToUpper().Split(' ');
                if (int.Parse(data[0]) <= plateauSize.X && int.Parse(data[1]) <= plateauSize.Y && int.Parse(data[0]) > 0 && int.Parse(data[1]) > 0)
                {
                    return data;
                }
                else
                {
                    Console.WriteLine("Please, place in plateau size(" + plateauSize + "). Try again");
                }
            }            
        }
    }
}

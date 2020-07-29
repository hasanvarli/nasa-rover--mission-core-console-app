using NASARoverMissionConsoleApp.Enums;
using NASARoverMissionConsoleApp.Handler;
using NASARoverMissionConsoleApp.Model;
using NASARoverMissionConsoleApp.Operations;
using System;

namespace NASARoverMissionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception handler
            AppDomain.CurrentDomain.UnhandledException += GlobalExceptionHandler.UnhandledException;

            //Welcome message
            CommonOperations.WriteConsole("WELCOME NASA ROVER MISSION!", ConsoleWriteType.N);

            //Create plateau
            Plateau plateau = PlateauOperations.initPlateau();

            //Show created plateau
            PlateauOperations.ShowPlateau(plateau.size);

            //Declare rovers
            Rover[] rovers = RoverOperations.DeclareRovers(plateau.size);

            //Show declared rovers
            RoverOperations.ShowRoverDetail(rovers);

            //Process data command
            CalculationOperations.ProcessCommand(rovers, plateau.size);

            //End exit!
            CommonOperations.Exit();
        }
    }
}

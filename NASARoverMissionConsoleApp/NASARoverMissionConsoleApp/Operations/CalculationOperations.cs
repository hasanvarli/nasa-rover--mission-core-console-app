using NASARoverMissionConsoleApp.Enums;
using NASARoverMissionConsoleApp.Model;
using System;
using System.Drawing;

namespace NASARoverMissionConsoleApp.Operations
{
    /// <summary>
    /// Store calculation operations
    /// </summary>
    public class CalculationOperations
    {
        /// <summary>
        /// Process rover's commands
        /// </summary>
        /// <param name="rovers">Entered Rovers</param>
        /// <param name="plateauSize">Plateau Size</param>
        public static void ProcessCommand(Rover[] rovers, Point plateauSize)
        {
            for (int i = 0; i < rovers.Length; i++)
            {
                rovers[i].state=setFirstInitState(rovers[i].direction);

                for (int k = 0; k < rovers[i].command.Length; k++)
                {
                    if (rovers[i].command[k].ToString() != "M")
                    {
                        rovers[i].state = setState(rovers[i].state, rovers[i].command[k].ToString());
                        rovers[i].direction = setDirection(rovers[i].state);
                    }
                    else
                    {
                        rovers[i].position = Move(rovers[i].state, rovers[i].position);
                    }
                    rovers[i].roverCoordinatValidation = CheckRoverCoordinatValid(rovers[i].position, plateauSize);

                    if (rovers[i].roverCoordinatValidation == RoverCoordinatValidation.INVALID)
                    {
                        break;
                    }
                }
            }

            CommonOperations.WriteConsole("RESULT:", ConsoleWriteType.N);
            RoverOperations.ShowRoverDetail(rovers);
            RoverOperations.ShowRoverOnMap(rovers, plateauSize);
        }

        /// <summary>
        /// Set rover fisrt init state by first direction
        /// </summary>
        /// <param name="direction">First Direction</param>
        private static State setFirstInitState(Direction roverDirection)
        {
            switch (roverDirection)
            {
                case Direction.N:
                    return State.YIncrease;
                    break;
                case Direction.E:
                    return State.XIncrease;
                    break;
                case Direction.W:
                    return State.XDecrease;
                    break;
                case Direction.S:
                    return State.YDecrease;
                    break;
                default:
                    return State.NONE;
                    break;
            }
        }

        /// <summary>
        /// Determine state
        /// </summary>
        /// <param name="roverState">Current Rover State</param>
        /// <param name="command">Current Rover Command</param>
        /// <returns></returns>
        private static State setState(State roverState, string command)
        {
            if ((Command)Enum.Parse(typeof(Command),command) == Command.L)
            {
                if (roverState == State.XDecrease)
                {
                    return State.YDecrease;
                }
                if (roverState == State.XIncrease)
                {
                    return State.YIncrease;
                }
                if (roverState == State.YDecrease)
                {
                    return State.XIncrease;
                }
                if (roverState == State.YIncrease)
                {
                    return State.XDecrease;
                }
            }
            else if ((Command)Enum.Parse(typeof(Command), command) == Command.R)
            {
                if (roverState == State.XDecrease)
                {
                    return State.YIncrease;
                }
                if (roverState == State.XIncrease)
                {
                    return State.YDecrease;
                }
                if (roverState == State.YDecrease)
                {
                    return State.XDecrease;
                }
                if (roverState == State.YIncrease)
                {
                    return State.XIncrease;
                }
            }
            return State.NONE;
        }

        /// <summary>
        /// Determine direction by state
        /// </summary>
        /// <param name="stateRover">Current State</param>
        /// <returns></returns>
        private static Direction setDirection(State stateRover)
        {
            if (stateRover == State.XDecrease)
            {
                return Direction.W;
            }
            if (stateRover == State.XIncrease)
            {
                return Direction.E;
            }
            if (stateRover == State.YDecrease)
            {
                return Direction.S;
            }
            if (stateRover == State.YIncrease)
            {
                return Direction.N;
            }
            return Direction.X;
        }

        /// <summary>
        /// Move rover operation
        /// </summary>
        /// <param name="state">Current Rover State</param>
        /// <param name="position">Current Rover Position</param>
        /// <returns></returns>
        private static Point Move(State state, Point position)
        {
            switch (state)
            {
                case State.YDecrease:
                    return new Point(position.X, position.Y - 1);
                    break;
                case State.YIncrease:
                    return new Point(position.X, position.Y + 1);
                    break;
                case State.XDecrease:
                    return new Point(position.X - 1, position.Y);
                    break;
                case State.XIncrease:
                    return new Point(position.X + 1, position.Y);
                    break;
                default:
                    break;
            }
            return new Point(0, 0);
        }

        /// <summary>
        /// Rover coordinat check
        /// </summary>
        /// <param name="roverPosition">Rover Position</param>
        /// <param name="plateauSize">Plateau Size</param>
        /// <returns></returns>
        private static RoverCoordinatValidation CheckRoverCoordinatValid(Point roverPosition, Point plateauSize)
        {
            if (roverPosition.X <= plateauSize.X && roverPosition.Y <= plateauSize.Y && roverPosition.X >= 0 && roverPosition.Y >= 0)
            {
                return RoverCoordinatValidation.VALID;
            }
            else
            {
                return RoverCoordinatValidation.INVALID;
            }
        }

        /// <summary>
        /// Determine direction
        /// </summary>
        /// <param name="stringDirection">Current Direction</param>
        /// <returns></returns>
        public static Direction SetDirection(string stringDirection)
        {
            return (Direction)Enum.Parse(typeof(Direction), stringDirection);
        }
    }
}

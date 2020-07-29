using NASARoverMissionConsoleApp.Enums;
using System.Drawing;

namespace NASARoverMissionConsoleApp.Model
{
    /// <summary>
    /// Include robotic rover definitions
    /// </summary>
    public class Rover
    {
        /// <summary>
        /// ID field
        /// </summary>
        private int ID { get; set; }

        /// <summary>
        /// Name field
        /// </summary>
        private string Name { get; set; }

        /// <summary>
        /// Position field, give last position
        /// </summary>
        private Point Position { get; set; }

        /// <summary>
        /// Direction field, give last direction
        /// </summary>
        private Direction Direction { get; set; }

        /// <summary>
        /// Command field, give command array
        /// </summary>
        private char[] Command { get; set; }

        /// <summary>
        /// State , give last state
        /// </summary>
        private State State { get; set; }

        /// <summary>
        /// Give last coordinat validation
        /// </summary>
        private RoverCoordinatValidation RoverCoordinatValidation { get; set; }

        /// <summary>
        /// Property of ID field, assigned by default
        /// </summary>
        public int id
        {
            get { return ID; }
            set { ID = value; }
        }

        /// <summary>
        /// Property of Name field
        /// </summary>
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        /// <summary>
        /// Property of Position field
        /// </summary>
        public Point position
        {
            get { return Position; }
            set { Position = value; }
        }

        /// <summary>
        /// Property of Direction field
        /// </summary>
        public Direction direction
        {
            get { return Direction; }
            set { Direction = value; }
        }

        /// <summary>
        /// Property of Command field
        /// </summary>
        public char[] command
        {
            get { return Command; }
            set { Command = value; }
        }

        /// <summary>
        /// Property of State field
        /// </summary>
        public State state
        {
            get { return State; }
            set { State = value; }
        }

        /// <summary>
        /// Property of State field
        /// </summary>
        public RoverCoordinatValidation roverCoordinatValidation
        {
            get { return RoverCoordinatValidation; }
            set { RoverCoordinatValidation = value; }
        }
    }
}

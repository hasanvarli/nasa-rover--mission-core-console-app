using System.Drawing;

namespace NASARoverMissionConsoleApp.Model
{
    /// <summary>
    /// Include plateau definitions
    /// </summary>
    public class Plateau
    {
        /// <summary>
        /// ID field
        /// </summary>
        private int ID = 1;

        /// <summary>
        /// Name field
        /// </summary>
        private string Name = "MARS";

        /// <summary>
        /// Size field, give plateau size
        /// </summary>
        private Point Size;

        /// <summary>
        /// Property of ID field, assigned by default
        /// </summary>
        public int id
        {
            get { return ID; }
        }

        /// <summary>
        /// Property of Name field, assigned by default
        /// </summary>
        public string name
        {
            get { return Name; }
        }

        /// <summary>
        /// Property of Size field
        /// </summary>
        public Point size
        {
            get { return Size; }
            set { Size = value; }
        }
    }
}

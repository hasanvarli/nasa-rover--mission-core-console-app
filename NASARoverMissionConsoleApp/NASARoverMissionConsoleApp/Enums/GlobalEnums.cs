using System.ComponentModel.DataAnnotations;

/// <summary>
/// Store all enums
/// </summary>
namespace NASARoverMissionConsoleApp.Enums
{
    /// <summary>
    /// It's contains rover commands.
    /// </summary>
    public enum Command
    {
        [Display(Name = "LEFT")]
        L,
        [Display(Name = "RIGHT")]
        R,
        [Display(Name = "MOVE")]
        M
    }

    /// <summary>
    /// It's contains rover directions.
    /// </summary>
    public enum Direction
    {
        [Display(Name = "NORTH")]
        N,
        [Display(Name = "EAST")]
        E,
        [Display(Name = "WEST")]
        W,
        [Display(Name = "SOUTH")]
        S,
        [Display(Name = "NONE")]
        X
    }

    /// <summary>
    /// It's contains rover directions.
    /// </summary>
    public enum State
    {
        [Display(Name = "IncreasingYValue")]
        YIncrease,
        [Display(Name = "DecreasingYValue")]
        YDecrease,
        [Display(Name = "DecreasingXValue")]
        XDecrease,
        [Display(Name = "IncreasingXValue")]
        XIncrease,
        [Display(Name = "None")]
        NONE
    }

    /// <summary>
    /// It's contains Rover coordinat validation.
    /// </summary>
    public enum RoverCoordinatValidation
    {
        [Display(Name = "VALID")]
        VALID,
        [Display(Name = "INVALID")]
        INVALID
    }

    /// <summary>
    /// It's contains console write type.
    /// </summary>
    public enum ConsoleWriteType
    {
        [Display(Name = "INLINE")]
        I,
        [Display(Name = "NEWLINE")]
        N
    }
}

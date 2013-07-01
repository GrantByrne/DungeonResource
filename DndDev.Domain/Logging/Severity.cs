namespace DndDev.Domain.Logging
{
    /// <summary>
    /// Explicates the severity of a log entry
    /// </summary>
    /// <remarks>
    /// Can also be used to throttle the amount of logging to the database, 
    /// though this feature is currently not supported
    /// </remarks>
    public enum Severity
    {
        /// <summary>
        /// The highest possible rank and is intended to turn off logging.
        /// </summary>
        Off,

        /// <summary>
        /// Severe errors that cause premature termination. Expect these 
        /// to be immediately visible on a status console.
        /// </summary>
        Fatal,

        /// <summary>
        /// Other runtime errors or unexpected conditions. Expect these 
        /// to be immediately visible on a status console.
        /// </summary>
        Error,

        /// <summary>
        /// Use of deprecated APIs, poor use of API, 'almost' errors, 
        /// other runtime situations that are undesirable or unexpected, 
        /// but not necessarily "wrong". Expect these to be immediately 
        /// visible on a status console.
        /// </summary>
        Warning,

        /// <summary>
        ///  Interesting runtime events (startup/shutdown). Expect these 
        /// to be immediately visible on a console, so be conservative 
        /// and keep to a minimum. 
        /// </summary>
        Info,

        /// <summary>
        /// Detailed information on the flow through the system. Expect 
        /// these to be written to logs only.
        /// </summary>
        Debug,

        /// <summary>
        /// Most detailed information. Expect these to be written to logs 
        /// only.
        /// </summary>
        Trace
    }
}

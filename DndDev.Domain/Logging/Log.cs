using System;

namespace DndDev.Domain.Logging
{
    /// <summary>
    /// Contains all the information for a single log entry
    /// </summary>
    public class Log
    {
        /// <summary>
        /// The UID for the log entry
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The severy level of the log entry
        /// </summary>
        public Severity Severity { get; set; }

        /// <summary>
        /// The time the log event took place
        /// </summary>
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// Message to display what the system was 
        /// attempting to do
        /// </summary>
        public string HighLevelMessage { get; set; }

        /// <summary>
        /// The message associated with the log
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The exception information including the stack trace
        /// </summary>
        public string Exception { get; set; }

        /// <summary>
        /// The name of the machine which threw the error
        /// </summary>
        public string MachineName { get; set; }
    }
}

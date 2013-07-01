using System;
using DndDev.Domain.Logging;
using DndDev.Repository.Logging.Abstract;

namespace DndDev.Service.Logging
{
    public class LoggingService
    {
        /// <summary>
        /// Handles the database operations
        /// </summary>
        private readonly ILoggingRepository _loggingRepository;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="loggingRepository"></param>
        public LoggingService(ILoggingRepository loggingRepository)
        {
            _loggingRepository = loggingRepository;
        }
        
        /// <summary>
        /// Create a Fatal Log Entry
        /// </summary>
        public void LogFatalError(string highLevelMessage, Exception exception)
        {
            var log = new Log
                {
                    Severity = Severity.Fatal,
                    TimeStamp = DateTime.Now,
                    MachineName = Environment.MachineName,
                    Message = exception.Message,
                    Exception = exception.StackTrace,
                    HighLevelMessage = highLevelMessage
                };
            
            _loggingRepository.Create(log);
        }

        /// <summary>
        /// Creates an Error Log Entry
        /// </summary>
        public void LogError(string highLevelMessage, Exception exception)
        {
            var log = new Log
                {
                    Severity = Severity.Error,
                    TimeStamp = DateTime.Now,
                    MachineName = Environment.MachineName,
                    Message = exception.Message,
                    Exception = exception.StackTrace,
                    HighLevelMessage = highLevelMessage
                };
            _loggingRepository.Create(log);
        }

        /// <summary>
        /// Creates a Warning Log Entry
        /// </summary>
        public void LogWarning(string highLevelMessage, string message)
        {
            var log = new Log
            {
                Severity = Severity.Error,
                TimeStamp = DateTime.Now,
                MachineName = Environment.MachineName,
                Message = message,
                HighLevelMessage = highLevelMessage
            };
            _loggingRepository.Create(log);
        }

        /// <summary>
        /// Create an Info Log Entry
        /// </summary>
        public void LogInfo(string highLevelMessage, string message)
        {
            var log = new Log
            {
                Severity = Severity.Error,
                TimeStamp = DateTime.Now,
                MachineName = Environment.MachineName,
                Message = message,
                HighLevelMessage = highLevelMessage
            };
            _loggingRepository.Create(log);
        }

        /// <summary>
        /// Creates a Debug Log Entry
        /// </summary>
        public void LogDebug(string highLevelMessage, string message)
        {
            var log = new Log
            {
                Severity = Severity.Error,
                TimeStamp = DateTime.Now,
                MachineName = Environment.MachineName,
                Message = message,
                HighLevelMessage = highLevelMessage
            };
            _loggingRepository.Create(log);
        }

        /// <summary>
        /// Creates a Trace Log Entry
        /// </summary>
        public void LogTrace(string highLevelMessage, string message)
        {
            var log = new Log
            {
                Severity = Severity.Error,
                TimeStamp = DateTime.Now,
                MachineName = Environment.MachineName,
                Message = message,
                HighLevelMessage = highLevelMessage
            };
            _loggingRepository.Create(log);
        }

        public void Read(int page, int count)
        {
            
        }
    }
}

using DungeonResource.Components.Service.Abstract;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Service
{
    public class LogService : ILogService
    {

        private readonly IClassLogger _classLogger;

        private readonly Logger _logger;

        /// <summary>
        ///     ctor
        /// </summary>
        /// <param name="classLogger"></param>
        public LogService(IClassLogger classLogger)
        {
            _classLogger = classLogger;
            _logger = _classLogger.Get();
        }

        public void Trace(string message)
        {
            _logger.Trace(message);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
        }

        public void Warn(string message, Exception exception)
        {
            _logger.Warn(message, exception);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(string message, Exception exception)
        {
            _logger.Error(message, exception);
        }

        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        public void Fatal(string message, Exception exception)
        {
            _logger.Fatal(message, exception);
        }
    }
}

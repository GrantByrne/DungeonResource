using DungeonResource.Components.Service.Abstract;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Service
{
    /// <summary>
    ///     ...
    /// </summary>
    /// <remarks>
    ///     Since the logger is thread safe, this is meant 
    ///     to be kept in singleton scope.
    /// </remarks>
    public class ClassLogger : IClassLogger
    {
        public Logger Get()
        {
            return LogManager.GetLogger("DungeonResource");
        }
    }
}

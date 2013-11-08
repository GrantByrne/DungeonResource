using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonResource.Components.Service.Abstract
{
    public interface IClassLogger
    {
        Logger Get();
    }
}

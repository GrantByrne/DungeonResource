using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndDev.Domain.Logging
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
    }
}

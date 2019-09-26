using ISUF.Base.Template;
using ISUF.Storage.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Storage.Templates
{
    public class LogUserActivityItem : AtomicItem
    {
        public int UserId { get; set; }
        public UserLogType UserActivity { get; set; }
    }
}

using ISUF.Base.Template;
using ISUF.Storage.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Storage.Templates
{
    /// <summary>
    /// Model for storing user log activity in database
    /// </summary>
    public class LogUserActivityItem : AtomicItem
    {
        public int UserId { get; set; }
        public UserLogType UserActivity { get; set; }

        public LogUserActivityItem()
        {

        }

        public LogUserActivityItem(LogUserActivityItem logUserActivity) : base(logUserActivity)
        {
            UserId = logUserActivity.UserId;
            UserActivity = logUserActivity.UserActivity;
        }

        public override object Clone()
        {
            return new LogUserActivityItem(this);
        }

        public override string ToString()
        {
            return $"{Id}:  {UserId} - {UserActivity}";
        }
    }
}

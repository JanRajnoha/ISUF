using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Templates
{
    public class TaskBaseItem : BaseItem
    {
        public DateTime Start { get; set; } = DateTime.Today;
        public DateTime End { get; set; } = DateTime.Today;
        public bool Neverend { get; set; }
        public DateTime WhenNotify { get; set; } = DateTime.Now;
        public bool Notify { get; set; } = true;
        public ObservableCollection<DayOfWeek> NotifyDays { get; set; } = new ObservableCollection<DayOfWeek>();

        public ObservableCollection<DateTime> Dates { get; set; }

        public TaskBaseItem()
        {

        }

        public TaskBaseItem(TaskBaseItem taskBaseItem)
        {
            Id = taskBaseItem.Id;
            Name = taskBaseItem.Name;
            Secured = taskBaseItem.Secured;
            Description = taskBaseItem.Description;
            Start = taskBaseItem.Start;
            End = taskBaseItem.End;
            Neverend = taskBaseItem.Neverend;
            WhenNotify = taskBaseItem.WhenNotify;
            Notify = taskBaseItem.Notify;
            NotifyDays = taskBaseItem.NotifyDays;
        }

        public override object Clone()
        {
            return new TaskBaseItem(this);
        }

        /// <summary>
        /// Add/remove today day
        /// </summary>
        public void AddDate()
        {
            if (!Dates.Contains(DateTime.Today))
                Dates.Add(DateTime.Today);
            else
                Dates.Remove(DateTime.Today);

            NotifyPropertyChanged(nameof(Dates));
        }
    }
}

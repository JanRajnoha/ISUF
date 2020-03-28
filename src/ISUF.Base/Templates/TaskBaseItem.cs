using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Templates
{
    /// <summary>
    /// Task base item
    /// </summary>
    public class TaskBaseItem : BaseItem
    {
        /// <summary>
        /// Task start
        /// </summary>
        public DateTime Start { get; set; } = DateTime.Today;

        /// <summary>
        /// Task end
        /// </summary>
        public DateTime End { get; set; } = DateTime.Today;

        /// <summary>
        /// Task is nevernding
        /// </summary>
        public bool Neverend { get; set; }

        /// <summary>
        /// When to notify task
        /// </summary>
        public DateTime WhenNotify { get; set; } = DateTime.Now;

        /// <summary>
        /// Noptify item
        /// </summary>
        public bool Notify { get; set; } = true;

        /// <summary>
        /// Which day to notify task
        /// </summary>
        public ObservableCollection<DayOfWeek> NotifyDays { get; set; } = new ObservableCollection<DayOfWeek>();

        /// <summary>
        /// Completed days
        /// </summary>
        public ObservableCollection<DateTime> Dates { get; set; }

        public TaskBaseItem()
        {

        }

        /// <summary>
        /// Initialize new instance of item from existing one
        /// </summary>
        /// <param name="taskBaseItem">Existing item</param>
        public TaskBaseItem(TaskBaseItem taskBaseItem) : base(taskBaseItem)
        {
            Start = taskBaseItem.Start;
            End = taskBaseItem.End;
            Neverend = taskBaseItem.Neverend;
            WhenNotify = taskBaseItem.WhenNotify;
            Notify = taskBaseItem.Notify;
            NotifyDays = taskBaseItem.NotifyDays;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
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

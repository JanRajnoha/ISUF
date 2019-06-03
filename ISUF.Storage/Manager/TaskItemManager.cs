using ISUF.Base.Settings;
using ISUF.Base.Templates;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;

namespace ISUF.Storage.Manager
{
    public class TaskItemManager<T> : ItemManager<T> where T : TaskBaseItem
    {
        private readonly string shortTypeName;
        private readonly string longTypeName;

        public TaskItemManager(string fileName, string shortTypeName, string longTypeName) : base(fileName)
        {
            this.shortTypeName = shortTypeName;
            this.longTypeName = longTypeName;
        }

        protected override void CustomSettings_UserLogChanged(object sender, UserLoggedEventArgs e)
        {
            Debug.WriteLine($"User secure settings has changed. Log called from {GetType().ToString()}.");
        }

        /// <summary>
        /// Add addition check for AddItem
        /// </summary>
        /// <param name="item">New task item</param>
        /// <returns>Result of addition check action. True = successful</returns>
        public override bool AddItemAdditionCheck(T item)
        {
            if (item.NotifyDays.Count == 0)
                item.NotifyDays = new ObservableCollection<DayOfWeek>
                {
                    DayOfWeek.Monday,
                    DayOfWeek.Tuesday,
                    DayOfWeek.Wednesday,
                    DayOfWeek.Thursday,
                    DayOfWeek.Friday,
                    DayOfWeek.Saturday,
                    DayOfWeek.Sunday
                };

            return true;
        }

        /// <summary>
        /// Remove item from collection and remove schduled toast
        /// </summary>
        /// <param name="detailedItem">Removed item</param>
        public override void Delete(T detailedItem)
        {
            base.Delete(detailedItem);

            var ToastNotifier = ToastNotificationManager.CreateToastNotifier();
            var ScheduledToastList = ToastNotifier.GetScheduledToastNotifications();

            if (ScheduledToastList.Select(x => x.Id).Contains(shortTypeName + detailedItem.ID))
                ToastNotificationManager.CreateToastNotifier().RemoveFromSchedule(ScheduledToastList.FirstOrDefault(x => x.Id == (shortTypeName + detailedItem.ID)));
        }

        /// <summary>
        /// Schedule new toast notification
        /// </summary>
        /// <param name="act">Scheduling activity</param>
        public void ScheduleToastNotification(T act)
        {
            if (!act.Notify || act.Secured || act.End.Date < DateTime.Today)
                return;

            DateTime firstSchedule = DateTime.Now;

            if (act.Start.Date <= DateTime.Today)
                firstSchedule = new DateTime(act.Start.Year, act.Start.Month, act.Start.Day);

            // To-Do : solve

            //var noti = Notifications.GetXml(new string[2] { "Uncompleted " + longTypeName.ToLower(), longTypeName + $" {act.Name} isn't completed." }, ToastTemplateType.ToastText02);

            firstSchedule = new DateTime(firstSchedule.Year, firstSchedule.Month, firstSchedule.Day, act.WhenNotify.Hour, act.WhenNotify.Minute, act.WhenNotify.Second);

            while (!act.NotifyDays.Contains(firstSchedule.DayOfWeek))
            {
                firstSchedule.AddDays(1);
            }

            // To-Do : solve

            //Notifications.RegisterScheduledToast((uint)act.ID, shortTypeName, noti, firstSchedule);
        }

        /// <summary>
        /// Update completed activity with adding today date to Dates collection
        /// </summary>
        /// <param name="CompletedActivity">Completed Activity</param>
        public async void CompleteTask(T CompletedActivity)
        {
            int Index = ItemsSource.IndexOf(CompletedActivity);
            if (Index == -1)
            {
                Index = IndexOfItem(CompletedActivity);
                if (Index == -1)
                    return;
            }

            ItemsSource[Index].AddDate();

            // To-Do : solve

            //if (ItemsSource[Index].Dates.Contains(DateTime.Today))
            //    Notifications.RemoveScheduledToast(shortTypeName + ItemsSource[Index].ID);
            //else
            //    ScheduleToastNotification(ItemsSource[Index]);

            await SaveDataAsync();
        }
    }
}

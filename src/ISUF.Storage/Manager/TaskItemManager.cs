using ISUF.Base.Modules;
using ISUF.Base.Service;
using ISUF.Base.Settings;
using ISUF.Base.Templates;
using ISUF.Interface.Storage;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Windows.UI.Notifications;

namespace ISUF.Storage.Manager
{
    public class TaskItemManager : BaseItemManager
    {
        private readonly string shortTypeName;
        private readonly string longTypeName;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbAccess"></param>
        /// <param name="moduleItemType"></param>
        /// <param name="moduleName"></param>
        /// <param name="shortTypeName"></param>
        /// <param name="longTypeName"></param>
        public TaskItemManager(IDatabaseAccess dbAccess, Type moduleItemType, string moduleName, string shortTypeName, string longTypeName) : base(dbAccess, moduleItemType, moduleName)
        {
            this.shortTypeName = shortTypeName;
            this.longTypeName = longTypeName;
        }

        /// <summary>
        /// User log changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void CustomSettings_UserLogChanged(object sender, UserLoggedEventArgs e)
        {
            LogService.AddLogMessage($"User secure settings has changed. Log called from {GetType()}.");
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="item"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public override bool AddItemAdditionCheck<T>(T item)
        {
            if (item is TaskBaseItem itemTask)
            {
                if (itemTask.NotifyDays.Count == 0)
                    itemTask.NotifyDays = new ObservableCollection<DayOfWeek>
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
            else
                return false;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="detailedItem"><inheritdoc/></param>
        public override Task<bool> RemoveItem<T>(T detailedItem, ModuleManager moduleManager)
        {
            var result = base.RemoveItem(detailedItem, moduleManager);

            var ToastNotifier = ToastNotificationManager.CreateToastNotifier();
            var ScheduledToastList = ToastNotifier.GetScheduledToastNotifications();

            if (ScheduledToastList.Select(x => x.Id).Contains(shortTypeName + detailedItem.Id))
                ToastNotificationManager.CreateToastNotifier().RemoveFromSchedule(ScheduledToastList.FirstOrDefault(x => x.Id == (shortTypeName + detailedItem.Id)));

            return null; // TODO - Insp, co to je a proč todo
        }

        /// <summary>
        /// Schedule new toast notification
        /// </summary>
        /// <param name="act">Scheduling activity</param>
        public void ScheduleToastNotification<T>(T act) where T : TaskBaseItem
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
        /// <param name="completedActivity">Completed Activity</param>
        public async Task<bool> CompleteTask<T>(T completedActivity) where T : TaskBaseItem
        {
            var itemSource = dbAccess.GetAllItems<T>();

            var item = itemSource.FirstOrDefault(x => x.Id == completedActivity.Id);

            if (item == null)
                return false;

            item.AddDate();

            // To-Do : solve

            //if (ItemsSource[Index].Dates.Contains(DateTime.Today))
            //    Notifications.RemoveScheduledToast(shortTypeName + ItemsSource[Index].ID);
            //else
            //    ScheduleToastNotification(ItemsSource[Index]);

            return await dbAccess.EditItemInDatabase(item);
        }
    }
}

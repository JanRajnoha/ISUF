using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Linq;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace ISUF.Win10.Notifications
{
    /// <summary>
    /// Extensions for Windows 10 - Notifications
    /// </summary>
    public class Notifications
    {
        // To-Do: Check this class

        /// <summary>
        /// Create XmlDocument for given parametres
        /// </summary>
        /// <param name="text">Text on toast</param>
        /// <param name="template">Template of toast</param>
        /// <param name="imageSource">Image on toast</param>
        /// <returns>Toast notification XmlDocument</returns>
        public static XmlDocument GetXml(string[] text, ToastTemplateType template, string imageSource = null)
        {
            ToastTemplateType ToastTemplate = template;
            XmlDocument ToastXml = ToastNotificationManager.GetTemplateContent(ToastTemplate);
            XmlNodeList ToastElements;

            /*       if (ImageSource != null)
                   {
                       ToastElements = ToastXml.GetElementsByTagName("image");

                       try
                       {
                           ToastElements[0].AppendChild(ToastXml.CreateTextNode(ImageSource));
                       }
                       catch { }
                   }*/

            ToastElements = ToastXml.GetElementsByTagName("text");

            for (int i = 0; i < ToastElements.Length; i++)
            {
                ToastElements[i].AppendChild(ToastXml.CreateTextNode(text[i]));
            }

            return ToastXml;
        }

        /// <summary>
        /// Register new scheduled toast notification
        /// </summary>
        /// <param name="itemID">ID of item</param>
        /// <param name="category">Category of item</param>
        /// <param name="xmlToast">XML for notification</param>
        /// <param name="scheduleTime">SChedule time</param>
        public static void RegisterScheduledToast(uint itemID, string category, XmlDocument xmlToast, DateTime scheduleTime)
        {
            RemoveScheduledToast(category + itemID);

            DateTime now = scheduleTime.AddMinutes(scheduleTime.Minute == DateTime.Now.Minute ? 1 : 0);

            if (now < DateTime.Now)
                return;

            ScheduledToastNotification newScheduled = new ScheduledToastNotification(xmlToast, now)
            {
                Id = category + itemID
            };

            ToastNotificationManager.CreateToastNotifier().AddToSchedule(newScheduled);
        }

        /// <summary>
        /// Remove schedulet toast notification and return, if action was succesfull
        /// </summary>
        /// <param name="ID">ID of notification</param>
        /// <returns>Result of action</returns>
        public static bool RemoveScheduledToast(string ID)
        {
            var ToastNotifier = ToastNotificationManager.CreateToastNotifier();
            var ScheduledToastList = ToastNotifier.GetScheduledToastNotifications();

            if (ScheduledToastList.Select(x => x.Id).Contains(ID))
            {
                ToastNotificationManager.CreateToastNotifier().RemoveFromSchedule(ScheduledToastList.FirstOrDefault(x => x.Id == ID));
                return true;
            }

            return false;
        }

        /// <summary>
        /// Pop toast notification from XmlDocument
        /// </summary>
        /// <param name="xml">XmlDocument for toast noification</param>
        public static void SendNotification(XmlDocument xml)
        {
            ToastNotificationManager.CreateToastNotifier().Show(new ToastNotification(xml));
        }

        /// <summary>
        /// Pop toast notification
        /// </summary>
        /// <param name="text">Text on toast</param>
        /// <param name="template">Template of toast</param>
        /// <param name="imageSource">Source image on toast</param>
        public static void SendNotification(string[] text, ToastTemplateType template, string imageSource = null)
        {
            ToastNotificationManager.CreateToastNotifier().Show(new ToastNotification(GetXml(text, template, imageSource)));
        }

        /// <summary>
        /// Pop toast notification (not completed)
        /// </summary>
        /// <param name="Text">Text on toast</param>
        public static void SendNotification(string[] Text)
        {
            var toastContent = new ToastContent()
            {
                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
                        {
                            new AdaptiveText()
                            {
                                Text = Text[0]
                            },
                            new AdaptiveText()
                            {
                                Text = Text[1]
                            }
                        }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Buttons =
                    {
                        new ToastButton("Complete", "action=acceptFriendRequest&userId=49183")
                        {
                            ActivationType = ToastActivationType.Background
                        },
                        new ToastButtonDismiss()
                    }
                },
                Launch = "action=viewEvent&eventId=1983"
            };

            var toast = new ToastNotification(toastContent.GetXml())
            {
                ExpirationTime = DateTime.Now.AddDays(1)
            };

            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }
    }
}

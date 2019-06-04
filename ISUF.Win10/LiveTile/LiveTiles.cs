using System;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace ISUF.Win10.LiveTile
{
    /// <summary>
    /// Extensions for Windows 10 - Live tiles
    /// </summary>
    public class LiveTiles
    {
        /// <summary>
        /// Update badge
        /// </summary>
        /// <param name="value">New value</param>
        public static void UpdateBadge(string value)
        {
            XmlDocument badgeXml = BadgeUpdateManager.GetTemplateContent(BadgeTemplateType.BadgeNumber);
            XmlElement badgeElement = (XmlElement)badgeXml.SelectSingleNode("/badge");
            badgeElement.SetAttribute("value", value);
            BadgeNotification badge = new BadgeNotification(badgeXml);
            BadgeUpdateManager.CreateBadgeUpdaterForApplication().Update(badge);
        }

        /// <summary>
        /// Update live tile
        /// </summary>
        /// <param name="LiveTileXML">Live tile XML template</param>
        public static void LiveTileUpdater(string LiveTileXML)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(LiveTileXML);
            TileNotification tileNotification = new TileNotification(xmlDoc);
            TileUpdateManager.CreateTileUpdaterForApplication().Update(tileNotification);
        }
    }
}

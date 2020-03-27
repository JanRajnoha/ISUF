using ISUF.Base.Enum;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ISUF.Base.Classes
{
    /// <summary>
    /// Working with constants for changing behavior of program
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// Enable beta functions
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public bool BetaMode { get; set; } = false;

        /// <summary>
        /// Inform about setting constants were completed
        /// </summary>
        [XmlIgnore]
        [JsonIgnore]
        public bool ConstantsSetComplete { get; set; } = false;

        /// <summary>
        /// Enable log in application
        /// </summary>
        [XmlElement(IsNullable = true)]
        public bool? LogEnable { get; set; }

        /// <summary>
        /// Enable debug functions
        /// </summary>
        [XmlElement(IsNullable = true)]
        public bool? Debug { get; set; }

        /// <summary>
        /// Set app fail flag
        /// </summary>
        [XmlElement(IsNullable = true)]
        public bool? AppFail { get; set; }

        /// <summary>
        /// Set log level
        /// </summary>
        [XmlElement(IsNullable = true)]
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// Developers constants
        /// </summary>
        [XmlElement(IsNullable = true)]
        public Dictionary<string, bool> CustomConstants { get; set; }

        private bool saveSettings = false;

        /// <summary>
        /// COnstants instance
        /// </summary>
        public static Constants Instance = new Constants();

        /// <summary>
        /// Set environemtn constants
        /// </summary>
        /// <param name="betaMode">Enable beta mode</param>
        /// <param name="logEnable">Enable log mode</param>
        /// <param name="debug">Enable debug mode</param>
        /// <param name="appFail">Enable recover from failure</param>
        public static async void SetConstants(bool betaMode = false, bool logEnable = false, bool debug = false, bool appFail = false)
        {
            if (Instance.ConstantsSetComplete)
                return;

            Instance.ConstantsSetComplete = true;

            Instance = await LoadSettingsAsync();

            Instance.BetaMode = betaMode;

            if (Instance.LogEnable == null)
                Instance.LogEnable = logEnable;

            if (Instance.Debug == null)
                Instance.Debug = debug;

            if (Instance.AppFail == null)
                Instance.AppFail = appFail;

            if (Instance.saveSettings)
                await SaveSettingsAsync();
        }

        /// <summary>
        /// Load constants from file with async
        /// </summary>
        /// <param name="fileName">Settings file name</param>
        /// <returns>Constants</returns>
        public static async Task<Constants> LoadSettingsAsync(string fileName = "Set.dat")
        {
            Constants loadResult = await Storage.FileStream<Constants>.ReadDataAsync(fileName, "");

            if (loadResult == null)
            {
                return new Constants()
                {
                    saveSettings = true
                };
            }

            return loadResult;
        }

        /// <summary>
        /// Load settings from file
        /// </summary>
        /// <param name="fileName">Settings file name</param>
        /// <returns>Constants</returns>
        public static Constants LoadSettings(string fileName = "Set.dat")
        {
            return LoadSettingsAsync(fileName).Result;
        }

        /// <summary>
        /// Save settings into file with async
        /// </summary>
        /// <param name="fileName">Settings file name</param>
        /// <returns>Task</returns>
        public static async Task SaveSettingsAsync(string fileName = "Set.dat")
        {
            Constants con = new Constants();

            con = Instance;

            await Storage.FileStream<Constants>.SaveDataAsync(con, fileName, "");
        }

        /// <summary>
        /// Save settings into file
        /// </summary>
        /// <param name="fileName">Setitngs file name</param>
        public static void SaveSettings(string fileName = "Set.dat")
        {
            SaveSettingsAsync().Wait();
        }
    }
}

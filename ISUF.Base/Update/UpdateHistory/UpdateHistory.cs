using ISUF.Base.Enum;
using ISUF.Base.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.ApplicationModel;
using Windows.Storage;

namespace ISUF.Base.Update.UpdateHistory
{
    public class UpdateHistory<T>
    {
        List<UpdateHistoryItem<T>> updateHistoryList = new List<UpdateHistoryItem<T>>();

        public string FileName = "UpdateHistory.xml";
        public List<UpdateItem> UpdateList;
        public Version LastVersion;

        public UpdateHistory(List<UpdateHistoryItem<T>> updateHistoryList)
        {
            this.updateHistoryList = updateHistoryList;
        }

        /// <summary>
        /// Get list of keys of all completed tasks
        /// </summary>
        /// <returns>List of keys</returns>
        public async Task<List<string>> GetKeyListAsync()
        {
            if (UpdateList == null)
                await ReadDataAsync();

            return UpdateList.Select(selector: x => x.Key).ToList();
        }

        /// <summary>
        /// Get list of non completed update tasks for latest version
        /// </summary>
        /// <returns>List of non completed update tasks</returns>
        public async Task<List<UpdateHistoryItem<T>>> GetUpdateHistoryListAsync()
        {
            if (LastVersion == null)
                await ReadDataAsync();

            return GetUpdateHistoryList(LastVersion);
        }

        /// <summary>
        /// Get list of non completed update tasks for selected version
        /// </summary>
        /// <param name="lastVersion">Selected version</param>
        /// <returns>List of non completed update tasks</returns>
        public List<UpdateHistoryItem<T>> GetUpdateHistoryList(Version lastVersion)
        {
            return updateHistoryList.Where(predicate: x => x.UpdateVersion >= lastVersion).ToList();
        }

        /// <summary>
        /// Get list of completed tasks
        /// </summary>
        /// <returns>List of completed tasks</returns>
        public async Task<List<UpdateItem>> GetListAsync()
        {
            if (UpdateList == null)
                await ReadDataAsync();

            return UpdateList.ToList();
        }

        /// <summary>
        /// Add new key into list of completed update tasks or update existing key
        /// </summary>
        /// <param name="newKey">Name of new key</param>
        /// <param name="updateDone">State of key</param>
        /// <returns></returns>
        public async Task AddKeyAsync(string newKey, bool updateDone = false)
        {
            if ((await GetKeyListAsync()).Contains(item: newKey))
                UpdateList.FirstOrDefault(predicate: x => x.Key == newKey).UpdateDone = updateDone;
            else
                UpdateList.Add(item: new UpdateItem() { Key = newKey, UpdateDone = updateDone });

            await SaveDataAsync();
        }

        /// <summary>
        /// Remove key from list of completed update tasks
        /// </summary>
        /// <param name="oldKey">Key to remove</param>
        /// <returns></returns>
        public async Task RemoveKeyAsync(string oldKey)
        {
            if (!(await GetKeyListAsync()).Contains(item: oldKey))
                return;

            UpdateList.Remove(item: UpdateList.FirstOrDefault(x => x.Key == oldKey));

            await SaveDataAsync();
        }

        /// <summary>
        /// Set key to value
        /// </summary>
        /// <param name="currentKey">Name of key</param>
        /// <param name="value">Value of key</param>
        /// <param name="createIfKeyNotExist">Create if key not exist</param>
        /// <returns></returns>
        public async Task SetKeyAsync(string currentKey, bool value, bool createIfKeyNotExist = true)
        {
            if (!(await GetKeyListAsync()).Contains(item: currentKey) && createIfKeyNotExist)
                await AddKeyAsync(currentKey);

            UpdateItem updateItem = (await GetListAsync()).FirstOrDefault(x => x.Key == currentKey);
            if (updateItem != null)
                updateItem.UpdateDone = value;

            await SaveDataAsync();
        }

        /// <summary>
        /// Check, if key exist and update state. If key not exist, create it. If UpdateDone is false, change it to true
        /// </summary>
        /// <param name="currentKey">Name of key</param>
        /// <returns>State of value of key</returns>
        public async Task<bool> CheckKeyAsync(string currentKey)
        {
            if (!(await GetKeyListAsync()).Contains(item: currentKey))
                await AddKeyAsync(currentKey);

            bool result = GetItem(currentKey).UpdateDone;

            if (!result)
            {
                GetItem(currentKey).UpdateDone = true;
                await SaveDataAsync();
            }

            return result;
        }

        /// <summary>
        /// Get selected key by name
        /// </summary>
        /// <param name="key">Name of key</param>
        /// <returns>Selcted key</returns>
        public UpdateItem GetItem(string key) => UpdateList.FirstOrDefault(x => x.Key == key);

        /// <summary>
        /// Read data from file
        /// </summary>
        /// <param name="Attempts">Number of attempts</param>
        /// <returns>Collection of items of type T</returns>
        public async Task ReadDataAsync(int Attempts = 0)
        {
            object ReadedObjects = null;
            Stream XmlStream = null;

            try
            {
                XmlSerializer Serializ = new XmlSerializer(typeof(UpdateHistoryFile));
                XmlStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(FileName);

                using (XmlStream)
                {
                    ReadedObjects = (UpdateHistoryFile)Serializ.Deserialize(XmlStream);
                }

                if (ReadedObjects != null)
                {
                    LastVersion = new Version(((UpdateHistoryFile)ReadedObjects).LastVersion);
                    UpdateList = ((UpdateHistoryFile)ReadedObjects).UpdateList;
                }
                else
                {
                    LastVersion = new Version(0, 0, 0, 0);
                    UpdateList = new List<UpdateItem>();
                }
            }

            // When is file unavailable - 10 attempts is enough
            catch (Exception s) when ((s.Message.Contains("denied")) && (Attempts < 10))
            {
                await ReadDataAsync(Attempts + 1);
            }

            catch
            {
                XmlStream?.Close();
                XmlStream?.Dispose();
                LastVersion = new Version(0, 0, 0, 0);
                UpdateList = new List<UpdateItem>();
            }
        }

        /// <summary>
        /// Save data to file
        /// </summary>
        /// <param name="Attempts">Number of attempts</param>
        /// <returns>True, if save was succesful</returns>
        public async Task<bool> SaveDataAsync(int Attempts = 0)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(UpdateHistoryFile));
                var v = Package.Current.Id.Version;
                Version packageVersion = new Version(v.Major, v.Minor, v.Build, v.Revision);

                using (Stream XmlStream = await ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync(FileName, CreationCollisionOption.ReplaceExisting))
                {
                    serializer.Serialize(XmlStream, new UpdateHistoryFile() { UpdateList = this.UpdateList, LastVersion = packageVersion.ToString() });
                }

                return true;
            }

            // When file is unavailable
            catch (Exception s) when ((s.Message.Contains("denied") || s.Message.Contains("is in use")) && (Attempts <= 10))
            {
                return await SaveDataAsync(Attempts + 1);
            }

            catch (Exception e)
            {
                new Exceptions.Exception(e.Message);
                return false;
            }
        }
    }
}


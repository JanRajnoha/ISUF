using ISUF.Base.Interface;
using ISUF.Base.Template;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Locator
{
    public class ManagerLocator : LocatorBase
    {
        Dictionary<string, IFake<BaseItem>> managerDictionary;

        public ManagerLocator()
        {
            managerDictionary = new Dictionary<string, IFake<BaseItem>>();
        }

        /// <summary>
        /// Return manager by ID
        /// </summary>
        /// <param name="managerID">Manager ID</param>
        /// <returns>Manager</returns>
        public IFake<BaseItem> GetManager(string managerID)
        {
            if (IsManagerExist(managerID))
                return managerDictionary[managerID];

            return null;
        }

        /// <summary>
        /// Add manager and assign ID
        /// </summary>
        /// <param name="newManager">New Manager</param>
        /// <param name="managerID">Manager ID</param>
        public void AddManager(IFake<BaseItem> newManager, string managerID)
        {
            if (!IsManagerExist(managerID))
                managerDictionary.Add(managerID, newManager);
        }

        /// <summary>
        /// Remove manager by ID
        /// </summary>
        /// <param name="managerID">Manager ID</param>
        public void RemoveManager(string managerID)
        {
            if (IsManagerExist(managerID))
                managerDictionary.Remove(managerID);
        }

        /// <summary>
        /// Check existence of manager by ID
        /// </summary>
        /// <param name="managerID">Manager ID</param>
        /// <returns>Existence</returns>
        public bool IsManagerExist(string managerID)
        {
            return managerDictionary.ContainsKey(managerID);
        }

        /// <summary>
        /// Get type of manager by ID
        /// </summary>
        /// <param name="managerID">Manager ID</param>
        /// <returns>Type of manager</returns>
        public Type GetTypeOfManager(string managerID)
        {
            if (IsManagerExist(managerID))
                return managerDictionary[managerID].GetType();

            return null;
        }

        /// <summary>
        /// Get managers by type
        /// </summary>
        /// <param name="managerType">Type of manager</param>
        /// <returns>Collection of managers</returns>
        public ObservableCollection<IFake<BaseItem>> GetManagersByType(Type managerType)
        {
            return new ObservableCollection<IFake<BaseItem>>(managerDictionary.Where(x => (x.Value.GetType() == managerType)).Select(y => y.Value).ToList());
        }
    }
}
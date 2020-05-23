using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISUF.Interface.Storage;
using ISUF.Base.Template;
using System.Collections.ObjectModel;
using ISUF.Security;

namespace ISUF.Storage.Manager
{
    /// <summary>
    /// Base item manager
    /// </summary>
    public class BaseItemManager : AtomicItemManager, IBaseItemManager
    {
        public BaseItemManager(IDatabaseAccess dbAccess, Type moduleItemType, string moduleName) : base(dbAccess, moduleItemType, moduleName)
        {

        }
        
        /// <summary>
        /// Return list of names of items
        /// </summary>
        /// <returns>List of names of items</returns>
        public virtual List<string> GetItemsNameList<T>() where T : BaseItem => GetAllItems<T>()?.Select(x => x.Name).ToList() ?? new List<string>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc/></typeparam>
        /// <returns><inheritdoc/></returns>
        public virtual async Task<List<T>> GetItemsAsync<T>() where T : BaseItem
        {
            var itemSource = dbAccess.GetAllItems<T>();

            foreach (var item in itemSource)
            {
                if (item.Secured && item.Encrypted)
                {
                    item.Name = Crypting.Decrypt(item.Name);
                    item.Description = Crypting.Decrypt(item.Description);
                    item.Encrypted = false;
                }
            }

            return itemSource;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Storage.Interface
{
    public interface IStorageManager<T>
    {
        void SetSourceCollection(ObservableCollection<T> source);

        Type GetClassType();
    }
}

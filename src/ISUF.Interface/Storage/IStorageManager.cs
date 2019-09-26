using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Interface.Storage
{
    public interface IStorageManager<T>
    {
        void SetSourceCollection(ObservableCollection<T> source);

        Type GetClassType();
    }
}

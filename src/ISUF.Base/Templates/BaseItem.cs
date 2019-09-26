using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace ISUF.Base.Template
{
    public class BaseItem : INotifyPropertyChanged, ICloneable
    {
        public bool Secured { get; set; }
        public int Id { get; set; } = -1;
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;

        [JsonIgnore]
        [XmlIgnore]
        public bool Encrypted { get; set; } = true;

        [JsonIgnore]
        [XmlIgnore]
        public string ManagerID { get; set; } = string.Empty;

        public BaseItem()
        {

        }

        public BaseItem(BaseItem baseItem) : this()
        {
            Secured = baseItem.Secured;
            Id = baseItem.Id;
            Name = baseItem.Name;
            Description = baseItem.Description;

            Encrypted = baseItem.Encrypted;
            ManagerID = baseItem.ManagerID;
        }

        public virtual object Clone()
        {
            return new BaseItem(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName]string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
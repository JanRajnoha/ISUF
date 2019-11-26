using ISUF.Base.Attributes;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace ISUF.Base.Template
{
    public class AtomicItem: INotifyPropertyChanged, ICloneable
    {
        public int Id { get; set; } = -1;
        public bool Secured { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;

        [JsonIgnore]
        [XmlIgnore]
        [UIIgnore]
        public string ManagerID { get; set; } = string.Empty;

        [JsonIgnore]
        [XmlIgnore]
        [UIIgnore]
        public bool Encrypted { get; set; } = true;

        public AtomicItem()
        {

        }

        public AtomicItem(AtomicItem baseItem) : this()
        {
            Secured = baseItem.Secured;
            Id = baseItem.Id;

            Encrypted = baseItem.Encrypted;
            ManagerID = baseItem.ManagerID;
        }

    public virtual object Clone()
    {
        return new AtomicItem(this);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void NotifyPropertyChanged([CallerMemberName]string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
}
using ISUF.Base.Attributes;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace ISUF.Base.Template
{
    /// <summary>
    /// Basic item type
    /// </summary>
    public class AtomicItem : INotifyPropertyChanged, ICloneable
    {
        /// <summary>
        /// Item index
        /// </summary>
        [UIParams(ReadOnlyMode = true, ShowDetailOnOneLine = true)]
        public int Id { get; set; } = -1;

        /// <summary>
        /// Item is secured
        /// </summary>
        [UIParams(UseLongTextInput = true, UIOrder = 30)]
        public bool Secured { get; set; }

        /// <summary>
        /// Creation of item
        /// </summary>
        [UIIgnore] // TODO opravit
        public DateTime Created { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Item was encrypted
        /// </summary>
        [JsonIgnore]
        [XmlIgnore]
        [UIIgnore]
        public bool Encrypted { get; set; } = true;

        public AtomicItem()
        {

        }

        /// <summary>
        /// Initialize new instance of item from existing one
        /// </summary>
        /// <param name="atomicItem">Existin item</param>
        public AtomicItem(AtomicItem atomicItem) : this()
        {
            Secured = atomicItem.Secured;
            Id = atomicItem.Id;

            Encrypted = atomicItem.Encrypted;
        }

        /// <inheritdoc/>
        public virtual object Clone()
        {
            return new AtomicItem(this);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return Id.ToString(); 
        }

        /// <summary>
        /// Property changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Property changed notification
        /// </summary>
        /// <param name="propertyName"></param>
        public void NotifyPropertyChanged([CallerMemberName]string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
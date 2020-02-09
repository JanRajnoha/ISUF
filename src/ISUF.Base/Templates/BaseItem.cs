using ISUF.Base.Attributes;
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
    public class BaseItem : AtomicItem
    {
        [UIParams(UIOrder = 1)]
        public string Name { get; set; }

        [UIParams(UseLongTextInput = true, UIOrder = 2)]
        public string Description { get; set; }

        public BaseItem()
        {

        }

        public BaseItem(BaseItem baseItem) : base(baseItem)
        {
            Name = baseItem.Name;
            Description = baseItem.Description;
        }

        public override object Clone()
        {
            return new AtomicItem(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName]string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
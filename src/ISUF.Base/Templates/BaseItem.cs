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
    /// <summary>
    /// Base item type
    /// </summary>
    public class BaseItem : AtomicItem
    {
        /// <summary>
        /// Name of item
        /// </summary>
        [UIParams(UIOrder = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Description of item
        /// </summary>
        [UIParams(UseLongTextInput = true, UIOrder = 2)]
        public string Description { get; set; }

        public BaseItem()
        {

        }

        /// <summary>
        /// Initialize new instance of item from existing one
        /// </summary>
        /// <param name="baseItem">Existing item</param>
        public BaseItem(BaseItem baseItem) : base(baseItem)
        {
            Name = baseItem.Name;
            Description = baseItem.Description;
        }

        /// <inheritdoc/>
        public override object Clone()
        {
            return new BaseItem(this);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
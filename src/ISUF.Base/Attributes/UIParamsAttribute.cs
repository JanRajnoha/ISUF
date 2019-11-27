using ISUF.Base.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class UIParamsAttribute : Attribute
    {
        public bool UseLongTextInput { get; set; }
        public bool UseLabelDescription { get; set; }
        public string LabelDescription { get; set; }
        public string DateLabel { get; set; }
        public DatePickerMode DateTimeMode { get; set; } = DatePickerMode.Date;
    }
}

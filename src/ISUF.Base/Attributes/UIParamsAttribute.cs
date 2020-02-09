using ISUF.Base.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class UIParamsAttribute : Attribute
    {
        [Required]
        public int UIOrder { get; set; } = 0;

        public bool UseLongTextInput { get; set; }
        public bool UseLabelDescription { get; set; }
        public string LabelDescription { get; set; }
        public DatePickerMode DateTimeMode { get; set; } = DatePickerMode.Date;
        public bool ReadOnlyMode { get; set; } = false;
        public string DateLabel { get; set; }
    }
}

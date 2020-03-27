using ISUF.Base.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISUF.Base.Attributes
{
    /// <summary>
    /// Attribute for modifying UI of property
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class UIParamsAttribute : Attribute
    {
        /// <summary>
        /// Order of property in UI
        /// </summary>
        [Required]
        public int UIOrder { get; set; } = 0;

        /// <summary>
        /// Set to use multiline text input for text input
        /// </summary>
        public bool UseLongTextInput { get; set; } = false;

        /// <summary>
        /// Set to use LabelDescription in UI for property
        /// </summary>
        public bool UseLabelDescription { get; set; } = false;

        /// <summary>
        /// Set label description for property in UI. Must be enabled UseLabelDescription
        /// </summary>
        public string LabelDescription { get; set; } = "";

        /// <summary>
        /// Select type of UI representation of DateTime property control in UI
        /// </summary>
        public DatePickerMode DateTimeMode { get; set; } = DatePickerMode.Date;

        /// <summary>
        /// Set value to read only mode
        /// </summary>
        public bool ReadOnlyMode { get; set; } = false;

        /// <summary>
        /// Set UI to one line style for property
        /// </summary>
        public bool ShowDetailOnOneLine { get; set; } = false;
    }
}

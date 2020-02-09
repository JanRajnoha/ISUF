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
    public class LinkedTableAttribute : Attribute
    {
        [Required]
        public Type LinkedTableType { get; set; }

        [Required]
        public LinkedTableRelation LinkedTableRelation { get; set; }
    }
}

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
    /// Attribute for linked tables
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class LinkedTableAttribute : Attribute
    {
        /// <summary>
        /// Type of linked table
        /// </summary>
        [Required]
        public Type LinkedTableType { get; set; }

        /// <summary>
        /// Type of relation
        /// </summary>
        [Required]
        public LinkedTableRelation LinkedTableRelation { get; set; }
    }
}

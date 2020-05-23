using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ISUF.UI.Design
{
    /// <summary>
    /// Model of registered destination property
    /// </summary>
    public class RegisteredDestinationProperty
    {
        public DependencyObject DestinationObject { get; set; }

        public DependencyProperty DestinationProperty { get; set; }

        public IValueConverter Converter { get; set; }

        public Type ConverterTargetType { get; set; }

        public string ConverterParameter { get; set; }

        public string ConverterLanguage { get; set; }
    }
}

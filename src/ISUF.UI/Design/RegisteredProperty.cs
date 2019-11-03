using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ISUF.UI.Design
{
    public class RegisteredProperty
    {
        public DependencyObject Object { get; set; }

        public DependencyProperty Property { get; set; }

        public IValueConverter Converter { get; set; }

        public Type ConverterTargetType { get; set; }

        public string ConverterParameter { get; set; }

        public string ConverterLanguage { get; set; }
    }
}

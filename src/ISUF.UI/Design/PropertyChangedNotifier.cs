using ISUF.Base.Classes;
using ISUF.Base.Messages;
using ISUF.UI.App;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ISUF.UI.Design
{
    public class PropertyChangedNotifier
    {
        private readonly ConcurrentDictionary<RegisteredProperty, string> registeredProperties = new ConcurrentDictionary<RegisteredProperty, string>();
        private readonly object bagLock = new object();

        public PropertyChangedNotifier()
        {
            ApplicationBase.Current.VMLocator.GetMessenger().Register<PropertyChangedMsg>(PropertyChanged);
        }

        private void PropertyChanged(PropertyChangedMsg obj)
        {
            var dependencies = registeredProperties.Where(x => x.Value == obj.PropertyName)?.Select(x => x.Key)?.ToList() ?? new List<RegisteredProperty>();

            for (int i = 0; i < dependencies.Count; i++)
            {
                object value = obj.PropertyValue;

                if (dependencies[i].Converter != null)
                    value = dependencies[i].Converter.Convert(obj.PropertyValue, dependencies[i].ConverterTargetType, dependencies[i].ConverterParameter, dependencies[i].ConverterLanguage);

                dependencies[i].Object.SetValue(dependencies[i].Property, value);
            }
        }

        public void RegisterProperty(DependencyObject destinationObject, DependencyProperty destinationProperty, IValueConverter converter, string propertyName, Type targetType = null, string parameter = null, string language = null)
        {
            lock (bagLock)
            {
                var registeredProperty = new RegisteredProperty()
                {
                    Object = destinationObject,
                    Property = destinationProperty,
                    Converter = converter,
                    ConverterLanguage = language,
                    ConverterParameter = parameter,
                    ConverterTargetType = targetType
                };

                registeredProperties[registeredProperty] = propertyName;
            }
        }

        public void UnregisterProperty(DependencyObject destinationObject, DependencyProperty destinationProperty, IValueConverter converter)
        {
            lock (bagLock)
            {
                var key = registeredProperties.Keys.FirstOrDefault(x => x.Object == destinationObject && x.Property == destinationProperty);

                if (key == null)
                    return;

                registeredProperties.TryRemove(key, out _);
            }
        }
    }
}

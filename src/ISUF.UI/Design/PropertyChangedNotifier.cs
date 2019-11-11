using ISUF.Base.Classes;
using ISUF.Base.Messages;
using ISUF.UI.App;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ISUF.UI.Design
{
    public class PropertyChangedNotifier
    {
        private readonly ConcurrentDictionary<RegisteredDestinationProperty, RegisteredTargetProperty> registeredProperties = new ConcurrentDictionary<RegisteredDestinationProperty, RegisteredTargetProperty>();
        private readonly object bagLock = new object();

        public PropertyChangedNotifier()
        {
            ApplicationBase.Current.VMLocator.GetMessenger().Register<PropertyChangedMsg>(PropertyChanged);
        }

        public static void NotifyPropertyChanged(Type parentObjectType, object value, [CallerMemberName] string propertyname = "")
        {
            var messenger = ApplicationBase.Current.VMLocator.GetMessenger();
            messenger.Send(new PropertyChangedMsg()
            {
                PropertyName = propertyname,
                PropertyValue = value
            });
        }

        private void PropertyChanged(PropertyChangedMsg obj)
        {
            var selectedRegisteredProperties = registeredProperties.Where(x => x.Value.PropertyName == obj.PropertyName/* && x.Value.PropertyParentObjectType == obj.PropertyParentObjectType*/);

            if (selectedRegisteredProperties == null)
                return;

            var destinationProperties = selectedRegisteredProperties.Select(x => x.Key)?.ToList();
            var targetProperty = selectedRegisteredProperties.Select(x => x.Value)?.FirstOrDefault();

            for (int i = 0; i < destinationProperties.Count; i++)
            {
                object value = obj.PropertyValue;

                if (!string.IsNullOrEmpty(targetProperty.PropertyInnerPropertyName))
                    value.GetType().GetProperty(targetProperty.PropertyInnerPropertyName).GetValue(value);

                if (destinationProperties[i].Converter != null)
                    value = destinationProperties[i].Converter.Convert(obj.PropertyValue, destinationProperties[i].ConverterTargetType, destinationProperties[i].ConverterParameter, destinationProperties[i].ConverterLanguage);

                destinationProperties[i].DestinationObject.SetValue(destinationProperties[i].DestinationProperty, value);
            }
        }

        public void RegisterProperty(DependencyObject destinationObject, DependencyProperty destinationProperty,
                                     string targetPropertyName, Type targetPropertyParentObjectType,
                                     string targetInnerPropertyName = "", IValueConverter converter = null,
                                     Type converterTargetType = null, string converterParameter = null,
                                     string converterLanguage = null)
        {
            lock (bagLock)
            {
                var registeredDestinationProperty = new RegisteredDestinationProperty()
                {
                    DestinationObject = destinationObject,
                    DestinationProperty = destinationProperty,
                    Converter = converter,
                    ConverterLanguage = converterLanguage,
                    ConverterParameter = converterParameter,
                    ConverterTargetType = converterTargetType
                };
                
                var registeredTargetProperty = new RegisteredTargetProperty()
                {
                    PropertyName = targetPropertyName,
                    PropertyParentObjectType = targetPropertyParentObjectType,
                    PropertyInnerPropertyName = targetInnerPropertyName
                };

                registeredProperties[registeredDestinationProperty] = registeredTargetProperty;
            }
        }

        public void UnregisterProperty(DependencyObject destinationObject, DependencyProperty destinationProperty, IValueConverter converter)
        {
            lock (bagLock)
            {
                var key = registeredProperties.Keys.FirstOrDefault(x => x.DestinationObject == destinationObject && x.DestinationProperty == destinationProperty);

                if (key == null)
                    return;

                registeredProperties.TryRemove(key, out _);
            }
        }
    }
}

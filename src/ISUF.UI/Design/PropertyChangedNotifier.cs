using ISUF.Base.Classes;
using ISUF.Base.Messages;
using ISUF.Base.Service;
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
    /// <summary>
    /// Property changed notifier, replace of <see cref="INotifyPropertyChanged"/>
    /// </summary>
    public class PropertyChangedNotifier
    {
        private readonly ConcurrentDictionary<RegisteredDestinationProperty, RegisteredTargetProperty> registeredProperties = new ConcurrentDictionary<RegisteredDestinationProperty, RegisteredTargetProperty>();
        private readonly object bagLock = new object();

        /// <summary>
        /// Init
        /// </summary>
        public PropertyChangedNotifier()
        {
            ApplicationBase.Current.VMLocator.GetMessenger().Register<PropertyChangedMsg>(PropertyChanged);
        }

        /// <summary>
        /// Notify all linked places about changed property
        /// </summary>
        /// <param name="parentObjectType">Parent object</param>
        /// <param name="value">Changed value</param>
        /// <param name="propertyName">Property name</param>
        public static void NotifyPropertyChanged(Type parentObjectType, object value, [CallerMemberName] string propertyName = "")
        {
            LogService.AddLogMessage("PropertyName: " + propertyName);

            var messenger = ApplicationBase.Current.VMLocator.GetMessenger();
            messenger.Send(new PropertyChangedMsg()
            {
                PropertyName = propertyName,
                PropertyValue = value,
                PropertyParentObjectType = parentObjectType
            });
        }

        /// <summary>
        /// Property changed message recieved
        /// </summary>
        /// <param name="obj">Message property changed</param>
        private void PropertyChanged(PropertyChangedMsg obj)
        {
            var selectedRegisteredProperties = registeredProperties.Where(x => x.Value.PropertyName == obj.PropertyName && x.Value.PropertyParentObjectType == obj.PropertyParentObjectType);

            if (selectedRegisteredProperties == null)
                return;

            var destinationProperties = selectedRegisteredProperties.Select(x => x.Key)?.ToList();
            var targetProperty = selectedRegisteredProperties.Select(x => x.Value)?.ToList();

            for (int i = 0; i < destinationProperties.Count; i++)
            {
                object value = obj.PropertyValue;

                if (!string.IsNullOrEmpty(targetProperty[i].PropertyInnerPropertyName))
                    value = value.GetType().GetProperty(targetProperty[i].PropertyInnerPropertyName).GetValue(value);

                if (destinationProperties[i].Converter != null)
                    value = destinationProperties[i].Converter.Convert(value, destinationProperties[i].ConverterTargetType, destinationProperties[i].ConverterParameter, destinationProperties[i].ConverterLanguage);

                destinationProperties[i].DestinationObject.SetValue(destinationProperties[i].DestinationProperty, value);
            }
        }

        /// <summary>
        /// Register property
        /// </summary>
        /// <param name="destinationObject">Destination object</param>
        /// <param name="destinationProperty">Destination property</param>
        /// <param name="targetPropertyName">Target property name</param>
        /// <param name="targetPropertyParentObjectType">Target property name parent opbject type</param>
        /// <param name="targetInnerPropertyName">target inner property name</param>
        /// <param name="converter">Converter</param>
        /// <param name="converterTargetType">Converter target type</param>
        /// <param name="converterParameter">Converter parameter</param>
        /// <param name="converterLanguage">Converter language</param>
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

        /// <summary>
        /// Unregister property
        /// </summary>
        /// <param name="destinationObject">Destination object</param>
        /// <param name="destinationProperty">Destination property</param>
        /// <param name="converter">Converter</param>
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

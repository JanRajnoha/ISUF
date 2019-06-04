using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ISUF.UI.Controls
{
    public sealed partial class DaysControl : UserControl, INotifyPropertyChanged
    {
        public static readonly DependencyProperty ParFly = DependencyProperty.Register("ParentFlyout", typeof(Flyout), typeof(DaysControl), new PropertyMetadata(null, ParentFlyoutChanged));

        private static void ParentFlyoutChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is Flyout)
            {
                var control = (DaysControl)d;
                control.ParentFlyout = (Flyout)e.NewValue;
            }
        }

        public ObservableCollection<DayOfWeek> SelectedDays { get; set; } = new ObservableCollection<DayOfWeek>();

        /// <summary>
        /// Parent flyout
        /// </summary>
        public Flyout ParentFlyout
        {
            get => (Flyout)GetValue(ParFly);
            set
            {
                SetValue(ParFly, value);
                NotifyPropertyChanged(nameof(ParentFlyout));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName]string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        bool AllDaysProcess = false;

        public DaysControl()
        {
            InitializeComponent();

            AllDays.IsChecked = true;
        }

        /// <summary>
        /// Close parent flyout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            ParentFlyout?.Hide();
        }

        /// <summary>
        /// Check, if changed CheckBox is or isn't in Obs.Col
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckChange(object sender, RoutedEventArgs e)
        {
            string ChangedStrDay = (sender as CheckBox).Name;

            if (!AllDaysProcess)
            {
                if (Container.Children.Where(x => x.GetType() == typeof(CheckBox)).Where(x => !((CheckBox)x).Content.ToString().ToUpper().Contains("ALL")).
                    Select(x => ((CheckBox)x).IsChecked).Where(x => x == true).ToList().Count != 0)
                {
                    AllDays.IsChecked = false;
                }
                else
                {
                    AllDays.IsChecked = true;
                }
            }

            DayOfWeek ChangedDay = StrToDayOfWeek(ChangedStrDay);

            if (!SelectedDays.Contains(ChangedDay))
                SelectedDays.Add(ChangedDay);
            else
                SelectedDays.Remove(ChangedDay);

            DataContext = SelectedDays;
        }

        /// <summary>
        /// Uncheck all days and fill collection with all days
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AllDaysCheck(object sender, RoutedEventArgs e)
        {
            AllDaysProcess = true;

            foreach (var WeekDay in (Container.Children.Where(x => x.GetType() == typeof(CheckBox)).Where(x => !((CheckBox)x).Content.ToString().ToUpper().Contains("ALL")).ToList()))
            {
                ((CheckBox)WeekDay).IsChecked = false;
            }

            for (int i = 0; i < 7; i++)
            {
                SelectedDays.Add((DayOfWeek)i);
            }

            AllDaysProcess = false;
        }

        /// <summary>
        /// If all days are unchecked, AllDays will be always checked, otherwise clear collection with days
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AllDaysUncheck(object sender, RoutedEventArgs e)
        {
            if (Container.Children.Where(x => x.GetType() == typeof(CheckBox)).Where(x => ((CheckBox)x).IsChecked == true).ToList().Count == 0)
            {
                AllDays.IsChecked = true;
            }

            SelectedDays.Clear();

            //SelectedDays = new ObservableCollection<DayOfWeek>();

            //SelectedDays.CollectionChanged += (s, arg) =>
            //{
            //    AddActivityComponent.Instance.RunTest();
            //};
        }

        /// <summary>
        /// Convert string to DayOfWeek
        /// </summary>
        /// <param name="StringDay">Day in string</param>
        /// <returns>string as DayOfWeek</returns>
        DayOfWeek StrToDayOfWeek(string StringDay)
        {
            int i = 0;
            if (!StringDay.ToUpper().Contains("ALL"))
                while (StringDay != ((DayOfWeek)i).ToString())
                    i++;

            return (DayOfWeek)i;
        }

        /// <summary>
        /// Load checked days
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Days_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
        {
            if (DataContext != null)
            {
                var DeliveredDays = (ObservableCollection<DayOfWeek>)DataContext;

                switch (DeliveredDays.Count)
                {
                    case 7:
                        AllDays.IsChecked = true;
                        break;

                    default:
                        foreach (var Day in (Container.Children.Where(x => x.GetType() == typeof(CheckBox))).Where(x => !((CheckBox)x).Content.ToString().ToUpper().Contains("ALL")).ToList())
                        {
                            DayOfWeek DeliveredDay = StrToDayOfWeek(((CheckBox)Day).Name);

                            if (DeliveredDays.Contains(DeliveredDay))
                                ((CheckBox)Day).IsChecked = true;
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Clear all CheckBoxes and check AllDays
        /// </summary>
        public void ClearDays()
        {
            AllDays.IsChecked = true;
        }
    }
}

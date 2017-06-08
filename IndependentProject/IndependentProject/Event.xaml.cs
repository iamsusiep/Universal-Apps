using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace IndependentProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Event : Page
    {
        public Event()
        {
            this.InitializeComponent();
        }

        private void DatePicker_SelectedDateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            //var picker = sender as DatePicker;

            //// ... Get nullable DateTime from SelectedDate.
            //DateTime? date = picker.Date;
            //if (date == null)
            //{
            //    // ... A null object.
            //    this.Title = "No date";
            //}
            //else
            //{
            //    // ... No need to display the time.
            //    this.Title = date.Value.ToShortDateString();
            //}
        }
    }
}

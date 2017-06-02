using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using PropertyChanged;

namespace Lab6.ViewModels
{
    [ImplementPropertyChanged]
    public class ForecastDayViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string LocationNameF { get; set; }
        public string TemperatureF { get; set; }
        public string DescriptionF { get; set; }
        public string ImageUrlF { get; set; }

    }


}

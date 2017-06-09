using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace IndependentProject.ViewModels
{
    [ImplementPropertyChanged]
    public class NewsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

       public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
   

        public ObservableCollection<NewsDayViewModel> News { get; }
        = new ObservableCollection<NewsDayViewModel>();
    }
}

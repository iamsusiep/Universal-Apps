using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentProject.ViewModels
{
[ImplementPropertyChanged]
        public class TechViewDayModel
        {
            public event PropertyChangedEventHandler PropertyChanged;

            public string author { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string urlToImage { get; set; }
        }
}

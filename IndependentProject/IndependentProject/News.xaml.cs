using IndependentProject.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static IndependentProject.Models.Conditions;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace IndependentProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class News : Page
    {
        public NewsViewModel ViewModel { get; set; } = new NewsViewModel();
        public News()
        {
           /* ViewModel.author = "author";
             ViewModel.title = "Title";
            ViewModel.description = "descript";
            ViewModel.url = "https://aspen.bsd405.org/aspen/logon.do";
            ViewModel.urlToImage = "https://si.wsj.net/public/resources/images/BN-TP889_g7ital_TOP_20170526084134.jpg";*/
            this.InitializeComponent();
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel.author = "";
            ViewModel.title = "";
            ViewModel.description = "Loading...";
            ViewModel.url = "";
            ViewModel.urlToImage = "https://upload.wikimedia.org/wikipedia/commons/3/3a/Gray_circles_rotate.gif";

            
            await UpdateNews();
        }

        private async Task UpdateNews()
        {
            NewsRetriever newsRetriever =new NewsRetriever();
            ConditionsRootObject conditionsRoot = await newsRetriever.GetConditions();

       
            ViewModel.author = conditionsRoot.articles.ElementAt(0).author;
            ViewModel.title = conditionsRoot.articles.ElementAt(0).title;
            ViewModel.description = conditionsRoot.articles.ElementAt(0).description;
            ViewModel.url = conditionsRoot.articles.ElementAt(0).url;
            ViewModel.urlToImage = conditionsRoot.articles.ElementAt(0).urlToImage;



        }



    }
}

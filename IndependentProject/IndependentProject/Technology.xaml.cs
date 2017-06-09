using IndependentProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static IndependentProject.Models.TechArticles;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace IndependentProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Technology : Page
    {
        public TechViewModel ViewModel { get; set; } = new TechViewModel();
        private ObservableCollection<TechViewDayModel> news;

        public Technology()
        {
            this.InitializeComponent();
            news = ViewModel.News;

        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            await UpdateTechNews();
        }
        private async Task UpdateTechNews()
        {
            NewsRetriever newsRetriever = new NewsRetriever();
            TechRootObject techRoot = await newsRetriever.GetTechArticles();
            TechViewDayModel first = new TechViewDayModel();

            first.author = techRoot.articles.ElementAt(0).author;
            first.title = techRoot.articles.ElementAt(0).title;
            first.description = techRoot.articles.ElementAt(0).description;
            first.url = techRoot.articles.ElementAt(0).url;
            first.urlToImage = techRoot.articles.ElementAt(0).urlToImage;
            news.Add(first);

            TechViewDayModel second = new TechViewDayModel();
            second.author = techRoot.articles.ElementAt(1).author;
            second.title = techRoot.articles.ElementAt(1).title;
            second.description = techRoot.articles.ElementAt(1).description;
            second.url = techRoot.articles.ElementAt(1).url;
            second.urlToImage = techRoot.articles.ElementAt(1).urlToImage;
            news.Add(second);

            TechViewDayModel third = new TechViewDayModel();
            third.author = techRoot.articles.ElementAt(2).author;
            third.title = techRoot.articles.ElementAt(2).title;
            third.description = techRoot.articles.ElementAt(2).description;
            third.url = techRoot.articles.ElementAt(2).url;
            third.urlToImage = techRoot.articles.ElementAt(2).urlToImage;
            news.Add(third);
            TechViewDayModel fourth = new TechViewDayModel();
            fourth.author = techRoot.articles.ElementAt(3).author;
            fourth.title = techRoot.articles.ElementAt(3).title;
            fourth.description = techRoot.articles.ElementAt(3).description;
            fourth.url = techRoot.articles.ElementAt(3).url;
            fourth.urlToImage = techRoot.articles.ElementAt(3).urlToImage;
            news.Add(fourth);

        }

    }
}

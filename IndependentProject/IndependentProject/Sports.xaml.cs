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
using static IndependentProject.Models.SportsArticles;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace IndependentProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Sports : Page
    {
        public SportsViewModel ViewModel { get; set; } = new SportsViewModel();
        private ObservableCollection<SportsDayViewModel> news;

        public Sports()
        {
            this.InitializeComponent();
            news = ViewModel.News;
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            await UpdateSportsNews();
        }
        private async Task UpdateSportsNews()
        {
            NewsRetriever newsRetriever = new NewsRetriever();
            SportsRootObject sportsRoot = await newsRetriever.GetSportsArticles();
            SportsDayViewModel first = new SportsDayViewModel();

            first.author = sportsRoot.articles.ElementAt(0).author;
            first.title = sportsRoot.articles.ElementAt(0).title;
            first.description = sportsRoot.articles.ElementAt(0).description;
            first.url = sportsRoot.articles.ElementAt(0).url;
            first.urlToImage = sportsRoot.articles.ElementAt(0).urlToImage;
            news.Add(first);

            SportsDayViewModel second = new SportsDayViewModel();
            second.author = sportsRoot.articles.ElementAt(1).author;
            second.title = sportsRoot.articles.ElementAt(1).title;
            second.description = sportsRoot.articles.ElementAt(1).description;
            second.url = sportsRoot.articles.ElementAt(1).url;
            second.urlToImage = sportsRoot.articles.ElementAt(1).urlToImage;
            news.Add(second);

            SportsDayViewModel third = new SportsDayViewModel();
            third.author = sportsRoot.articles.ElementAt(2).author;
            third.title = sportsRoot.articles.ElementAt(2).title;
            third.description = sportsRoot.articles.ElementAt(2).description;
            third.url = sportsRoot.articles.ElementAt(2).url;
            third.urlToImage = sportsRoot.articles.ElementAt(2).urlToImage;
            news.Add(third);
            SportsDayViewModel fourth = new SportsDayViewModel();
            fourth.author = sportsRoot.articles.ElementAt(3).author;
            fourth.title = sportsRoot.articles.ElementAt(3).title;
            fourth.description = sportsRoot.articles.ElementAt(3).description;
            fourth.url = sportsRoot.articles.ElementAt(3).url;
            fourth.urlToImage = sportsRoot.articles.ElementAt(3).urlToImage;
            news.Add(fourth);

        }
        private async Task MoreSportsNews()
        {
            NewsRetriever newsRetriever = new NewsRetriever();
            SportsRootObject sportsRoot = await newsRetriever.GetSportsArticles();
            SportsDayViewModel first = new SportsDayViewModel();

            first.author = sportsRoot.articles.ElementAt(4).author;
            first.title = sportsRoot.articles.ElementAt(4).title;
            first.description = sportsRoot.articles.ElementAt(4).description;
            first.url = sportsRoot.articles.ElementAt(4).url;
            first.urlToImage = sportsRoot.articles.ElementAt(4).urlToImage;
            news.Add(first);

            SportsDayViewModel second = new SportsDayViewModel();
            second.author = sportsRoot.articles.ElementAt(5).author;
            second.title = sportsRoot.articles.ElementAt(5).title;
            second.description = sportsRoot.articles.ElementAt(5).description;
            second.url = sportsRoot.articles.ElementAt(5).url;
            second.urlToImage = sportsRoot.articles.ElementAt(5).urlToImage;
            news.Add(second);

            SportsDayViewModel third = new SportsDayViewModel();
            third.author = sportsRoot.articles.ElementAt(6).author;
            third.title = sportsRoot.articles.ElementAt(6).title;
            third.description = sportsRoot.articles.ElementAt(6).description;
            third.url = sportsRoot.articles.ElementAt(6).url;
            third.urlToImage = sportsRoot.articles.ElementAt(6).urlToImage;
            news.Add(third);
            SportsDayViewModel fourth = new SportsDayViewModel();
            fourth.author = sportsRoot.articles.ElementAt(7).author;
            fourth.title = sportsRoot.articles.ElementAt(7).title;
            fourth.description = sportsRoot.articles.ElementAt(7).description;
            fourth.url = sportsRoot.articles.ElementAt(7).url;
            fourth.urlToImage = sportsRoot.articles.ElementAt(7).urlToImage;
            news.Add(fourth);

        }



        private void InnerFlyoutButton_Click(object sender, RoutedEventArgs e)
        {
            //MyFlyout.Hide();
            ////    int i = 5;
        ////    //e.OriginalSource
        }

        private async void More_Click(object sender, RoutedEventArgs e)
        {
            await MoreSportsNews();
            More.Visibility = Visibility.Collapsed;
           
        }

        //private void DatePicker_SelectedDateChanged(object sender, DatePickerValueChangedEventArgs e)
        //{
        //    //var picker = sender as DatePicker;

        //    //// ... Get nullable DateTime from SelectedDate.
        //    //DateTime? date = picker.Date;
        //    //if (date == null)
        //    //{
        //    //    // ... A null object.
        //    //    this.Title = "No date";
        //    //}
        //    //else
        //    //{
        //    //    // ... No need to display the time.
        //    //    this.Title = date.Value.ToShortDateString();
        //    //}
        //}
    }
}

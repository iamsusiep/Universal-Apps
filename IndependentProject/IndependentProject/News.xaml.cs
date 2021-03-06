﻿using IndependentProject.ViewModels;
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
using static IndependentProject.Models.Conditions;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
// Website reference for message dialog: https://reflectionit.nl/blog/2015/windows-10-xaml-tips-messagedialog-and-contentdialog 

namespace IndependentProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class News : Page
    {
        public NewsViewModel ViewModel { get; set; } = new NewsViewModel();
        private ObservableCollection<NewsDayViewModel> news;
//        public NewsViewModel ViewModel { get; set; } = new NewsViewModel();
        public News()
        {
            this.InitializeComponent();
            news = ViewModel.News;
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel.description = "";
            ViewModel.author = "";
            ViewModel.title = "Loading...";

            await UpdateNews();
        }

        private async Task UpdateNews()
        {
            NewsRetriever newsRetriever =new NewsRetriever();
            ConditionsRootObject conditionsRoot = await newsRetriever.GetConditions();
            NewsDayViewModel first = new NewsDayViewModel();

            first.author = conditionsRoot.articles.ElementAt(0).author;
            first.title = conditionsRoot.articles.ElementAt(0).title;
            first.description = conditionsRoot.articles.ElementAt(0).description;
            first.url = conditionsRoot.articles.ElementAt(0).url;
            first.urlToImage = conditionsRoot.articles.ElementAt(0).urlToImage;
            news.Add(first);

            NewsDayViewModel second = new NewsDayViewModel();
            second.author = conditionsRoot.articles.ElementAt(1).author;
            second.title = conditionsRoot.articles.ElementAt(1).title;
            second.description = conditionsRoot.articles.ElementAt(1).description;
            second.url = conditionsRoot.articles.ElementAt(1).url;
            second.urlToImage = conditionsRoot.articles.ElementAt(1).urlToImage;
            news.Add(second);

            NewsDayViewModel third = new NewsDayViewModel();
            third.author = conditionsRoot.articles.ElementAt(2).author;
            third.title = conditionsRoot.articles.ElementAt(2).title;
            third.description = conditionsRoot.articles.ElementAt(2).description;
            third.url = conditionsRoot.articles.ElementAt(2).url;
            third.urlToImage = conditionsRoot.articles.ElementAt(2).urlToImage;
            news.Add(third);
            NewsDayViewModel fourth = new NewsDayViewModel();
            fourth.author = conditionsRoot.articles.ElementAt(3).author;
            fourth.title = conditionsRoot.articles.ElementAt(3).title;
            fourth.description = conditionsRoot.articles.ElementAt(3).description;
            fourth.url = conditionsRoot.articles.ElementAt(3).url;
            fourth.urlToImage = conditionsRoot.articles.ElementAt(3).urlToImage;
            news.Add(fourth);


        }

        private async Task MoreNews()
        {
            NewsRetriever newsRetriever = new NewsRetriever();
            ConditionsRootObject conditionsRoot = await newsRetriever.GetConditions();
            NewsDayViewModel first = new NewsDayViewModel();

            first.author = conditionsRoot.articles.ElementAt(4).author;
            first.title = conditionsRoot.articles.ElementAt(4).title;
            first.description = conditionsRoot.articles.ElementAt(4).description;
            first.url = conditionsRoot.articles.ElementAt(4).url;
            first.urlToImage = conditionsRoot.articles.ElementAt(4).urlToImage;
            news.Add(first);

            NewsDayViewModel second = new NewsDayViewModel();
            second.author = conditionsRoot.articles.ElementAt(5).author;
            second.title = conditionsRoot.articles.ElementAt(5).title;
            second.description = conditionsRoot.articles.ElementAt(5).description;
            second.url = conditionsRoot.articles.ElementAt(5).url;
            second.urlToImage = conditionsRoot.articles.ElementAt(5).urlToImage;
            news.Add(second);

            NewsDayViewModel third = new NewsDayViewModel();
            third.author = conditionsRoot.articles.ElementAt(6).author;
            third.title = conditionsRoot.articles.ElementAt(6).title;
            third.description = conditionsRoot.articles.ElementAt(6).description;
            third.url = conditionsRoot.articles.ElementAt(6).url;
            third.urlToImage = conditionsRoot.articles.ElementAt(6).urlToImage;
            news.Add(third);
            NewsDayViewModel fourth = new NewsDayViewModel();
            fourth.author = conditionsRoot.articles.ElementAt(7).author;
            fourth.title = conditionsRoot.articles.ElementAt(7).title;
            fourth.description = conditionsRoot.articles.ElementAt(7).description;
            fourth.url = conditionsRoot.articles.ElementAt(7).url;
            fourth.urlToImage = conditionsRoot.articles.ElementAt(7).urlToImage;
            news.Add(fourth);


        }

        private async void More_Click(object sender, RoutedEventArgs e)
        {
            await MoreNews();
            More.Visibility = Visibility.Collapsed;
        }

        private async void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            string x = "URL: \n" + ((NewsDayViewModel)e.ClickedItem).url;
            var dialog = new Windows.UI.Popups.MessageDialog(x);
            dialog.Commands.Add(new Windows.UI.Popups.UICommand("Close") { Id = 0 });
            dialog.CancelCommandIndex = 0;

            var result = await dialog.ShowAsync();
            var btn = sender as Button;
        }
    }
}

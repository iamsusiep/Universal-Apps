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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IndependentProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {

            this.InitializeComponent();
            BackButton.Visibility = Visibility.Collapsed;

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
             
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BackButton.Visibility = Visibility.Collapsed;

            if (SportsListBoxItem.IsSelected)
            {

                frame.Navigate(typeof(Sports));
                Title.Text = "Sports";
                BackButton.Visibility = Visibility.Visible;

            }

            if (TechListBoxItem.IsSelected)
            {
                frame.Navigate(typeof(Technology));
                Title.Text = "Technology";
                BackButton.Visibility = Visibility.Visible;

            }
            if (NewsListBoxItem.IsSelected)
            {

                frame.Navigate(typeof(News));
                Title.Text = "Business";
                BackButton.Visibility = Visibility.Visible;

            }

        }
        /* https://stackoverflow.com/questions/31002778/how-to-get-info-about-previous-page-on-frame-goback/ */
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            BackButton.Visibility = Visibility.Collapsed;

            if (frame.CanGoBack)
            {

                var recent = frame.BackStack.LastOrDefault();
                frame.GoBack();

                if (recent != null && recent.SourcePageType.Equals(typeof(Sports)))
                {
                    Title.Text = "Sports";
                }
                if (recent != null && recent.SourcePageType.Equals(typeof(Technology)))
                {
                    Title.Text = "Technology";
                }
                if (recent != null && recent.SourcePageType.Equals(typeof(News)))
                {
                    Title.Text = "Business";
                }

            }
            else
            {
                frame.Navigate(typeof(MainPageFrame));
                Title.Text = "News";
            }
          
        }
    }
}

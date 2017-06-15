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
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SportsListBoxItem.IsSelected)
            {
                //BackButton.Visibility = Visibility.Visible;

                frame.Navigate(typeof(Sports));
                Title.Text = "Sports";
            }

            if (TechListBoxItem.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                frame.Navigate(typeof(Technology));
                Title.Text = "Technology";
            }
            if (NewsListBoxItem.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;

                frame.Navigate(typeof(News));
                Title.Text = "Business";
            }

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            BackButton.Visibility = Visibility.Collapsed;
           
            if (frame.CanGoBack)
           {
              frame.GoBack();
           }
          
        }
    }
}

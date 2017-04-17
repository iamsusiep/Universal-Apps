﻿using System;
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

namespace Lecture
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            InnerFrame.Navigate(typeof(Page1));
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            InnerFrame.Navigate(typeof(Page1));
        
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
               if (InnerFrame.CanGoBack)
            {
                InnerFrame.GoBack();
            }
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            if (InnerFrame.CanGoBack)
            {
                InnerFrame.GoForward();
            }
        }



        //private void Button1_Click(object sender, RoutedEventArgs e)
        //{
        //    TextBlock1.Text = "Hello World!";
        //}

        //private void WHAT_Click(object sender, RoutedEventArgs e)
        //{
        //    TextBlock1.Text = "Annie W0ng";
        //}
    }
}

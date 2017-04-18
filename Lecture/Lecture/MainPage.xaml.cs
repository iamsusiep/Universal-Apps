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
            //InnerFrame.Navigate(typeof(Page1));
        }


        private void MyCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MyCheckBox.IsChecked.Value)
            {
                CheckBoxResultTextBlock.Text = "Yes";
            }
           else
            {
                CheckBoxResultTextBlock.Text = "No";
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (YesRadioButton.IsChecked.Value)
            {
                RadioButtonTextBlock.Text = "Yes";
            }
            else
            {
                RadioButtonTextBlock.Text = "No";
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxResultTextBlock != null)
            {
                ComboBox combo = (ComboBox)sender;
                ComboBoxItem item = (ComboBoxItem)combo.SelectedItem;

                ComboBoxResultTextBlock.Text = item.Content.ToString();
            }
        }

        private void Listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string itemsStr = "";
            foreach(object item in MyListBox.Items)
            {
                ListBoxItem listBoxItem = (ListBoxItem)item;
                if (listBoxItem.IsSelected)
                {
                    itemsStr += listBoxItem.Content.ToString() + " ";
                }

            }
            ListBoxResultTextBlock.Text = itemsStr;
        }

        private void MyToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyToggleButton.IsChecked.HasValue)
            {
                if (MyToggleButton.IsChecked.Value == true)
                {
                    ToggleButtonResultTextBlock.Text = "True";
                }
                else
                {
                    ToggleButtonResultTextBlock.Text = "False";
                }
            }
            else
            {
                ToggleButtonResultTextBlock.Text = "Null";
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

﻿using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lecture
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //private ObservableCollection<Book> Books;
        //public MainPage()
        //{
        //    Books = BookManager.GetBooks();
        //    this.InitializeComponent();
        //    //InnerFrame.Navigate(typeof(Page1));
        //}

        //private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    var book = (Book)e.ClickedItem;
        //    ResultTextBlock.Text = "You selected " + book.Title;
        //}

        //private void Annie_Click(object sender, RoutedEventArgs e)
        //{
        //    //var book = new Book { 1, "Annie", "Poop" ,0};
        //    Books.Add(new Book { BookId = 4, Title = "Annie's", Author = "Poop", CoverImage = "Assets/4.png" });

        //}

        //private void MyCalendarView_SelectionDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        //{
        //    var selectedDates = sender.SelectedDates
        //    .Select(p => p.Date.Month.ToString() + "/" + p.Date.Day.ToString())
        //    .ToArray();

        //    var values = string.Join(",", selectedDates);
        //    CalendarViewResultTextBlock.Text = values;
        //}
        //private void InnerFlyoutButton_Click(object sender, RoutedEventArgs e)
        //{
        //    MyFlyout.Hide();
        //}
        //private string[] selectionItems = new string[]
        //    {"Ferdinand", "Frank", "Nigel", "Tag", "Tanya", "Tanner", "Todd"};

        //private void MyAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        //{
        //    var autoSuggestBox = (AutoSuggestBox)sender;
        //    var filtered = selectionItems
        //        .Where(p => p.StartsWith(autoSuggestBox.Text))
        //        .ToArray();
        //    autoSuggestBox.ItemsSource = filtered;
        //}
        //private void HamburgerButton_Click(Object sender, RoutedEventArgs e)
        //{
        //    MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        //}
        //private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (ShareListBoxItem.IsSelected)
        //    {
        //        ResultTextBlock.Text = "Share";
        //    }
        //    else if (FavoritesListBoxItem.IsSelected)
        //    {
        //        ResultTextBlock.Text = "Favorites";
        //    }
        //}

        //private void MyCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    if (MyCheckBox.IsChecked.Value)
        //    {
        //        CheckBoxResultTextBlock.Text = "Yes";
        //    }
        //   else
        //    {
        //        CheckBoxResultTextBlock.Text = "No";
        //    }
        //}

        //private void RadioButton_Checked(object sender, RoutedEventArgs e)
        //{
        //    if (YesRadioButton.IsChecked.Value)
        //    {
        //        RadioButtonTextBlock.Text = "Yes";
        //    }
        //    else
        //    {
        //        RadioButtonTextBlock.Text = "No";
        //    }
        //}

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (ComboBoxResultTextBlock != null)
        //    {
        //        ComboBox combo = (ComboBox)sender;
        //        ComboBoxItem item = (ComboBoxItem)combo.SelectedItem;

        //        ComboBoxResultTextBlock.Text = item.Content.ToString();
        //    }
        //}

        //private void Listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    string itemsStr = "";
        //    foreach(object item in MyListBox.Items)
        //    {
        //        ListBoxItem listBoxItem = (ListBoxItem)item;
        //        if (listBoxItem.IsSelected)
        //        {
        //            itemsStr += listBoxItem.Content.ToString() + " ";
        //        }

        //    }
        //    ListBoxResultTextBlock.Text = itemsStr;
        //}

        //private void MyToggleButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (MyToggleButton.IsChecked.HasValue)
        //    {
        //        if (MyToggleButton.IsChecked.Value == true)
        //        {
        //            ToggleButtonResultTextBlock.Text = "True";
        //        }
        //        else
        //        {
        //            ToggleButtonResultTextBlock.Text = "False";
        //        }
        //    }
        //    else
        //    {
        //        ToggleButtonResultTextBlock.Text = "Null";
        //    }
        //}



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

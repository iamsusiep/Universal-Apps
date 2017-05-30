using Lab6.ViewModels;
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
using System.Threading.Tasks;
using static Lab6.Models.Conditions;
using static Lab6.Models.AutoComplete;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lab6
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /*public MainPageViewModel ViewModel { get; set; } = new MainPageViewModel();
        public MainPage()
        {
            this.InitializeComponent();
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel.Description = "";
            ViewModel.LocationName = "";
            ViewModel.Temperature = "Loading...";
            ViewModel.ImageUrl = "https://upoad.wikimedia.org/wikipedia/commons/3/3a/Gray_circles_rotate.gif";
            await UpdateWeather("/q/CA/San_Fracisco");
        }

        private async Task UpdateWeather(string cityLink)
        {
            WeatherRetriever weatherRetriever = new WeatherRetriever();
            ConditionsRootObject conditionsRoot = await weatherRetriever.GetConditions(cityLink);

            ViewModel.Description = conditionsRoot.current_observation.weather;
            ViewModel.LocationName = conditionsRoot.current_observation.display_location.full;
            ViewModel.Temperature = conditionsRoot.current_observation.temperature_string;
            ViewModel.ImageUrl = conditionsRoot.current_observation.icon_url;
        }

        private async Task SearchForCities(string userText)
        {
            WeatherRetriever weatherRetriever = new Lab6.WeatherRetriever();
            AutoCompleteRootObject autoCompleteRoot = await weatherRetriever.GetSuggestions(userText);

            LocationAutoSuggestBox.ItemsSource = autoCompleteRoot.RESULTS;
        }
        private async Task ChangeCity(object selectedCity)
        {
            string selectedCityLink = ((RESULT)selectedCity).l;

            await UpdateWeather(selectedCityLink);
        }
        private async void LocationAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                await SearchForCities(LocationAutoSuggestBox.Text);
            }
        }
        private async void LocationAutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            string selectedCityLink = ((RESULT)args.SelectedItem).l;
            await UpdateWeather(selectedCityLink);
        }
        private async void LocationAutoSuggestBox_QuerySubmitted (AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if(args.ChosenSuggestion != null)
            {
                await ChangeCity(args.ChosenSuggestion);
            }
            else
            {
                await SearchForCities(args.QueryText);
            }
        }
    }*/
    }
}

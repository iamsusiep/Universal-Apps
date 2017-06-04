using Lab6.ViewModels;
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
using static Lab6.Models.AutoComplete;
using static Lab6.Models.Conditions;
using static Lab6.Models.Forecast.Forecast;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lab6
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPageViewModel ViewModel { get; set; } = new MainPageViewModel();
       // public ForecastDayViewModel ViewForecast { get; set; } = new ForecastDayViewModel();
        private ObservableCollection<ForecastDayViewModel> forecasts;
        public MainPage()
        {
            this.InitializeComponent();
            forecasts = ViewModel.Forecast;
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel.Description = "";
            ViewModel.LocationName = "";
            ViewModel.Temperature = "Loading...";
            ViewModel.ImageUrl = "https://icons.wxug.com/i/c/c/snow.gif";

           // forecasts.Add(new ForecastDayViewModel { Description="", Date="", Temperature ="Loading...", ImageUrl="https://icons.wxug.com/i/c/c/snow.gif" });
            ///  ViewForecast.Description = "";
            /// ViewForecast.Date = "";
            /// ViewForecast.Temperature = "Loading...";
            /// ViewForecast.ImageUrl = "https://icons.wxug.com/i/c/c/snow.gif";

            await UpdateWeather("/q/CA/San_Francisco");

        }

        private async Task UpdateWeather(string cityLink)
        {
            WeatherRetriever weatherRetriever = new Lab6.WeatherRetriever();
            ConditionsRootObject conditionsRoot = await weatherRetriever.GetConditions(cityLink);

            ViewModel.Description = conditionsRoot.current_observation.weather;
            ViewModel.LocationName = conditionsRoot.current_observation.display_location.full;
            ViewModel.Temperature = conditionsRoot.current_observation.temperature_string;
            ViewModel.ImageUrl = conditionsRoot.current_observation.icon_url;

            ForecastRootObject forecastRoot = await weatherRetriever.GetForecast(cityLink);
            ForecastDayViewModel ViewForecast = new ForecastDayViewModel();
             ViewForecast.Date = forecastRoot.forecast.txt_forecast.date;
            ViewForecast.Temperature = forecastRoot.forecast.simpleforecast.forecastday.ElementAt(0).low.fahrenheit;
             ViewForecast.ImageUrl = forecastRoot.forecast.simpleforecast.forecastday.ElementAt(0).icon_url;
            ViewForecast.Description = forecastRoot.forecast.simpleforecast.forecastday.ElementAt(0).conditions;
            forecasts.Add(ViewForecast);
            ForecastDayViewModel ViewForecast1 = new ForecastDayViewModel();
            ViewForecast1.Date = forecastRoot.forecast.txt_forecast.date;
            ViewForecast1.Temperature = forecastRoot.forecast.simpleforecast.forecastday.ElementAt(1).low.fahrenheit;
            ViewForecast1.ImageUrl = forecastRoot.forecast.simpleforecast.forecastday.ElementAt(1).icon_url;
            ViewForecast1.Description = forecastRoot.forecast.simpleforecast.forecastday.ElementAt(1).conditions;
            forecasts.Add(ViewForecast1);
            ForecastDayViewModel ViewForecast2 = new ForecastDayViewModel();

            ViewForecast2.Date = forecastRoot.forecast.txt_forecast.date;
            ViewForecast2.Temperature = forecastRoot.forecast.simpleforecast.forecastday.ElementAt(2).low.fahrenheit;
            ViewForecast2.ImageUrl = forecastRoot.forecast.simpleforecast.forecastday.ElementAt(2).icon_url;
            ViewForecast2.Description = forecastRoot.forecast.simpleforecast.forecastday.ElementAt(2).conditions;
            forecasts.Add(ViewForecast2);
            ForecastDayViewModel ViewForecast3 = new ForecastDayViewModel();

            ViewForecast3.Date = forecastRoot.forecast.txt_forecast.date;
            ViewForecast3.Temperature = forecastRoot.forecast.simpleforecast.forecastday.ElementAt(3).low.fahrenheit;
            ViewForecast3.ImageUrl = forecastRoot.forecast.simpleforecast.forecastday.ElementAt(3).icon_url;
            ViewForecast3.Description = forecastRoot.forecast.simpleforecast.forecastday.ElementAt(3).conditions;
            forecasts.Add(ViewForecast3);


        }

        private async Task SearchForCities(string userText)
        {
            WeatherRetriever weatherRetriever = new Lab6.WeatherRetriever();
            AutoCompleteRootObject autoCompleteRoot = await weatherRetriever.GetSuggestions(userText);
            LocationAutoSuggestBox.ItemsSource = autoCompleteRoot.RESULTS;
        }

        private async Task changeCity(object selectedCity)
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

        private async void LocationAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (args.ChosenSuggestion != null)
            {
                await changeCity(args.ChosenSuggestion);
            }
            else
            {
                await SearchForCities(args.QueryText);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Lab6.Models;
using Newtonsoft.Json;
using static Lab6.Models.Conditions;
using static Lab6.Models.AutoComplete;

namespace Lab6
{
    class WeatherRetriever
    {
        private string apiKey = "72074f4c1301e164";

        public async Task<ConditionsRootObject> GetConditions(string cityLink)
        {
            HttpClient httpClient = new HttpClient();
            string apiUrl = $"http://api.wunderground.com/api/{apiKey}/conditions{cityLink}.json";
            string responseString = await httpClient.GetStringAsync(apiUrl);
            ConditionsRootObject conditions = JsonConvert.DeserializeObject<ConditionsRootObject>(responseString);
            return conditions;
        }
        public async Task<AutoCompleteRootObject> GetSuggestions(string enteredStr)
        {
            HttpClient httpClient = new HttpClient();
            string apiUrl = $"http://autocomplete.wunderground.com/aq?query={enteredStr}&c=US";
            string responseString = await httpClient.GetStringAsync(apiUrl);
            AutoCompleteRootObject conditions = JsonConvert.DeserializeObject<AutoCompleteRootObject>(responseString);
            return conditions;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndependentProject.Models;
using System.Net.Http;
using Newtonsoft.Json;
using static IndependentProject.Models.Conditions;

namespace IndependentProject
{
    class NewsRetriever
    {
        private string apiKey = "f3d8be790a344fffb4e4d640244046a1";

        public async Task<ConditionsRootObject> GetConditions()
        {
            HttpClient httpClient = new HttpClient();
            string apiUrl = $"https://newsapi.org/v1/articles?source=the-wall-street-journal&sortBy=top&apiKey=f3d8be790a344fffb4e4d640244046a1";
            string responseString = await httpClient.GetStringAsync(apiUrl);
            ConditionsRootObject conditions = JsonConvert.DeserializeObject<ConditionsRootObject>(responseString);
            return conditions;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndependentProject.Models;
using System.Net.Http;
using Newtonsoft.Json;
using static IndependentProject.Models.Conditions;
using static IndependentProject.Models.TechArticles;
using static IndependentProject.Models.SportsArticles;

namespace IndependentProject
{
    class NewsRetriever
    {
        private string apiKey = "f3d8be790a344fffb4e4d640244046a1";

        public async Task<ConditionsRootObject> GetConditions()
        {
            HttpClient httpClient = new HttpClient();
            string apiUrl = $"https://newsapi.org/v1/articles?source=the-wall-street-journal&sortBy=top&apiKey={apiKey}";
            string responseString = await httpClient.GetStringAsync(apiUrl);
            ConditionsRootObject conditions = JsonConvert.DeserializeObject<ConditionsRootObject>(responseString);
            return conditions;
        }

        public async Task<TechRootObject> GetTechArticles()
        {
            HttpClient httpClient = new HttpClient();
            string apiUrl = $"https://newsapi.org/v1/articles?source=the-verge&sortBy=latest&apiKey={apiKey}";
            string responseString = await httpClient.GetStringAsync(apiUrl);
            TechRootObject techarticles = JsonConvert.DeserializeObject<TechRootObject>(responseString);
            return techarticles;
        }
        public async Task<SportsRootObject> GetSportsArticles()
        {
            HttpClient httpClient = new HttpClient();
            string apiUrl = $"https://newsapi.org/v1/articles?source=talksport&sortBy=top&apiKey={apiKey}";
            string responseString = await httpClient.GetStringAsync(apiUrl);
            SportsRootObject sportsarticles = JsonConvert.DeserializeObject<SportsRootObject>(responseString);
            return sportsarticles;
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//f3d8be790a344fffb4e4d640244046a1
namespace IndependentProject.Models
{
    public class Conditions
    {
        public class Article
        {
            public string author { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string url { get; set; }
            public string urlToImage { get; set; }
            public string publishedAt { get; set; }
        }

        public class ConditionsRootObject
        {
            public string status { get; set; }
            public string source { get; set; }
            public string sortBy { get; set; }
            public List<Article> articles { get; set; }
        }

    }
}

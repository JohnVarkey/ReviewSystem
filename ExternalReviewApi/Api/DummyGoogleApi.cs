using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using ExternalReviewApi.Models;

namespace ExternalReviewApi.Api
{

    public class DummyGoogleApi
    {
        static readonly HttpClient client = new HttpClient();
        public string Path { get; set; } = "https://api.json-generator.com/templates/RVCLe4xTyLq3/data";

        public Task<List<DummyGoogleReview>> GetReviews()
        {
            client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", "s099pv49ke5e9ep6i1prl6ua4qdrccyy0mp60zhb");
            return client.GetFromJsonAsync<List<DummyGoogleReview>>(Path);
        }
     
    }
}

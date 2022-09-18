using System.Net.Http.Headers;
using System.Net.Http.Json;
using ExternalReviewApi.Models;

namespace ExternalReviewApi.Api
{
    public class DummyFacebookApi
    {
        static readonly HttpClient client = new HttpClient();
        public string Path { get; set; } = "https://api.json-generator.com/templates/V4fgnoIM2wIa/data";

        public Task<List<DummyFacebookReview>> GetReviews()
        {
            client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", "s099pv49ke5e9ep6i1prl6ua4qdrccyy0mp60zhb");
            return client.GetFromJsonAsync<List<DummyFacebookReview>>(Path);
        }
     
    }
}
